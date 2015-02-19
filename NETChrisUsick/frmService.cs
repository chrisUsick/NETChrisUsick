using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessTier;
using System.Configuration;
using System.Globalization;

namespace NETChrisUsick
{
    /// <summary>
    /// a form for creating a service invoice
    /// </summary>
    public partial class frmService : Form
    {
        /// <summary>
        /// variable to hold an invoice
        /// </summary>
        ServiceInvoice invoice;

        /// <summary>
        /// constructs a service form
        /// </summary>
        public frmService()
        {
            // initialize the UI
            InitializeComponent();
        }

        /// <summary>
        /// do load-time configurations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmService_Load(object sender, EventArgs e)
        {
            // set text focus to the description
            txtDescription.Focus();

            // set icon
            this.Icon = NETChrisUsick.Properties.Resources.serviceicon;
        }

        /// <summary>
        /// select all text when focus is gained
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_Enter(object sender, EventArgs e)
        {
            // select all text
            ((TextBox)sender).SelectAll();
        }

        /// <summary>
        /// ensures that a value was entered in the field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescription.Text.Trim() == string.Empty)
            {
                errorProvider.SetError(txtDescription, "Please enter a description");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// remove the error message from sender when validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void control_Validated(object sender, EventArgs e)
        {
            // clear the error;
            errorProvider.SetError((Control)sender, string.Empty);
        }

        /// <summary>
        /// ensure 1 item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboType_Validating(object sender, CancelEventArgs e)
        {
            if (cboType.SelectedIndex == -1)
            {
                errorProvider.SetError(cboType, "Please select a service type.");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// validates txtCost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            // cost to be parsed
            double cost;

            // test if input isn't numeric
            if (!double.TryParse(txtCost.Text, out cost))
            {
                errorProvider.SetError(txtCost, "Please enter a numeric value.");
                e.Cancel = true;
            }
            else if (cost <= 0) 
            {
                errorProvider.SetError(txtCost, "Please enter a value greater than zero.");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// add a service to the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                // create an invoice
                invoice = new ServiceInvoice(
                    double.Parse(ConfigurationManager.AppSettings.Get("PST")),
                    double.Parse(ConfigurationManager.AppSettings.Get("GST")));

                // add item to data grid
                int rowNum = dgvServices.Rows.Count + 1;
                dgvServices.Rows.Add(new[] { 
                    rowNum.ToString(), 
                    txtDescription.Text.Trim(), 
                    cboType.SelectedItem.ToString(), 
                    double.Parse(txtCost.Text).ToString("c") 
                });

                

                // clear inputs
                List<TextBox> tboxes = new List<TextBox>(new[] { txtCost, txtDescription });
                tboxes.ForEach(textbox => textbox.Text = string.Empty);

                // deselect the options in the combobox
                cboType.SelectedIndex = -1;

                // reset focus
                txtDescription.Focus();
            }
        }

        /// <summary>
        /// update summary labels 
        /// </summary>
        /// <exception cref="NullReferenceException">Throws if the columns of a given row weren't set</exception>
        private void updateSummaryLabels()
        {
            // iterate over all rows in the datagridview
            foreach (DataGridViewRow row in dgvServices.Rows)
            {
                // get values from row
                string costTypeStr = row.Cells[2].Value.ToString();
                double cost = double.Parse(row.Cells[3].Value.ToString(), NumberStyles.Currency);

                // use new array to ensure proper casting. Can't rely on cbo.Types.Items
                string[] typeItems = new[] {"Labour", "Parts", "Material"};

                // index of the type from the row in the typeItems[]
                int costTypePosition = Array.IndexOf(typeItems, costTypeStr);

                // add the cost to the invoice
                invoice.AddCost((ServiceInvoice.CostType)costTypePosition, cost);
            }

            // update labels
            lblSubtotal.Text = invoice.SubTotal.ToString("c");
            lblPST.Text = invoice.PSTCharged.ToString("f2");
            lblGST.Text = invoice.PSTCharged.ToString("f2");
            lblTotal.Text = invoice.Total.ToString("c");
        }

        /// <summary>
        /// enable the generate invoice menu item if it doesn't exist already
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServices_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // enable generate invoice
            mnuServiceGenerateInvoice.Enabled = true;

            // endable context menu
            mnuContextClear.Enabled = true;

            // update summary labels
            updateSummaryLabels();
        }

        /// <summary>
        /// disable the generate invoice menu item if there are no more rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServices_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // if the count is greater than 0, enable the menu item
            mnuServiceGenerateInvoice.Enabled = mnuContextClear.Enabled = (dgvServices.Rows.Count > 0);

            // clear summary labels
            clearSummaryLabels();
        }

        private void clearSummaryLabels()
        {
            List<Label> labels = new List<Label>(new[] { lblSubtotal, lblTotal, lblPST, lblGST });
            labels.ForEach(label => label.Text = string.Empty); 
        }

        /// <summary>
        /// prevent cell selection from displaying on dgvServices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServices_SelectionChanged(object sender, EventArgs e)
        {
            // clear selection
            dgvServices.ClearSelection(); 
        }

        /// <summary>
        /// clear rows from  the data grid view. Also refocus cursor and clear sumary labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuContextClear_Click(object sender, EventArgs e)
        {
            // remove rows
            dgvServices.Rows.Clear();
        }

        /// <summary>
        /// create a new invoice form display it in the MDI fram
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuServiceGenerateInvoice_Click(object sender, EventArgs e)
        {
            // create form
            frmInvoice invoiceForm = new frmServiceInvoice(invoice);

            // set parent
            invoiceForm.MdiParent = MdiParent;
            
            // show the new form
            invoiceForm.Show();
        }
    }
}
