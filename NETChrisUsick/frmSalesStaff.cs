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

        // data tier object
        SalesStaffData salesStaffData;

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
                salesStaffData = new SalesStaffData(
                    Properties.Resources.connectionString, 
                    Properties.Resources.SalesStaffTableName,
                    Properties.Resources.SalesStaffSelect
                );

                bindingSource = new BindingSource();

                bindingSource.DataSource = salesStaffData.GetAllRows();
            }
            catch (Exception ex)
            {
                // log error fetching sales staff data
            }

            // bind the DGV to the bindingSource
            dgvSalesStaff.DataSource = bindingSource;
        }

        /// <summary>
        /// handle new sales staff form menu item clicck
        /// open a new edit sales staff form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileNewSalesStaff_Click(object sender, EventArgs e)
        {
            openEditForm(AutomotiveManager.FormAction.New);
        }

        /// <summary>
        /// open an edit sales staff form
        /// </summary>
        /// <param name="formAction"></param>
        private void openEditForm(AutomotiveManager.FormAction formAction)
        {
            // create edit sales staff form
            frmEditSalesStaff editForm = new frmEditSalesStaff(formAction, bindingSource, salesStaffData);

            // set parent
            editForm.MdiParent = this.MdiParent;

            // open form
            editForm.Show();
        }

        /// <summary>
        /// select a row if right clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesStaff_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // set the selected row to the current row of the dgv
                dgvSalesStaff.CurrentCell = dgvSalesStaff.Rows[e.RowIndex].Cells[1];
            }
        }

        /// <summary>
        /// open a new edit form, set to update the current row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuEdit_Click(object sender, EventArgs e)
        {
            openEditForm(AutomotiveManager.FormAction.Update);
        }

        /// <summary>
        /// remove the selected row from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuRemove_Click(object sender, EventArgs e)
        {
            bindingSource.Remove(bindingSource.Current);

            try
            {
                salesStaffData.Update();
            }
            catch (Exception)
            {
                throw;
            }
        }        

    }
}
