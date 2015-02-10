using NETChrisUsick;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using BusinessTier;
using System.Collections.Generic;
using System.Globalization;

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
        public void textboxIsNumeric_ValidatingTestNonNumeric()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            TextBox sender = target.txtSalePrice;
            sender.Text = "asdf";
            CancelEventArgs e = new CancelEventArgs();
            target.textboxIsNumeric_Validating(sender, e);
            string expected = String.Empty;
            string actual = target.errorProvider.GetError(sender);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for textboxIsNumeric_Validating numberic
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void textboxIsNumeric_ValidatingTestNumeric()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            TextBox sender = target.txtSalePrice;
            sender.Text = "100";
            CancelEventArgs e = new CancelEventArgs();
            target.textboxIsNumeric_Validating(sender, e);
            string expected = String.Empty;
            string actual = target.errorProvider.GetError(sender);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for txtSalePrice_Validating below zero
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtSalePrice_ValidatingTestBelowZero()
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
        ///A test for txtSalePrice_Validating zero
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtSalePrice_ValidatingTestZero()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            CancelEventArgs e = new CancelEventArgs(); // TODO: Initialize to an appropriate value
            // set text to -1
            target.txtSalePrice.Text = "0";
            target.txtSalePrice_Validating(sender, e);
            string notExpected = String.Empty;
            string actual = target.errorProvider.GetError(target.txtSalePrice);
            Assert.AreNotEqual(notExpected, actual);
        }

        /// <summary>
        ///A test for txtSalePrice_Validating above zero
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtSalePrice_ValidatingTestAboveZero()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            CancelEventArgs e = new CancelEventArgs(); // TODO: Initialize to an appropriate value
            // set text to -1
            target.txtSalePrice.Text = "10034";
            target.txtSalePrice_Validating(sender, e);
            string expected = String.Empty;
            string actual = target.errorProvider.GetError(target.txtSalePrice);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for txtTradeIn_Validating below zero
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtTradeIn_ValidatingTestNegative()
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
        ///A test for txtTradeIn_Validating non negative
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtTradeIn_ValidatingTestNonNegative()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            object sender = null; // TODO: Initialize to an appropriate value
            CancelEventArgs e = new CancelEventArgs(); // TODO: Initialize to an appropriate value
            // set text to -1
            target.txtTradeIn.Text = "0";
            target.txtTradeIn_Validating(sender, e);
            string expected = String.Empty;
            string actual = target.errorProvider.GetError(target.txtTradeIn);
            Assert.AreEqual(expected, actual);
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

        /// <summary>
        ///A test for refocus
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void refocusTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            TextBox textbox = target.txtSalePrice; // TODO: Initialize to an appropriate value
            target.refocus(textbox);
            bool expected = true;
            bool actual = target.txtSalePrice.Focused;
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getAccessories
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void getAccessoriesTestNone()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            SalesQuote.Accessories expected = SalesQuote.Accessories.None; // TODO: Initialize to an appropriate value
            SalesQuote.Accessories actual;
            actual = target.getAccessories();
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for getAccessories
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void getAccessoriesTestStereo()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); 
            SalesQuote.Accessories expected = SalesQuote.Accessories.StereoSystem;
            target.chkStereo.Checked = true;
            SalesQuote.Accessories actual;
            actual = target.getAccessories();
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for getAccessories
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void getAccessoriesTestLeather()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            SalesQuote.Accessories expected = SalesQuote.Accessories.LeatherInterior;
            target.chkLeather.Checked = true;
            SalesQuote.Accessories actual;
            actual = target.getAccessories();
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for getAccessories
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void getAccessoriesTestStereoLeather()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            SalesQuote.Accessories expected = SalesQuote.Accessories.StereoAndLeather;
            target.chkStereo.Checked = true;
            target.chkLeather.Checked = true;
            SalesQuote.Accessories actual;
            actual = target.getAccessories();
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for getAccessories
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void getAccessoriesTestNav()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            SalesQuote.Accessories expected = SalesQuote.Accessories.ComputerNavigation;
            target.chkNavigation.Checked = true;
            SalesQuote.Accessories actual;
            actual = target.getAccessories();
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for getAccessories
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void getAccessoriesTestStereoNav()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            SalesQuote.Accessories expected = SalesQuote.Accessories.StereoAndNavigation;
            target.chkStereo.Checked = true;
            target.chkNavigation.Checked = true;
            SalesQuote.Accessories actual;
            actual = target.getAccessories();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getAccessories
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void getAccessoriesTestLeatherNav()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            SalesQuote.Accessories expected = SalesQuote.Accessories.LeatherAndNavigation;
            target.chkLeather.Checked = true;
            target.chkNavigation.Checked = true;
            SalesQuote.Accessories actual;
            actual = target.getAccessories();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getAccessories
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void getAccessoriesTestAll()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            SalesQuote.Accessories expected = SalesQuote.Accessories.All;
            target.chkStereo.Checked = true;
            target.chkNavigation.Checked = true;
            target.chkLeather.Checked = true;
            SalesQuote.Accessories actual;
            actual = target.getAccessories();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for frmQuote Constructor
        ///</summary>
        [TestMethod()]
        public void frmQuoteConstructorTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            string notExpected = null;
            string actual = target.grpAccessories.Text;
            string actual2 = target.lblTradeIn.Text;

            // assert that some comonents were initialized
            Assert.AreNotEqual(notExpected, actual);
            Assert.AreNotEqual(notExpected, actual2);
        }

        /// <summary>
        ///A test for frmQuote_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void frmQuote_LoadTest()
        {
            frmQuote target = new frmQuote();
            System.Drawing.Icon notExpected = null;
            System.Drawing.Icon actual = target.Icon;
            Assert.AreNotEqual(notExpected, actual);
        }


        /// <summary>
        ///A test for textbox_TextChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void textbox_TextChangedTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); 
            object sender = null; 
            EventArgs e = null;
            target.textbox_TextChanged(sender, e);
            string summaryExpected = String.Empty;
            bool grpfinanceExpected = false;
            string summaryActual = target.lblAmountDue.Text;
            bool grpFinanceActual = target.grpFinance.Enabled;

            // frmQuote.clearSummary is called internally and covered by it's own unit test
            // therefore doesn't need to be thoroughly tested here
            Assert.AreEqual(summaryExpected, summaryActual);
            Assert.AreEqual(grpfinanceExpected, grpFinanceActual);
        }

        /// <summary>
        ///A test for clearSummary
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void clearSummaryTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            target.clearSummary();
            string expected = String.Empty;
            foreach (Control control in target.grpSummary.Controls)
            {
                if (control.Name.StartsWith("lbl"))
                {
                    string actual = control.Text;
                    Assert.AreEqual(expected, actual);
                }
            }
        }

        /// <summary> 
        ///A test for btnCalculate_Click Validates
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void btnCalculate_ClickTestValidates()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); 
            object sender = null;
            EventArgs e = null;
            target.txtSalePrice.Text = "100";
            target.btnCalculate_Click(sender, e);

            //1. summary labels set
            string notTextExpected = string.Empty;
            foreach (Control control in target.grpSummary.Controls)
            {
                if (control.Name.StartsWith("lbl"))
                {
                    string actual = control.Text;
                    Assert.AreNotEqual(notTextExpected, actual);
                }
            }

            //2. txtSalePrice is focussed
            bool FocusExpected = true;
            bool focusActual = target.txtSalePrice.Focused;
            Assert.AreEqual(FocusExpected, focusActual, "txtSalePrice isn't focused");
        }

        /// <summary> 
        ///A test for btnCalculate_Click Doesnt Validate from salesPrice error
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void btnCalculate_ClickTestNotValidateSaleError()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            object sender = null;
            EventArgs e = null;
            target.txtSalePrice.Text = "-100";
            target.btnCalculate_Click(sender, e);

            //1. summary disabled
            bool grpSummaryExpected = false;
            bool grpSummaryActual = target.summaryIsSet;
            Assert.AreEqual(grpSummaryExpected, grpSummaryActual);

            //2. txtSalePrice is focussed
            bool FocusExpected = true;
            bool focusActual = target.txtSalePrice.Focused;
            Assert.AreEqual(FocusExpected, focusActual);
        }

        /// <summary> 
        ///A test for btnCalculate_Click Doesnt Validate from tradein error
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void btnCalculate_ClickTestNotValidateTradeInError()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            object sender = null;
            EventArgs e = null;
            target.txtSalePrice.Text = "100";
            target.txtTradeIn.Text = "a";
            target.btnCalculate_Click(sender, e);

            //1. summary disabled
            bool grpSummaryExpected = false;
            bool grpSummaryActual = target.summaryIsSet;
            Assert.AreEqual(grpSummaryExpected, grpSummaryActual);

            //2. txtSalePrice is focussed
            bool FocusExpected = true;
            bool focusActual = target.txtTradeIn.Focused;
            Assert.AreEqual(FocusExpected, focusActual);
        }

        /// <summary> 
        ///A test for btnCalculate_Click Validates and there is an amount due
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void btnCalculate_ClickTestValidatesAmountDue()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            object sender = null;
            EventArgs e = null;
            target.txtSalePrice.Text = "100";
            target.btnCalculate_Click(sender, e);

            bool expected = true;
            bool actual = target.grpFinance.Enabled;
            Assert.AreEqual(expected, actual);

        }

        /// <summary> 
        ///A test for btnCalculate_Click Validates and there is not an amount due
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void btnCalculate_ClickTestValidatesNoAmountDue()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            object sender = null;
            EventArgs e = null;
            target.txtSalePrice.Text = "100";
            target.txtTradeIn.Text = "150";
            target.btnCalculate_Click(sender, e);

            bool expected = false;
            bool actual = target.grpFinance.Enabled;
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for clearFinanceSection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void clearFinanceSectionTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); 
            target.clearFinanceSection();
            bool grpExpected = false;
            bool grpActual = target.grpFinance.Enabled;
            string paymentExpect = String.Empty;
            string paymentActual = target.lblMonthlyPayment.Text;
            Assert.AreEqual(grpExpected, grpActual, "grpFinance.Enabled isn't correctly set");
            Assert.AreEqual(paymentExpect, paymentActual, "lblMonthlyPayment isn't correct");
        }

        /// <summary>
        ///A test for setFinanceSection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void setFinanceSectionTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            // initialize a value in the quote private variable
            SalesQuote quote = new SalesQuote(
                100,
                0,
                0.13,
                SalesQuote.Accessories.None,
                SalesQuote.ExteriorFinish.Standard);
            target.quote = quote;
            target.setFinanceSection();
            double periods = (double)target.hsbNoYears.Value * 12;
            string expected = AutomotiveManager.Payment(target.getInterestRate(), periods, quote.AmountDue).ToString("C");
            string actual = target.lblMonthlyPayment.Text;
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for getInterestRate
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void getInterestRateTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); 
            double expected = target.hsbInterestRate.Value/10000.0;
            double actual;
            actual = target.getInterestRate();
            Assert.AreEqual(expected, actual);
        }



        /// <summary>
        ///A test for hsbInterestRate_ValueChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void hsbInterestRate_ValueChangedTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.txtSalePrice.Text = "100";
            target.btnCalculate_Click(null, null);
            string textExpected = (0.02).ToString("p2");
            string paymentNotExpected = string.Empty;
            string textActual;
            string paymentActual;
            target.hsbInterestRate_ValueChanged(sender, e);
            target.hsbInterestRate.Value = 200;
            textActual = target.lblInterestRate.Text;
            paymentActual = target.lblMonthlyPayment.Text;
            Assert.AreEqual(textExpected, textActual);
            Assert.AreNotEqual(paymentNotExpected, paymentActual);
        }

        /// <summary>
        ///A test for hsbNoYears_ValueChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void hsbNoYears_ValueChangedTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            // initial value
            string notExpected = target.lblNoYears.Text;
            string paymentNotExpected = target.lblMonthlyPayment.Text;

            target.txtSalePrice.Text = "100";
            target.btnCalculate_Click(null, null);

            target.hsbNoYears_ValueChanged(sender, e);

            // value after text changed
            string actual = target.lblNoYears.Text;
            Assert.AreNotEqual(notExpected, actual, "lblNoYears didn't change");

            // make sure payment changed
            string paymentActual = target.lblMonthlyPayment.Text;
            Assert.AreNotEqual(paymentNotExpected, paymentActual, "lblMonthly payment didn't change");
            
        }

        /// <summary>
        ///A test for lnkReset_LinkClicked
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void lnkReset_LinkClickedTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            target.isBeingTested = true;
            object sender = null;
            LinkLabelLinkClickedEventArgs e = null;
            target.lnkReset_LinkClicked(sender, e);

            // finance section
            string emtpyExpected = String.Empty;
            Assert.AreEqual(emtpyExpected, target.lblNoYears.Text, "no years label is wrong");
            Assert.AreEqual(emtpyExpected, target.lblInterestRate.Text, "interest rate label is wrong");

            int noYearsExpected = 3;
            int interestRateExpected = 500;
            Assert.AreEqual(noYearsExpected, target.hsbNoYears.Value, "no years HSB is wrong");
            Assert.AreEqual(interestRateExpected, target.hsbInterestRate.Value, "interest rate HSB is wrong");

            // text boxes
            Assert.AreEqual(emtpyExpected, target.txtSalePrice.Text, "sale price is wrong");
            string tradeInExpected = "0";
            Assert.AreEqual(tradeInExpected, target.txtTradeIn.Text, "trade in is wrong");

            // checkboxes
            CheckBox[] checkboxes = new[] { target.chkLeather, target.chkNavigation, target.chkStereo };
            int expectedLength = 0;
            int actualLength = checkboxes.ToList().FindAll(elem => elem.Checked).Count;
            Assert.AreEqual(expectedLength, actualLength, "checkboxes weren't reset correctly");

            // radio buttons
            IEnumerable<RadioButton> radios = new[] {target.radStandard, target.radPearlized, target.radCustomDetail};
            RadioButton radioExpected = target.radStandard;
            RadioButton radioActual = radios.First(rad => rad.Checked);
            Assert.AreEqual(radioExpected, radioActual, "radio buttons weren't reset correctly");
        }

        /// <summary>
        ///A test for IsBeingTested
        ///</summary>
        [TestMethod()]
        public void IsBeingTestedTest()
        {
            frmQuote target = new frmQuote(); // TODO: Initialize to an appropriate value
            bool expected = false;
            bool actual;
            actual = target.IsBeingTested;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for chkOrRadio_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void chkOrRadio_ClickTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); 
            object sender = null; 
            EventArgs e = null;
            // set the sale price
            target.txtSalePrice.Text = "100";

            // create a qote
            target.btnCalculate_Click(null, null);
            double notExpected = double.Parse(target.lblAmountDue.Text,NumberStyles.Currency);

            // simulate a click event
            target.radCustomDetail.Checked = true;

            target.chkOrRadio_Click(sender, e);
            // ensure there the old Amount due doesn't equal the new.
            double actual = Double.Parse(target.lblAmountDue.Text, NumberStyles.Currency);
            Assert.AreNotEqual(notExpected, actual); ;
        }
    }
}
