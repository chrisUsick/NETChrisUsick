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
        // private fields for holding the sales staff and vehicle stock form
        private frmSalesStaff salesStaffForm;
        private frmVehicleStock vehicleStockForm;

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

        /// <summary>
        /// open a new service form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileOpenService_Click(object sender, EventArgs e)
        {
            // create a new service form
            frmService serviceForm = new frmService();

            // set the parent
            serviceForm.MdiParent = this;

            // show form
            serviceForm.Show();
        }

        /// <summary>
        /// open a car wash form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            // create a new car wash form
            frmCarWash carWashForm = new frmCarWash();

            // set the mdi parent
            carWashForm.MdiParent = this;

            //show the form
            carWashForm.Show();
        }

        /// <summary>
        /// open the sales staff form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuDataSalesStaff_Click(object sender, EventArgs e)
        {
            // open or activate a sales form
            openOrActivateForm(typeof(frmSalesStaff));

        }

        /// <summary>
        /// set a form mdi parent and open it
        /// </summary>
        /// <param name="form"></param>
        private void openFormToMdi(Form form)
        {
            //set mdi parent
            form.MdiParent = this;

            // show form
            form.Show();
        }

        /// <summary>
        /// handle click event for vehicle stock menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuDataVehicleStock_Click(object sender, EventArgs e)
        {
            // open or activate a vehicle stock form
            openOrActivateForm(typeof(frmVehicleStock));
        }

        /// <summary>
        /// only create a form when it isn't open in the mdi frame
        /// </summary>
        /// <param name="formType">Type of the form to create</param>
        private void openOrActivateForm(Type formType)
        {
            // check for form in Mdi Parent
            Form activeForm = MdiChildren.FirstOrDefault(form => form.GetType() == formType);
            
            // test if the form was found
            if (activeForm != null)
            {
                // activate the form that was found
                activeForm.Activate();
            }
            else
            {
                // use refection to create an instance of the form.
                openFormToMdi((Form)Activator.CreateInstance(formType, false));
            }
        }
    }
}
