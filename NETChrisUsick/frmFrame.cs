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
    /// <summary>
    /// The main MDI frame of the application
    /// </summary>
    public partial class frmFrame : Form
    {
        /// <summary>
        /// construct an isntance of this Form
        /// </summary>
        public frmFrame()
        {
            // initialize the design
            InitializeComponent();
        }

        /// <summary>
        /// Open a sales quote form when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            // create an instance of frmQuote 
            frmQuote quoteForm = new frmQuote();

            // set the MDIParent of quoteForm to this frame
            quoteForm.MdiParent = this;

            // display the quoteForm
            quoteForm.Show();
        }

        /// <summary>
        /// Tile the child forms of the MDI form vertically.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuWindowTile_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        /// <summary>
        /// Layer the child forms of the MDI form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuWindowLayer_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// Cascade the child forms of the MDI form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// Close the MDI form, thus ending the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// execute when this form loads. Does runtime configurations on this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFrame_Load(object sender, EventArgs e)
        {
            // set the form icon to the appicon found in the project Resources
            this.Icon = NETChrisUsick.Properties.Resources.appicon;

            // set the title of the form to the info in appConfig
            this.Text = ConfigurationManager.AppSettings.Get("applicationName");
        }
    }
}
