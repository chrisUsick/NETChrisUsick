using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NETChrisUsick
{
    /// <summary>
    /// Sales quote form
    /// </summary>
    public partial class frmQuote : Form
    {
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
            // clear lbls in summary group
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

            }
            else
            {
                // select the first item with an error;
                if (errorProvider.GetError(txtSalePrice) == String.Empty)
                {
                    txtTradeIn.SelectAll();
                }
                else
                {
                    txtSalePrice.SelectAll();
                }
            }
        }
    }
}
