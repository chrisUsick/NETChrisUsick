using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataTier;
using BusinessTier;

namespace NETChrisUsick
{
    /// <summary>
    /// form for making a vehicle sale
    /// </summary>
    public partial class frmVehicleSale : DatabaseForm
    {
        // binding source for the vehicle
        private BindingSource vehicleBinding;

        // price of options for a vehicle
        private double optionsPrice;

        private VehicleStockData vehicleStockData;

        /// <summary>
        /// construct a vehicle sale form
        /// </summary>
        public frmVehicleSale(BindingSource vehicleBinding, double optionsPrice, VehicleStockData vehicleStockData)
            : base (typeof(SalesStaffData), new DataObjectInfo(
                Properties.Resources.connectionString,
                Properties.Resources.SalesStaffTableName,
                Properties.Resources.SalesStaffSelect))
        {
            InitializeComponent();
            this.vehicleBinding = vehicleBinding;
            this.optionsPrice = optionsPrice;
            this.vehicleStockData = vehicleStockData;
        }

        /// <summary>
        /// bind sales staff controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVehicleSale_Shown(object sender, EventArgs e)
        {

            try
            {
                // programatically bind some controls
                autoBindControls(new[] {
                    lblStockNumber,
                    lblMake,
                    lblModel,
                    lblBasePrice
                }, vehicleBinding);

                // sale staff binding
                autoBindControls(new[] { lblFirstName, lblLastName }, bindingSource);

                // bind/set other controls
                lblYear.DataBindings.Add("text", vehicleBinding, "ManufacturedYear");
                lblOptions.Text = optionsPrice.ToString("C");

                // add changed event handler
                bindingSource.CurrentChanged += new EventHandler(bindingSource_CurrentChanged);

                // show commission
                bindingSource_CurrentChanged(null, null);
            }
            catch (Exception ex)
            {
                AutomotiveManager.LogError(ex, "Databinding error");
            }

        }

        /// <summary>
        /// handle changing of sale staff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            // current staff member
            DataRowView staff = (DataRowView)bindingSource.Current;
            double purchasePrice = (double)((DataRowView)vehicleBinding.Current)["BasePrice"];
            // update commission
            lblCommission.Text = Commission.getCommission((DateTime)staff["StartDate"], purchasePrice).ToString("C");

        }

        /// <summary>
        /// programmatically bind controls based on their Name property
        /// </summary>
        /// <param name="controlsToBind">collection of controls</param>
        /// <param name="bindingSource">binding source to use</param>
        private void autoBindControls(IEnumerable<Control> controlsToBind, BindingSource bindingSource)
        {
            List<Control> controls = new List<Control>(controlsToBind);

            controls.ForEach(control =>
            {
                control.DataBindings.Add("text", bindingSource, control.Name.Substring(3));
            });
        }
        
        /// <summary>
        /// select the next sales staff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
        }

        /// <summary>
        /// select the previous sales staff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
        }

        /// <summary>
        /// select the first sales staff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            bindingSource.MoveFirst();
        }

        /// <summary>
        /// select the last sales staff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            bindingSource.MoveLast();
        }

        /// <summary>
        /// update the vehicle record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                // set options price
                DataRowView vehicle = (DataRowView)vehicleBinding.Current;
                vehicle["OptionsPrice"] = optionsPrice;
                vehicle["SoldBy"] = ((DataRowView)bindingSource.Current)["ID"];

                vehicleBinding.EndEdit();
                vehicleStockData.Update();
                Close();
            }
            catch (Exception ex)
            {
                AutomotiveManager.LogErrorWithMessage(
                    ex,
                    "An error occurred while attempting to sell the vehicle.",
                    "Database Error");

            }
        }     
    }    
}
