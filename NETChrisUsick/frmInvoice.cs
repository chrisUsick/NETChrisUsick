using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;
namespace NETChrisUsick
{
    /// <summary>
    /// base visual class for invoice forms
    /// </summary>
    public partial class frmInvoice : Form
    {
        /// <summary>
        /// construct an invoice form
        /// </summary>
        public frmInvoice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// perform load time configurations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInvoice_Load(object sender, EventArgs e)
        {
            // set icon
            Icon = NETChrisUsick.Properties.Resources.invoiceicon;

            // date format object
            DateTimeFormatInfo dtfi = CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat;

            dtfi.DateSeparator = "/";
            // set the properties from the app config
            lblDate.Text = DateTime.Now.ToString("d", dtfi);
            lblName.Text = ConfigurationManager.AppSettings.Get("CompanyName");
            lblAddress.Text = ConfigurationManager.AppSettings.Get("CompanyAddress");
            lblCity.Text = ConfigurationManager.AppSettings.Get("companyCity") + " " + 
                ConfigurationManager.AppSettings.Get("companyProvince");
            lblPhone.Text = ConfigurationManager.AppSettings.Get("companyPhone");
        }

        /// <summary>
        /// print this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFilePrint_Click(object sender, EventArgs e)
        {
            // open the print dialog
            printForm.Print(this, Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly);
        }
    }
}
