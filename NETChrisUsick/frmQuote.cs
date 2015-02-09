﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessTier;
using System.Configuration;

namespace NETChrisUsick
{
    /// <summary>
    /// Sales quote form
    /// </summary>
    public partial class frmQuote : Form
    {
        /// <summary>
        /// object to hold the sales quote
        /// </summary>
        private SalesQuote quote;

        /// <summary>
        /// true if summary has been set; used by chkOrRadio_Click
        /// </summary>
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
                // show the error message
                errorProvider.SetError(textbox, "Must be numeric");

                // cancel validating event 
                e.Cancel = true;
            }
            else
            {
                // input is numeric; remove the error message
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
            // if the error on this element is empty, then the number is numeric
            // also check that salePrice is greater than 0
            if (errorProvider.GetError(txtSalePrice) == String.Empty  && double.Parse(txtSalePrice.Text) <= 0)
            {
                // show the error message
                errorProvider.SetError(txtSalePrice, "Input must be greater than zero");

                // cancel validating event
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
            // if the error is emtpy, then the input is numeric
            // also, check if the input is greater than 0
            if (errorProvider.GetError(txtTradeIn) == String.Empty && double.Parse(txtTradeIn.Text) < 0)
            {
                // show error message
                errorProvider.SetError(txtTradeIn, "Input must be equal to or greater than 0");
                
                // cancel validating event
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
            // clear validating error.
            errorProvider.SetError((TextBox)sender, String.Empty);
        }

        /// <summary>
        /// when a textbox changes clear the summary, disable finance section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_TextChanged(object sender, EventArgs e)
        {
            // clear summary labels
            clearSummary();

            // disable finance section
            clearFinanceSection();
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
                // the labels that need to be cleared have names
                // starting with `lbl`
                if (label.Name.StartsWith("lbl"))
                {
                    // clear the text in the label
                    label.Text = String.Empty;
                }
            }
        }

        /// <summary>
        /// event handler to trigger the validation, create a new quote, 
        /// and enable the finance section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // try to validate the textboxes
            if (this.ValidateChildren())
            {
                // set summaryIsSet to true
                summaryIsSet = true;

                # region create sales quote object 

                // sales quote parameters
                double salePrice = double.Parse(txtSalePrice.Text),
                       tradeIn    = double.Parse(txtTradeIn.Text),
                       taxRate   = Double.Parse(ConfigurationManager.AppSettings.Get("salesTaxRate"));
                SalesQuote.Accessories accessories;
                SalesQuote.ExteriorFinish finish;

                // array of radio buttons
                RadioButton[] finishRadios = {radStandard, radPearlized, radCustomDetail};

                // get the finish from the radio buttons
                // have to add 1 because ExteriorFinish has the option of None
                finish = (SalesQuote.ExteriorFinish)Array.IndexOf(
                    finishRadios,
                    // select the first radio that is checked
                    finishRadios.Where(rad => rad.Checked).First()) + 1;

                // get the selected accessories
                accessories = getAccessories();

                // create the sales quote object
                quote = new SalesQuote(salePrice, tradeIn, taxRate, accessories, finish);

                #endregion

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

                // clear and disable finance section
                clearFinanceSection();

                // select the first item with an error;
                if (errorProvider.GetError(txtSalePrice) == String.Empty)
                {
                    // set focus to txtTradeIn
                    refocus(txtTradeIn);
                }
                else
                {
                    // set focus to txtSalePrice
                    refocus(txtSalePrice);
                }
            }
        }

        /// <summary>
        /// disable finance groupbox, clear payment section
        /// </summary>
        private void clearFinanceSection()
        {
            // disable finance groupbox
            grpFinance.Enabled = false;

            // clear the payment lable
            lblMonthlyPayment.Text = String.Empty;
        }

        /// <summary>
        /// set the finance section
        /// </summary>
        private void setFinanceSection()
        {
            // number of monthly periods
            int periods = hsbNoYears.Value * 12;

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
            // result as an int
            int result = -1;

            // the check boxes to be tested
            CheckBox[] boxes = new[] {chkNavigation, chkLeather, chkStereo};

            // items in the array have the same index as their corresponding enumeration in 
            // SalesQuote.Accessories e.g. combinations[2] is a HashSet of chkLeather.
            // casting 2 to the Accessories enumeration is the Leather option
            HashSet<CheckBox>[] combinations = {new HashSet<CheckBox>(new CheckBox[] {}),
                              new HashSet<CheckBox>( new[] { chkStereo }),
                              new HashSet<CheckBox>(new[] {chkLeather}),
                              new HashSet<CheckBox>(new[] {chkStereo, chkLeather}),
                              new HashSet<CheckBox>(new[] {chkNavigation}),
                              new HashSet<CheckBox>(new[] {chkStereo, chkNavigation}),
                              new HashSet<CheckBox>(new[] {chkLeather,chkNavigation}),
                              new HashSet<CheckBox>(boxes)};

            // a collection of the accessories that are set;
            IEnumerable<CheckBox> areChecked = 
                from box in boxes
                where box.Checked
                select box;

            // the Hashset of selected accessories
            HashSet<CheckBox> areCheckedHash = new HashSet<CheckBox>(areChecked);

            // loop through the possible combinations
            for (int i = 0; i < combinations.Length && result == -1; i++)
            {
                // the current set to be compared the areCheckedHash
                HashSet<CheckBox> set = combinations[i];

                // if the current set and arecheckedHash are equals set result to the index
                if (set.SetEquals(areCheckedHash))
                {
                    result = i;
                }
            }

            // return the result casted to an Accessory
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

        /// <summary>
        /// handle the hsbInterestRate changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hsbInterestRate_ValueChanged(object sender, EventArgs e)
        {
            // set the text of get lblInterestRate to a percent with 2 degrees of percision
            lblInterestRate.Text = getInterestRate().ToString("p2");

            // updates the payment field in the finance section
            setFinanceSection();
        }

        /// <summary>
        /// handle the hsbNoYears changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hsbNoYears_ValueChanged(object sender, EventArgs e)
        {
            // set the text of lblNoYears
            lblNoYears.Text = hsbNoYears.Value.ToString();

            // update then payment field in the finance section
            setFinanceSection();
        }

        /// <summary>
        /// handle reseting the the sales quote form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // prompt the user if they want to reset the form
            DialogResult result = AutomotiveManager.ShowMessage(
                "Would you want to reset this sales quote?", 
                "Sales Quote",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            // if result is ok then reset the form
            if (result == DialogResult.OK)
            {
                // clear summary
                clearSummary();
                
                // reset finance section
                lblNoYears.Text = String.Empty;
                lblInterestRate.Text = String.Empty;
                clearFinanceSection();

                // set the correct default values
                // for finance section
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

        /// <summary>
        /// click event for handling click on checkboxes or radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkOrRadio_Click(object sender, EventArgs e)
        {
            // if the summary has been set
            if (summaryIsSet)
            {
                // recalculate the quote
                btnCalculate_Click(null, null);
            }
        }

        
    }
}
