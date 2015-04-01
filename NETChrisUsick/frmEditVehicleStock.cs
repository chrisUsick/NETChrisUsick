using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataTier;

namespace NETChrisUsick
{
    public partial class frmEditVehicleStock : Form
    {
        // binding source for this form
        private BindingSource bindingSource;

        // data tier reference
        private VehicleStockData vehicleStockData;

        // action of the form
        private AutomotiveManager.FormAction formAction;

        // list of controls with errors
        private List<Control> controlsWithErrors = new List<Control>();

        // exit choice of user
        private DialogResult exitChoice = DialogResult.None;

        /// <summary>
        /// constructs a new form
        /// </summary>
        /// <param name="formAction">whether the form is for creating or editing</param>
        /// <param name="bindingSource">the binding source the form should use</param>
        /// <param name="vehicleStockData">the data tier object</param>
        public frmEditVehicleStock(AutomotiveManager.FormAction formAction, 
            BindingSource bindingSource, 
            VehicleStockData vehicleStockData)
        {
            InitializeComponent();

            this.formAction = formAction;
            this.bindingSource = bindingSource;
            this.vehicleStockData = vehicleStockData;

        }

        /// <summary>
        /// handle the form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEditVehicleStock_Shown(object sender, EventArgs e)
        {
            if (formAction == AutomotiveManager.FormAction.New)
            {
                //create a new record
                DataRowView newData = (DataRowView)bindingSource.AddNew();
                newData["Automatic"] = true;
                //set title
                Text = "New" + Text;
            }
            else
            {
                Text = "Edit" + Text;

                // disable stock number
                txtStockNumber.Enabled = false;
            }

            // add some validation handlers
            addEventHandlers();

            // bind controls
            try
            {
                List<Control> controls = new List<Control>();
                controls.AddRange(new Control[] {
                    txtStockNumber,
                    txtYear,
                    txtMake,
                    txtModel,
                    radAutomatic,
                    txtMileage,
                    txtColour,
                    txtBasePrice
                });
                // loop through controls
                controls.ForEach(control =>
                {
                    string columnName = (control == txtYear) ? "ManufacturedYear" : control.Name.Substring(3);
                    // rad manual is binding to the automcatic column in the DB
                    if (control == radManual)
                    {
                        columnName = "Automatic";
                    }
                    //call bind control, accounting for variations of the general pattern of naming.
                    bindControl(control,
                        columnName,
                        (control.GetType() == typeof(RadioButton)) ? "Checked" : "Text");
                });
            }
            catch (Exception)
            {
                // show load error message
                AutomotiveManager.ShowMessage(
                        "Could not load record.",
                        "DataBase Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                // close form
                Close();
                throw;
            }
        }
        
        /// <summary>
        /// add additional validation event handlers.
        /// </summary>
        private void addEventHandlers()
        {
            // make sure ID isn't a duplicate
            txtStockNumber.Validating += new CancelEventHandler(delegate(object sender, CancelEventArgs e)
            {
                string stockNumber = txtStockNumber.Text.Trim();
                // is the length is less than 1 another validating handler will handle that.
                if (formAction == AutomotiveManager.FormAction.New
                    && stockNumber.Length > 0 
                    && vehicleStockData.IsDuplicateStockNumber(stockNumber))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtStockNumber,
                        "This stock number is used by another vehicle. Please enter another stock number.");

                    addErrorSetFocus(txtStockNumber);
                }
            });

            // validate a valid year
            txtYear.Validating += new CancelEventHandler(delegate(object sender, CancelEventArgs e)
            {
                int year;
                if (int.TryParse(txtYear.Text, out year) && year < 10000 && year > 999)
                {
                    // no error
                }
                else
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtYear, " Please enter a valid four digit year. Eg. 1977");
                    addErrorSetFocus(txtYear);
                }
            });

            txtMileage.Validating += new CancelEventHandler(textBoxNumeric_Validating);
        }

        /// <summary>
        /// validate a numeric textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void textBoxNumeric_Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.Text = textbox.Text.Trim();
            // if there is no text don't validate here
            if (textbox.Text.Length > 0 && !AutomotiveManager.IsNumeric(textbox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textbox, "Please enter a numeric value for this field.");

                addErrorSetFocus(textbox);
            }
        }

        /// <summary>
        /// bind the text properties of a control to the given columnName
        /// </summary>
        /// <param name="control">Control to bind</param>
        /// <param name="columnName">Name of the column from the table</param>
        private void bindControl(Control control, string columnName = "", string property = "Text")
        {
            control.DataBindings.Add(property, bindingSource, columnName);
        }

        /// <summary>
        /// ensure a control has a value in it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxRequired_Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            textbox.Text = textbox.Text.Trim();
            if (textbox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(textbox, "Please enter a value for this field");

                addErrorSetFocus(textbox);
            }
            
        }

        /// <summary>
        /// add a textbox to the controls with errors collection. if it is the first one, set focus.
        /// </summary>
        /// <param name="textbox"></param>
        private void addErrorSetFocus(TextBox textbox)
        {
            controlsWithErrors.Add(textbox);
            if (controlsWithErrors.IndexOf(textbox) == 0)
            {
                textbox.Focus();
            }
        }

        /// <summary>
        /// handle the closing event. if data is new or modified ask to save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEditVehicleStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            bindingSource.EndEdit();

            if (formAction == AutomotiveManager.FormAction.New ||
                ((DataRowView)bindingSource.Current).Row.RowState == DataRowState.Modified)
            {
                // if exitChoice is none, then the user hasn't decided what to do, so show the message box
                // otherwise use whatever value is in exitChoice
                exitChoice = (exitChoice == DialogResult.None) ?
                    MessageBox.Show(
                        "Save Changes?",
                        (formAction == AutomotiveManager.FormAction.New) ? "New Sales Staff Member" : "Edit Sales Staff Member",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button3)
                        : exitChoice;

                switch (exitChoice)
                {
                    case DialogResult.Yes:
                        // cancel if save failed
                        e.Cancel = !saveRecord();
                        break;
                    case DialogResult.No:
                        // delete row
                        ((DataRowView)bindingSource.Current).Delete();
                        // disard changes to data
                        ((DataTable)bindingSource.DataSource).RejectChanges();
                        break;
                    case DialogResult.Cancel:
                        // cancel the event
                        e.Cancel = true;
                        break;
                }   
            }  
            // clear exit choice
            exitChoice = DialogResult.None;
        }

        /// <summary>
        /// attempt to save a record to the database
        /// </summary>
        /// <returns>true if the save is a success.</returns>
        private bool saveRecord()
        {
            
            bool success = false;
            if (ValidateChildren())
            {
                // end edit
                bindingSource.EndEdit();

                // save change to DB
                vehicleStockData.Update();
                success = true;
            }
            return success;
        }

        /// <summary>
        /// handle validating event for textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Validated(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            errorProvider.SetError(textbox, "");
            controlsWithErrors.Remove(textbox);
        }

        /// <summary>
        /// handle save button clicked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            exitChoice = DialogResult.Yes;
            Close();
        }
    }
}
