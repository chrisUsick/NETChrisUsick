using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessTier;

namespace NETChrisUsick
{
    /// <summary>
    /// a service invoice form. Used for having a printable summary of an invoice
    /// </summary>
    public partial class frmServiceInvoice : NETChrisUsick.frmInvoice
    {

        /// <summary>
        /// stores the invoice to populate the form
        /// </summary>
        private ServiceInvoice invoice;

        /// <summary>
        /// create a service form object
        /// </summary>
        /// <param name="invoice">an invoice to use to populate the invoice form</param>
        public frmServiceInvoice(ServiceInvoice invoice)
        {
            InitializeComponent();

            this.invoice = invoice;
        }

        /// <summary>
        /// perform load time configurations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmServiceInvoice_Load(object sender, EventArgs e)
        {
            this.lblInvoiceTitle.Text = "Service Invoice";

            // fill in labels
            Label[] labels = new[] {lblLabourCost, lblPartsCost, lblMaterialCost, lblSubtotal, lblPST,
                lblGST, lblTotal};
            double[] values = new[] {invoice.LabourCost, invoice.PartsCost, invoice.MaterialCost, invoice.SubTotal,
                invoice.PSTCharged, invoice.GSTCharged, invoice.Total};
            
            // set title
            Text = "Service Invoice";
            // loop through the parallel arrays and assign values
            for (int i = 0; i < labels.Length; i++)
            {
                int[] currencyItems = new [] {0,3,6};
                string formatter = (Array.IndexOf(currencyItems, i) == -1) ? "f2" : "c";
                labels[i].Text = values[i].ToString(formatter);
            }
        }
    }
}
