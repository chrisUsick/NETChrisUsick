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
    public partial class frmService : Form
    {
        public frmService()
        {
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
            if (txtDescription.Text == string.Empty)
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
        /// remove whitespace from txtDescription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            // trim all white-space
            txtDescription.Text = txtDescription.Text.Trim();
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
        /// add a service to the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                // add item to data grid

                // clear inputs
                List<TextBox> tboxes = new List<TextBox>(new[] { txtCost, txtDescription });
                tboxes.ForEach(textbox => textbox.Text = string.Empty);

                cboType.SelectedIndex = -1;

                // reset focus
                txtDescription.Focus();
            }
        }
    }
}
