using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BusinessTier;
using System.Configuration;

namespace NETChrisUsick
{
    /// <summary>
    /// a form for generating a car wash invoice
    /// </summary>
    public partial class frmCarWash : Form
    {
        /// <summary>
        /// stucture to represent an option in a comboBox.
        /// </summary>
        public struct Option
        {
            public string Description { get; set; }
            public double Price { get; set; }
            public override string ToString()
            {
                return Description;
            }
        }

        /// <summary>
        /// class variable to hold the invoice used in this form
        /// </summary>
        private CarWashInvoice invoice = new CarWashInvoice(
            double.Parse(ConfigurationManager.AppSettings.Get("PST")),
            double.Parse(ConfigurationManager.AppSettings.Get("GST"))
        );

        /// <summary>
        /// List of interior options
        /// </summary>
        private List<string> InteriorOptions = new List<string>();

        /// <summary>
        /// list of exterior options
        /// </summary>
        private List<string> ExteriorOptions = new List<string>();

        /// <summary>
        /// constructs a car wash form
        /// </summary>
        public frmCarWash()
        {
            InitializeComponent();

            // populate the Interior and exterior options
            setOptions(Properties.Resources.Interior, InteriorOptions);
            setOptions(Properties.Resources.Exterior, ExteriorOptions);
        }

        /// <summary>
        /// read the data from a text file string and parse it into a list
        /// </summary>
        /// <param name="rawData">string data from the text file</param>
        /// <param name="list">list to output data too</param>
        private void setOptions(string rawData, List<string> list)
        {
            // reader to read raw data
            StringReader reader = new StringReader(rawData);
                
            // an individual option
            string option;
            while ((option = reader.ReadLine()) != null)
            {
                // add the option to the list
                list.Add(option);
            }

            reader.Close();
        }

        /// <summary>
        /// handle the load event for this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCarWash_Load(object sender, EventArgs e)
        {
            // select the package dropdown
            cboPackage.Focus();

            // set the icon
            Icon = NETChrisUsick.Properties.Resources.carwashicon;

            // populate dropdowns
            // raw data strings
            string packageData = Properties.Resources.PackageData;
            string FragranceData = Properties.Resources.FragranceData;

            // populate both dropboxes
            populateComboBoxes(packageData, cboPackage, 0);
            populateComboBoxes(FragranceData, cboFragrance, 2);

            // trigger the control change event to update invoice and form
            control_Changed(sender, e);

            // TODO add combobox event handlers here. This will make populateComboBoxes not cause
            // the ComboBox.SelectedIndexChanged event to be fired
            
        }

        /// <summary>
        /// update the car wash invoice and the form when a control is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void control_Changed(object sender, EventArgs e)
        {
            // only execute if both combo boxes have been set.
            if (cboFragrance.SelectedIndex != -1 && cboPackage.SelectedIndex != -1)
            {
                // update invoice
                invoice.PackageCost = ((Option)cboPackage.SelectedItem).Price;
                invoice.FragranceCost = ((Option)cboFragrance.SelectedItem).Price;

                // update listControls
                updateListBox(lstInterior, InteriorOptions);
                updateListBox(lstExterior, ExteriorOptions);

                // set the fragrance value
                lstInterior.Items[0] += string.Format(" - {0}", cboFragrance.SelectedItem.ToString());

                // update labels
                lblSubtotal.Text = invoice.SubTotal.ToString("C");
                lblPst.Text = invoice.PSTCharged.ToString("F2");
                lblGst.Text = invoice.GSTCharged.ToString("F2");
                lblTotal.Text = invoice.Total.ToString("C2"); 
            }
        }

        /// <summary>
        /// Updates a list boxes according the package and fragrance options selecteed
        /// </summary>
        /// <param name="listBox">Listbox to update</param>
        /// <param name="options">list of options to chose from</param>
        private void updateListBox(ListBox listBox, List<string> options)
        {
            // clear the listbox
            listBox.Items.Clear();
            
            // the index of the package chosen is related to the amount of features included.
            int packageIndex = cboPackage.SelectedIndex;

            // options to add to the listbox
            IEnumerable<string> optionsToAdd = options.GetRange(0, packageIndex + 1);
                // overly complicated way of doing the above!
                //.Select((option, index) => new { option, index })
                //.Where((item) => item.index <= packageIndex)
                //.Select((item) => item.option);

            // add to list box
            listBox.Items.AddRange(optionsToAdd.ToArray());
        }

        /// <summary>
        /// populates a comboBox with values from a CSV string
        /// </summary>
        /// <param name="cvsString">CSV string to create the items from</param>
        /// <param name="comboBox">Combo box to add the items to.</param>
        /// <param name="selectedIndex">index of item to set as selected</param>
        private void populateComboBoxes(string cvsString, ComboBox comboBox, int selectedIndex)
        {
            // string reader for the raw data
            StringReader reader = new StringReader(cvsString);

            // variable to hold a single record
            string record;

            // read each line of the cvs data
            while ((record = reader.ReadLine()) != null)
            {
                // variable to hold fields of a record
                string[] values = record.Split(',');

                // create an option object.
                Option option = new Option()
                {
                    Description = values[0],
                    Price = double.Parse(values[1])
                };

                // add the option directly to the combobox
                comboBox.Items.Add(option);
            }

            // close the reader
            reader.Close();

            // select the item in the comboBox
            comboBox.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// open the car wash invoice form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuGenerateInvoice_Click(object sender, EventArgs e)
        {
            // create a new invoice form
            frmCarWashInvoice invoiceForm = new frmCarWashInvoice(invoice);

            // set it's parent to the mdi frame
            invoiceForm.MdiParent = MdiParent;

            // show the form
            invoiceForm.Show();
        }
    }
}
