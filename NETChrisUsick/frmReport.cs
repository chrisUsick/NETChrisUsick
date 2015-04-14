using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataTier;
using System.Configuration;

namespace NETChrisUsick
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load the crystal report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmReport_Load(object sender, EventArgs e)
        {
            // construct report
            vehiclesSold report = new vehiclesSold();

            // create dataset
            DataSet vehicleStockDs = new VehicleStockData(
                Properties.Resources.connectionString,
                Properties.Resources.VehicleStockTableName,
                Properties.Resources.VehicleStockSelect
                ).GetDataSet();

            // set datasrouce of report
            report.SetDataSource(vehicleStockDs);

            //set the viewer's source
            crvVehiclesSold.ReportSource = report;

            // maximize in MDI parent
            //WindowState = 
        }
    }
}
