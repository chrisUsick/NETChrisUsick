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
    public partial class frmEditSalesStaff : Form
    {

        

        // binding source for this form
        private BindingSource bindingSource;

        // data tier reference
        private SalesStaffData salesStaffData;

        // action of the form
        private AutomotiveManager.FormAction formAction;

        // list of controls with errors
        private List<Control> controlsWithErrors = new List<Control>();

        // exit choice of user
        private DialogResult exitChoice = DialogResult.None;

        /// <summary>
        /// construct a edit sales staff form
        /// </summary>
        public frmEditSalesStaff()
        {
            InitializeComponent();
        }

        /// <summary>
        /// construct edit sales staff form to create a new staff or edit a current one
        /// </summary>
        /// <param name="formAction">specifies Whether to create or update a form</param>
        /// <param name="bindingSource">the binding source the form should use</param>
        public frmEditSalesStaff(AutomotiveManager.FormAction formAction, BindingSource bindingSource, SalesStaffData salesStaffData)
            : this()
        {
            this.formAction = formAction;
            this.bindingSource = bindingSource;
            this.salesStaffData = salesStaffData;

            
        }

        /// <summary>
        /// handle the shown event.
        /// do data binding here.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEditSalesStaff_Shown(object sender, EventArgs e)
        {
            try
            {
                // create a new row if formAction is 'new'
                if (formAction == AutomotiveManager.FormAction.New)
                {
                    // add a new row
                    DataRowView newStaff = (DataRowView)bindingSource.AddNew();

                    // must set the date of the row
                    newStaff["StartDate"] = DateTime.Now;

                    //set the title to "new"
                    Text = "New" + Text;
                }
                else if (formAction == AutomotiveManager.FormAction.Update)
                {
                    // set title text
                    Text = "Edit" + Text;
                }

                // perform databinding
                txtFirstName.DataBindings.Add("Text", bindingSource, "FirstName");
                txtLastName.DataBindings.Add("Text", bindingSource, "LastName");
                dtpStartDate.DataBindings.Add("Value", bindingSource, "StartDate");
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
            }
        }
        
        /// <summary>
        /// handle validation for textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            Control textbox = (Control)sender;
            textbox.Text = textbox.Text.Trim();
            if (textbox.Text.Length == 0)
            {
                //cancel validating
                e.Cancel = true;

                //set error message
                errorProvider.SetError(textbox, "Please enter a value for this field.");

                // add control to errorList
                controlsWithErrors.Add(textbox);

                // focus if textbox is the first control with an error
                if (controlsWithErrors.IndexOf(textbox) == 0)
                {
                    textbox.Focus();
                }
            }
        }

        /// <summary>
        /// handle validating event of textboxes
        /// when item is valid remove from error list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox_Validated(object sender, EventArgs e)
        {
            Control textbox = (Control)sender;
            // remove item if it is in the list.
            int index = controlsWithErrors.IndexOf(textbox);
            if (index > -1)
            {
                controlsWithErrors.RemoveAt(index);

                // clear error
                errorProvider.SetError(textbox, string.Empty);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // set exit choice and trigger the exit event
            exitChoice = DialogResult.Yes;
            Close();
                
            
        }

        /// <summary>
        /// save the current record to the database.
        /// </summary>
        private bool saveRecord()
        {
            bool success = false;
            if (ValidateChildren())
            {
                DataRowView row = null;
                try
                {
                    // get the current row
                    row = (DataRowView)bindingSource.Current;

                    // end editing
                    bindingSource.EndEdit();

                    // save change to DB
                    salesStaffData.Update();
                    success = true;
                }
                catch (Exception)
                {
                    // leaving success = true so that form will close if there 
                    // is a 'database' error
                    // display remove error message
                    AutomotiveManager.ShowMessage(
                        string.Format(" An error occurred saving {0} {1}",
                            row["FirstName"],
                            row["LastName"]),
                        "DataBase Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    throw;
                }
            }
            return success;
        }

        /// <summary>
        /// handle form closing 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEditSalesStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            // end the edit
            bindingSource.EndEdit();

            // check if record is new or modified
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

    }
}
