using NETChrisUsick;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using BusinessTier;

namespace ChrisUsickTest
{
    
    
    /// <summary>
    ///This is a test class for frmServiceInvoiceTest and is intended
    ///to contain all frmServiceInvoiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class frmServiceInvoiceTest
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
        ///A test for frmServiceInvoice_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void frmServiceInvoice_LoadTest()
        {
            ServiceInvoice beginInvoice = new ServiceInvoice(0.05, 0.08);
            beginInvoice.AddCost(ServiceInvoice.CostType.Part, 50);
            beginInvoice.AddCost(ServiceInvoice.CostType.Material, 20);
            frmServiceInvoice_Accessor target = new frmServiceInvoice_Accessor(beginInvoice); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.frmServiceInvoice_Load(sender, e);
            Label[] labels = new[] {target.lblLabourCost, target.lblPartsCost, target.lblMaterialCost, target.lblSubtotal, target.lblPST,
                target.lblGST, target.lblTotal};
            ServiceInvoice invoice = target.invoice;
            double[] values = new[] {invoice.LabourCost, invoice.PartsCost, invoice.MaterialCost, invoice.SubTotal,
                invoice.PSTCharged, invoice.GSTCharged, invoice.Total};

            // loop through the parallel arrays and assign values
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = values[i].ToString("c");
            }
        }
    }
}
