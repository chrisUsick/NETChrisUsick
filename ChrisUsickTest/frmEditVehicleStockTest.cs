using NETChrisUsick;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using DataTier;

namespace ChrisUsickTest
{
    
    
    /// <summary>
    ///This is a test class for frmEditVehicleStockTest and is intended
    ///to contain all frmEditVehicleStockTest Unit Tests
    ///</summary>
    [TestClass()]
    public class frmEditVehicleStockTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for frmEditVehicleStock_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void frmEditVehicleStock_LoadTest()
        {
            AutomotiveManager.FormAction param0 = AutomotiveManager.FormAction.New; // TODO: Initialize to an appropriate value
            
            //VehicleStockData vehicleStockData = new VehicleStockData(
            //        NETChrisUsick.Properties.Resources.connectionString,
            //        NETChrisUsick.Properties.Resources.SalesStaffTableName,
            //        NETChrisUsick.Properties.Resources.SalesStaffSelect
            //    );

            //BindingSource bindingSource = new BindingSource();

            //bindingSource.DataSource = vehicleStockData.GetAllRows();
            //frmEditVehicleStock_Accessor target = new frmEditVehicleStock_Accessor(param0,
            //    bindingSource,
            //    vehicleStockData);
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            //target.frmEditVehicleStock_Load(sender, e);
            int bindingsExpected = 1;
            //Assert.AreEqual(bindingsExpected, target.radAutomatic.DataBindings.Count);
            //Assert.AreEqual(bindingsExpected, target.txtYear.DataBindings.Count);
            //Assert.AreEqual("ManufacturedYear", target.txtYear.DataBindings[0].BindingMemberInfo.BindingField);
        }
    }
}
