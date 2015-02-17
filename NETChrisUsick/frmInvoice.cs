using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace NETChrisUsick
{
    public partial class frmInvoice : Form
    {
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

            // set the properties from the app config
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
            printForm.Print(this, Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly);
        }
    }
}
