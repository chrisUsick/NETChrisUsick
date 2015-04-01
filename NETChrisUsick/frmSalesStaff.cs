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
                AutomotiveManager.ShowMessage(
                    "An error occurred fetching sales staff data.",
                    "DataBase Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
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
            // disable this form
            Enabled = false;

            // create edit sales staff form
            frmEditSalesStaff editForm = new frmEditSalesStaff(formAction, bindingSource, salesStaffData);

            // when the edit form is closed, re-enable the form.
            editForm.FormClosed += new FormClosedEventHandler(delegate(object sender, FormClosedEventArgs e)
            {
                // renable the form
                Enabled = true;
            });

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
            // get the row to delete
            DataRowView row = ((DataRowView)bindingSource.Current);
            // prompt user for confirmation
            DialogResult delete = MessageBox.Show(
                string.Format("Are you sure you want to remove {0} {1}",
                    row["FirstName"],
                    row["LastName"]),
                "Remove Sales Staff Member",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (delete == DialogResult.Yes)
            {
                try
                {
                    // delete the row
                    row.Delete();

                    // update database
                    salesStaffData.Update();
                }
                catch (Exception)
                { 
                    // display remove error message
                    AutomotiveManager.ShowMessage(
                        string.Format("An error occurred removing {0} {1}",
                            row["FirstName"],
                            row["LastName"]),
                        "DataBase Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }


            }
        }


        /// <summary>
        /// open edit form on double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesStaff_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            openEditForm(AutomotiveManager.FormAction.Update);
        }        

    }
}
