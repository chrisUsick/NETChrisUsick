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
                    Properties.Resources.VehicleStockTableName,
                    Properties.Resources.VehicleStockSelect
                );

                bindingSource = new BindingSource();

                bindingSource.DataSource = vehicleStockData.GetAllRows();
            }
            catch (Exception ex)
            {
                // log error fetching vehicle stock data
                AutomotiveManager.ShowMessage(
                    "An error occurred fetching vehicle stock data.",
                    "DataBase Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
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
            openEditForm(AutomotiveManager.FormAction.New);
        }

        /// <summary>
        /// open a vehicle edit form
        /// </summary>
        /// <param name="formAction">The form action to open it with</param>
        private void openEditForm(AutomotiveManager.FormAction formAction)
        {
            // disable this form
            Enabled = false;

            frmEditVehicleStock editForm = new frmEditVehicleStock(formAction,
                bindingSource,
                vehicleStockData);

            // when the edit form is closed, re-enable the form.
            editForm.FormClosed += new FormClosedEventHandler(delegate(object closeSender, FormClosedEventArgs closeEvent)
                {
                    // renable the form
                    this.Enabled = true;
                });
            // set parent
            editForm.MdiParent = MdiParent;

            // show form
            editForm.Show();
        }

        /// <summary>
        /// open an edit form for editing a row in the dgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuEdit_Click(object sender, EventArgs e)
        {
            openEditForm(AutomotiveManager.FormAction.Update);
        }

        /// <summary>
        /// select a row if right clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvVehicles_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // set the selected row to the current row of the dgv
                dgvVehicles.CurrentCell = dgvVehicles.Rows[e.RowIndex].Cells[1];
            }
        }

        /// <summary>
        /// remove a vehicle from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuRemove_Click(object sender, EventArgs e)
        {
            // get the row to delete
            DataRowView row = ((DataRowView)bindingSource.Current);
            // prompt user for confirmation
            DialogResult delete = MessageBox.Show(
                string.Format("Are you sure you want to remove {0} {1} {2}", 
                    row["ManufacturedYear"],
                    row["Make"],
                    row["Model"]),
                "Remove Vehicle",
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
                    vehicleStockData.Update();
                }
                catch (Exception)
                {
                    // display remove error message
                    AutomotiveManager.ShowMessage(
                        String.Format("An error occurred removing {0} {1}, {2}",
                            row["ManufacturedYear"],
                            row["Make"],
                            row["Model"]),
                        "DataBase Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        /// <summary>
        /// open an edit form when a cell is double clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvVehicles_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            openEditForm(AutomotiveManager.FormAction.Update);
        }  
    }
}
