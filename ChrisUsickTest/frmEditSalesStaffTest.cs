using NETChrisUsick;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace ChrisUsickTest
{
    
    
    /// <summary>
    ///This is a test class for frmEditSalesStaffTest and is intended
    ///to contain all frmEditSalesStaffTest Unit Tests
    ///</summary>
    [TestClass()]
    public class frmEditSalesStaffTest
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
        ///A test for txtBox_Validated
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtBox_ValidatedTest()
        {
            frmEditSalesStaff_Accessor target = new frmEditSalesStaff_Accessor(); // TODO: Initialize to an appropriate value
            object sender = target.txtFirstName; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            // add to controls with errors;
            target.textBox_Validating(sender, new CancelEventArgs());
            target.txtFirstName.Text = "foo";
            target.txtBox_Validated(sender, e);
            Assert.AreEqual(-1, target.controlsWithErrors.IndexOf((Control)sender));
        }
    }
}
