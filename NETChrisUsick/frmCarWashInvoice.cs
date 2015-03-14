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
    public partial class frmCarWashInvoice : NETChrisUsick.frmInvoice
    {
        // variable to hold the invoice data
        CarWashInvoice invoice;

        /// <summary>
        /// create a new car wash invoice form
        /// </summary>
        /// <param name="invoice">Invoice used to extract the information</param>
        public frmCarWashInvoice(CarWashInvoice invoice)
        {
            InitializeComponent();

            this.invoice = invoice;
            
            // set labels
            lblInvoiceTitle.Text = Text = "Car Wash Invoice";
            lblPackagePrice.Text = invoice.PackageCost.ToString("C");
            lblFragrancePrice.Text = invoice.FragranceCost.ToString("F2");
            lblSubtotal.Text = invoice.SubTotal.ToString("C");
            lblTaxes.Text = (invoice.PSTCharged + invoice.GSTCharged).ToString("F2");
            lblTotal.Text = invoice.Total.ToString("C");
        }
    }
}
