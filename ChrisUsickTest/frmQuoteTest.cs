using NETChrisUsick;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChrisUsickTest
{
    
    
    /// <summary>
    ///This is a test class for frmQuoteTest and is intended
    ///to contain all frmQuoteTest Unit Tests
    ///</summary>
    [TestClass()]
    public class frmQuoteTest
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
        ///A test for textbox_Enter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void textbox_EnterTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); 
            object sender = target.txtSalePrice; 
            // change the sender text beforehand
            target.txtSalePrice.Text = "1023";
            EventArgs e = null; 
            target.textbox_Enter(sender, e);
            string expected = target.txtSalePrice.Text;
            string actual = target.txtSalePrice.SelectedText;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for textboxIsNumeric_Validating
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void textboxIsNumeric_ValidatingTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            TextBox sender = target.txtSalePrice; 
            sender.Text = "asdf";
            CancelEventArgs e = new CancelEventArgs();
            target.textboxIsNumeric_Validating(sender, e);
            string expected =  String.Empty;
            string actual = target.errorProvider.GetError(sender);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for txtSalePrice_Validating
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtSalePrice_ValidatingTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            CancelEventArgs e = new CancelEventArgs(); // TODO: Initialize to an appropriate value
            // set text to -1
            target.txtSalePrice.Text = "-1";
            target.txtSalePrice_Validating(sender, e);
            string notExpected = String.Empty;
            string actual = target.errorProvider.GetError(target.txtSalePrice);
            Assert.AreNotEqual(notExpected, actual);
        }

        /// <summary>
        ///A test for txtTradeIn_Validating
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtTradeIn_ValidatingTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            object sender = null; // TODO: Initialize to an appropriate value
            CancelEventArgs e = new CancelEventArgs(); // TODO: Initialize to an appropriate value
            // set text to -1
            target.txtTradeIn.Text = "-1";
            target.txtTradeIn_Validating(sender, e);
            string notExpected = String.Empty;
            string actual = target.errorProvider.GetError(target.txtTradeIn);
            Assert.AreNotEqual(notExpected, actual);
        }

        /// <summary>
        ///A test for control_Validated
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void control_ValidatedTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            Control sender = target.txtTradeIn; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.control_Validated(sender, e);
            string expected = String.Empty;
            string actual = target.errorProvider.GetError(sender);
            Assert.AreEqual(expected, actual);
        }
    }
}
