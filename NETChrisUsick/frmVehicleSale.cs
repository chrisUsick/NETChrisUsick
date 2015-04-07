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
    public partial class frmVehicleSale : DatabaseForm
    {
        /// <summary>
        /// construct a vehicle sale form
        /// </summary>
        public frmVehicleSale(BindingSource vehicleBinding, double optionsPrice)
            : base (typeof(SalesStaffData), new DataObjectInfo(
                Properties.Resources.connectionString,
                Properties.Resources.SalesStaffTableName,
                Properties.Resources.SalesStaffSelect))
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// bind sales staff controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVehicleSale_Shown(object sender, EventArgs e)
        {
            lblFirstName.DataBindings.Add("text", bindingSource.Current, "FirstName");
        }     
    }    
}
