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
    public partial class frmVehicleStock : Form
    {

        VehicleStockData vehicleStockData;

        // binding source for this form.
        BindingSource bindingSource;

        /// <summary>
        /// constructs a new vehicle stock form
        /// </summary>
        public frmVehicleStock()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load data for the dgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVehicleStock_Shown(object sender, EventArgs e)
        {
            // get data from data tier
            try
            {
                vehicleStockData = new VehicleStockData(
                    Properties.Resources.connectionString,
                    Properties.Resources.SalesStaffTableName,
                    Properties.Resources.SalesStaffSelect
                );

                bindingSource = new BindingSource();

                bindingSource.DataSource = vehicleStockData.GetAllRows();
            }
            catch (Exception ex)
            {
                // log error fetching vehicle stock data
            }

            // bind the DGV to the bindingSource
            dgvVehicles.DataSource = bindingSource;
        }

        /// <summary>
        /// open new vehicle form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileNewVehicle_Click(object sender, EventArgs e)
        {
            frmEditVehicleStock editForm = new frmEditVehicleStock(AutomotiveManager.FormAction.New,
                bindingSource,
                vehicleStockData);

            // set parent
            editForm.MdiParent = MdiParent;

            editForm.Show();
        }             
    }
}
