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
                // create a sales quote object
                double salePrice = double.Parse(txtSalePrice.Text),
                       tradIn    = double.Parse(txtTradeIn.Text),
                       taxRate   = 0;
                SalesQuote.Accessories accessories;
                SalesQuote.ExteriorFinish finish;
                bool[] accesoryCheckboxes = {chkLeather.Checked, chkNavigation.Checked, chkStereo.Checked};
                RadioButton[] finishRadios = {radCustomDetail, radPearlized, radStandard};

                
                //if (accesoryCheckboxes.SequenceEqual(new[] {true, true, true}))
                //{
                //    accessories = SalesQuote.Accessories.All;
                //}
                //else if (accesoryCheckboxes.SequenceEqual(new[] {true, false, true}))
                //{
                //    accessories = SalesQuote.Accessories.StereoAndLeather;
                //}
                //else if (accesoryCheckboxes.SequenceEqual(new[] {true, true, false}))
                //{
                //    accessories = SalesQuote.Accessories.LeatherAndNavigation;
                //}
                //else if (accesoryCheckboxes.SequenceEqual(new[] {false, true, true}))
                //{
                //    accessories = SalesQuote.Accessories.StereoAndNavigation;
                //}
                //else if (accesoryCheckboxes.SequenceEqual(new[] {true, false, true}))
                //{
                //    accessories = SalesQuote.Accessories
                //}
                accessories = getAccessories();
                //SalesQuote quote = new SalesQuote(
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
    }
}
