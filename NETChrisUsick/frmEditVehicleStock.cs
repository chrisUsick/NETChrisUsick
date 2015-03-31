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

        public frmEditVehicleStock(AutomotiveManager.FormAction formAction, 
            BindingSource bindingSource, 
            VehicleStockData vehicleStockData)
        {
            InitializeComponent();

            this.formAction = formAction;
            this.bindingSource = bindingSource;
            this.vehicleStockData = vehicleStockData;
        }
    }
}
