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

        }

    }
}
