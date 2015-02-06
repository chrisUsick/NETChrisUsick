using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessTier;

namespace NETChrisUsick
{
    /// <summary>
    /// Sales quote form
    /// </summary>
    public partial class frmQuote : Form
    {
        // object to hold the sales quote
        private SalesQuote quote;

        // true if summary has been set; used by chkOrRadio_Click
        private bool summaryIsSet = false;

        /// <summary>
        /// constructs an instance of this form
        /// </summary>
        public frmQuote()
        {
            /// initialize the design
            InitializeComponent();
        }

        /// <summary>
        /// execute setting to me set when this form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQuote_Load(object sender, EventArgs e)
        {
            // set the icon
            this.Icon = NETChrisUsick.Properties.Resources.quoteicon;

            // remove lnkReset from tab order.
            lnkReset.TabStop = false;

            // add textbox specific event handlers
            txtSalePrice.Validating += txtSalePrice_Validating;
            txtTradeIn.Validating += txtTradeIn_Validating;

        }

        /// <summary>
        /// select the text of a textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_Enter(object sender, EventArgs e)
        {
            // select the text of this controller
            ((TextBox)sender).SelectAll();
        }

        /// <summary>
        /// test if a textbox contents is numeric
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textboxIsNumeric_Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            // check for numeric
            if (!AutomotiveManager.IsNumeric(textbox.Text))
            {
                errorProvider.SetError(textbox, "Must be numeric");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textbox, String.Empty);
            }
        }

        /// <summary>
        /// make sure input is greater than 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalePrice_Validating(object sender, CancelEventArgs e)
        {
            if (errorProvider.GetError(txtSalePrice) == String.Empty  && double.Parse(txtSalePrice.Text) <= 0)
            {
                errorProvider.SetError(txtSalePrice, "Input must be greater than zero");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// make sure tradeIn value is greater than or equal to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTradeIn_Validating(object sender, CancelEventArgs e)
        {
            if (errorProvider.GetError(txtTradeIn) == String.Empty && double.Parse(txtTradeIn.Text) < 0)
            {
                errorProvider.SetError(txtTradeIn, "Input must be equal to or greater than 0");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// clear the errorProvider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void control_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((TextBox)sender, String.Empty);
        }

        /// <summary>
        /// when a textbox changes clear the summary, disable finance section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_TextChanged(object sender, EventArgs e)
        {
            clearSummary();
            grpFinance.Enabled = false;
        }

        /// <summary>
        /// clear all the labels in the summary
        /// </summary>
        private void clearSummary()
        {
            // set summaryIsSet to false
            summaryIsSet = false;
            // clear lbls in summary group
            foreach (Label label in grpSummary.Controls)
            {
                if (label.Name.StartsWith("lbl"))
                {
                    label.Text = String.Empty;
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                // set summaryIsSet to true
                summaryIsSet = true;

                // create a sales quote object
                double salePrice = double.Parse(txtSalePrice.Text),
                       tradeIn    = double.Parse(txtTradeIn.Text),
                       taxRate   = 0;
                SalesQuote.Accessories accessories;
                SalesQuote.ExteriorFinish finish;
                bool[] accesoryCheckboxes = {chkLeather.Checked, chkNavigation.Checked, chkStereo.Checked};
                RadioButton[] finishRadios = {radStandard, radPearlized, radCustomDetail};

                // have to add 1 because ExteriorFinish has the option of None
                finish = (SalesQuote.ExteriorFinish)Array.IndexOf(
                    finishRadios,
                    // select the first radio that is checked
                    finishRadios.Where(rad => rad.Checked).First()) + 1;

                accessories = getAccessories();
                quote = new SalesQuote(salePrice, tradeIn, taxRate, accessories, finish);

                // set the summary labels
                lblSalePrice.Text = salePrice.ToString("c");;
                lblOptions.Text = (quote.AccessoryCost + quote.FinishCost).ToString("F2");
                lblSubtotal.Text = quote.SubTotal.ToString("c");
                lblSaleTax.Text = quote.SalesTax.ToString("F2");
                lblTotal.Text = quote.Total.ToString("c");
                lblTradeIn.Text = (tradeIn * -1).ToString("F2");
                lblAmountDue.Text = quote.AmountDue.ToString("c");

                // refocus to the sales textbox
                refocus(txtSalePrice);

                // enable finance section if amount due is greater than 0
                if (quote.AmountDue > 0)
                {
                    grpFinance.Enabled = true;
                    setFinanceSection();

                    // initially display the noYears and interest rate
                    hsbNoYears_ValueChanged(null, null);
                    hsbInterestRate_ValueChanged(null, null);
                }
            }
            else
            {
                // clear summary
                clearSummary();
                grpFinance.Enabled = false;
                // select the first item with an error;
                if (errorProvider.GetError(txtSalePrice) == String.Empty)
                {
                    refocus(txtTradeIn);
                }
                else
                {
                    refocus(txtSalePrice);
                }
            }
        }

        /// <summary>
        /// set the finance section
        /// </summary>
        private void setFinanceSection()
        {
            // number of monthly periods
            int periods = hsbNoYears.Value * 12;
            
            // set the scrollbar values to get them displayed.
            //hsbNoYears_ValueChanged(null, null);
            //hsbInterestRate_ValueChanged(null, null);

            // set the monthly pament
            lblMonthlyPayment.Text = AutomotiveManager.Payment(getInterestRate(), periods, quote.AmountDue).ToString("C");
        }

        /// <summary>
        /// get the interest rate as a decimal
        /// </summary>
        /// <returns>the decimal interest rate</returns>
        private double getInterestRate()
        {
            // divide by 100 * 100 to get to a decimal
            return (double)hsbInterestRate.Value / 10000.00;
        }

        /// <summary>
        /// get accessories for a vehicle
        /// </summary>
        /// <returns>the Accesories the vehicle has</returns>
        private SalesQuote.Accessories getAccessories()
        {
            int result = 0;
            CheckBox[] boxes = new[] {chkNavigation, chkLeather, chkStereo};
            // items in the array have the same index as their corresponding enumeration in 
            // SalesQuote.Accessories
            HashSet<CheckBox>[] combinations = {new HashSet<CheckBox>(new CheckBox[] {}),
                              new HashSet<CheckBox>( new[] { chkStereo }),
                              new HashSet<CheckBox>(new[] {chkLeather}),
                              new HashSet<CheckBox>(new[] {chkStereo, chkLeather}),
                              new HashSet<CheckBox>(new[] {chkNavigation}),
                              new HashSet<CheckBox>(new[] {chkStereo, chkNavigation}),
                              new HashSet<CheckBox>(new[] {chkLeather,chkNavigation}),
                              new HashSet<CheckBox>(boxes)};

            IEnumerable<CheckBox> areChecked = 
                from box in boxes
                where box.Checked
                select box;

            for (int i = 0; i < combinations.Length; i++)
            {
                HashSet<CheckBox> set = combinations[i];
                if (set.SetEquals(new HashSet<CheckBox>(areChecked)))
                {
                    result = i;
                }
            }
            return (SalesQuote.Accessories)result;
        }

        /// <summary>
        /// reset the focus of textbox
        /// </summary>
        /// <param name="textbox">textbox to refocus to</param>
        private void refocus(TextBox textbox)
        {
            // temorarily focus on something else
            lnkReset.Focus();
            // focus on textbox
            textbox.Focus();
        }

        private void hsbInterestRate_ValueChanged(object sender, EventArgs e)
        {
            lblInterestRate.Text = getInterestRate().ToString("p2");
            setFinanceSection();
        }

        private void hsbNoYears_ValueChanged(object sender, EventArgs e)
        {
            lblNoYears.Text = hsbNoYears.Value.ToString();
            setFinanceSection();
        }

        private void lnkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // prompt the user if they want to reset the form
            DialogResult close = AutomotiveManager.ShowMessage(
                "Would you want to reset this sales quote?", 
                "Sales Quote",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
            if (close == DialogResult.OK)
            {
                // clear summary
                clearSummary();
                
                // reset finance section
                lblNoYears.Text = String.Empty;
                lblInterestRate.Text = String.Empty;
                grpFinance.Enabled = true;

                // set the correct default values
                hsbNoYears.Value = 3;
                hsbInterestRate.Value = 500;

                // reset textboxes
                TextBox[] txtboxes = new[] { txtSalePrice, txtTradeIn };
                txtboxes.ToList().ForEach(textbox => textbox.Text = String.Empty);
                
                // reset checkboxes
                CheckBox[] chkboxes = new[] { chkLeather, chkNavigation, chkStereo };
                chkboxes.ToList().ForEach(box => box.Checked = false);
                
                // reset radio buttons
                radStandard.Checked = true;
            }
        }

        private void chkOrRadio_Click(object sender, EventArgs e)
        {
            if (summaryIsSet)
            {
                btnCalculate_Click(null, null);
            }
        }

        
    }
}
