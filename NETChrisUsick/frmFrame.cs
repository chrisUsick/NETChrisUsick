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
    public partial class frmFrame : Form
    {
        public frmFrame()
        {
            InitializeComponent();
        }

        private void mnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            // create an instance of frmQuote 
            frmQuote quoteForm = new frmQuote();

            // set the MDIParent of quoteForm to this frame
            quoteForm.MdiParent = this;

            // display the quoteForm
            quoteForm.Show();
        }

        private void mnuWindowTile_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuWindowLayer_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFrame_Load(object sender, EventArgs e)
        {
            this.Icon = NETChrisUsick.Properties.Resources.appicon;
        }
    }
}
