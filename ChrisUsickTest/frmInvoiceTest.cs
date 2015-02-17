using NETChrisUsick;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace ChrisUsickTest
{
    
    
    /// <summary>
    ///This is a test class for frmInvoiceTest and is intended
    ///to contain all frmInvoiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class frmInvoiceTest
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
        ///A test for frmInvoice_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void frmInvoice_LoadTest()
        {
            frmInvoice_Accessor target = new frmInvoice_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.frmInvoice_Load(sender, e);
            Label[] labels = new[] {
                target.lblAddress,
                target.lblCity,
                target.lblDate,
                target.lblName,
                target.lblPhone,
            };
            string notExpected = string.Empty;
            foreach (Label label in labels)
            {
                Assert.AreNotEqual(notExpected, label.Text);
            }
        }
    }
}
