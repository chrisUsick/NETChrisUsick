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
        private void frmEditVehicleStock_Load(object sender, EventArgs e)
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
            }

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
                    radManual,
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
                throw;
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
    }
}
