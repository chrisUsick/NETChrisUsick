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
    public partial class frmSalesStaff : Form
    {

        private BindingSource bindingSource;

        public frmSalesStaff()
        {
            InitializeComponent();
        }

        /// <summary>
        /// handle the shown event for this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesStaff_Shown(object sender, EventArgs e)
        {
            // get data from data tier
            try
            {
                SalesStaffData staffData = new SalesStaffData(
                    Properties.Resources.connectionString, 
                    Properties.Resources.SalesStaffTableName,
                    Properties.Resources.SalesStaffSelect
                );

                bindingSource = new BindingSource();

                bindingSource.DataSource = staffData.GetAllRows();
            }
            catch (Exception ex)
            {
                // log error fetching sales staff data
            }

            // bind the DGV to the bindingSource
            dgvSalesStaff.DataSource = bindingSource;
        }        

    }
}
