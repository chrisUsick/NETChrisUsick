﻿using NETChrisUsick;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using BusinessTier;
using System.Windows.Forms;

namespace ChrisUsickTest
{
    
    
    /// <summary>
    ///This is a test class for frmServiceTest and is intended
    ///to contain all frmServiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class frmServiceTest
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
        ///A test for txtDescription_Enter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void textbox_EnterTest()
        {
            frmService_Accessor target = new frmService_Accessor(); // TODO: Initialize to an appropriate value
            object sender = target.txtDescription; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.txtDescription.Text = "abcd";
            target.textbox_Enter(sender, e);
            int expected = target.txtDescription.Text.Length;
            int actual = target.txtDescription.SelectedText.Length;
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for txtDescription_Validating Empty
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtDescription_ValidatingTestEmpty()
        {
            frmService_Accessor target = new frmService_Accessor(); 
            object sender = null;     
            CancelEventArgs e = new CancelEventArgs();
            target.txtDescription.Text = string.Empty;
            target.txtDescription_Validating(sender, e);
            bool cancelExpected = true;
            bool cancelActual = e.Cancel;
            string messageNotExpected = string.Empty;
            string messageActual = target.errorProvider.GetError(target.txtDescription);

            Assert.AreEqual(cancelExpected, cancelActual);
            Assert.AreNotEqual(messageNotExpected, messageActual);
        }

        /// <summary>
        ///A test for txtDescription_Validating white-space
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtDescription_ValidatingTestWhiteSpace()
        {
            frmService_Accessor target = new frmService_Accessor();
            object sender = null;
            CancelEventArgs e = new CancelEventArgs();

            // make sure trim event happened
            target.txtDescription.Text = "            ";
            target.txtDescription_Validating(sender, e);
            bool cancelExpected = true;
            bool cancelActual = e.Cancel;
            string messageNotExpected = string.Empty;
            string messageActual = target.errorProvider.GetError(target.txtDescription);

            Assert.AreEqual(cancelExpected, cancelActual, "validating event wasn't canceled");
            Assert.AreNotEqual(messageNotExpected, messageActual, "error message wasn't displayed");
        }

        /// <summary>
        ///A test for txtDescription_Validating valid
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtDescription_ValidatingTestValid()
        {
            frmService_Accessor target = new frmService_Accessor();
            object sender = null;
            CancelEventArgs e = new CancelEventArgs();

            // make sure trim event happened
            target.txtDescription.Text = "       d     ";
            target.txtDescription_Validating(sender, e);
            bool cancelExpected = false;
            bool cancelActual = e.Cancel;
            string messageExpected = string.Empty;
            string messageActual = target.errorProvider.GetError(target.txtDescription);

            Assert.AreEqual(cancelExpected, cancelActual, "validating event was canceled");
            Assert.AreEqual(messageExpected, messageActual, "error message was displayed");
        }

        /// <summary>
        ///A test for txtDescription_Validated
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void control_ValidatedTest()
        {
            frmService_Accessor target = new frmService_Accessor(); // TODO: Initialize to an appropriate value
            object sender = target.txtDescription; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.control_Validated(sender, e);
            string expected = string.Empty;
            string actual = target.errorProvider.GetError(target.txtDescription);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for txtDescription_TextChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtDescription_TextChangedTest()
        {
            frmService_Accessor target = new frmService_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.txtDescription.Text = "  d ";
            int expected = 1;
            target.txtDescription_TextChanged(sender, e);
            int actual = target.txtDescription.Text.Length;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for cboType_Validating fail
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void cboType_ValidatingTestFail()
        {
            frmService_Accessor target = new frmService_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            CancelEventArgs e = new CancelEventArgs(); // TODO: Initialize to an appropriate value
            target.cboType_Validating(sender, e);

            bool cancelExpected = true;
            bool cancelActual = e.Cancel;
            Assert.AreEqual(cancelExpected, cancelActual);

            string messageNotExpected = string.Empty;
            string messageActual = target.errorProvider.GetError(target.cboType);
            Assert.AreNotEqual(messageNotExpected, messageActual);
        }

        /// <summary>
        ///A test for cboType_Validating success
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void cboType_ValidatingTestSuccess()
        {
            frmService_Accessor target = new frmService_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            CancelEventArgs e = new CancelEventArgs(); // TODO: Initialize to an appropriate value
            target.cboType.SelectedItem = target.cboType.Items[0];
            target.cboType_Validating(sender, e);

            bool cancelExpected = false;
            bool cancelActual = e.Cancel;
            Assert.AreEqual(cancelExpected, cancelActual);

            string messageExpected = string.Empty;
            string messageActual = target.errorProvider.GetError(target.cboType);
            Assert.AreEqual(messageExpected, messageActual);
        }

        /// <summary>
        ///A test for txtCost_Validating non-numeric
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtCost_ValidatingTestNonNumeric()
        {
            frmService_Accessor target = new frmService_Accessor();
            object sender = null; 
            CancelEventArgs e = new CancelEventArgs();
            target.txtCost.Text = "3d.1;";
            target.txtCost_Validating(sender, e);

            bool cancelExpected = true;
            bool cancelActual = e.Cancel;
            Assert.AreEqual(cancelExpected, cancelActual, "validating event not canceld");

            string messageNotExpected = string.Empty;
            string messageActual = target.errorProvider.GetError(target.txtCost);
            Assert.AreNotEqual(messageNotExpected, messageActual, "error message not set");
        }

        /// <summary>
        ///A test for txtCost_Validating negative
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtCost_ValidatingTestNegative()
        {
            frmService_Accessor target = new frmService_Accessor();
            object sender = null;
            CancelEventArgs e = new CancelEventArgs();
            target.txtCost.Text = "-3.1;";
            target.txtCost_Validating(sender, e);

            bool cancelExpected = true;
            bool cancelActual = e.Cancel;
            Assert.AreEqual(cancelExpected, cancelActual, "validating event not canceld");

            string messageNotExpected = string.Empty;
            string messageActual = target.errorProvider.GetError(target.txtCost);
            Assert.AreNotEqual(messageNotExpected, messageActual, "error message not set");
        }

        /// <summary>
        ///A test for txtCost_Validating success
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void txtCost_ValidatingTestSuccess()
        {
            frmService_Accessor target = new frmService_Accessor();
            object sender = null;
            CancelEventArgs e = new CancelEventArgs();
            target.txtCost.Text = "3.1";
            target.txtCost_Validating(sender, e);

            bool cancelExpected = false;
            bool cancelActual = e.Cancel;
            Assert.AreEqual(cancelExpected, cancelActual, "validating event canceld");

            string messageExpected = string.Empty;
            string messageActual = target.errorProvider.GetError(target.txtCost);
            Assert.AreEqual(messageExpected, messageActual, "error message set");
        }

        /// <summary>
        ///A test for btnAdd_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void btnAdd_ClickTest()
        {
            frmService_Accessor target = new frmService_Accessor(); 
            object sender = null;
            EventArgs e = null;
            target.txtDescription.Text = "foo";
            target.txtCost.Text = "10";
            target.cboType.SelectedIndex = 0;
            int rowsExpected = target.dgvServices.Rows.Count + 1;
            target.btnAdd_Click(sender, e);
            int rowsActual = target.dgvServices.Rows.Count;
            // item added to data grid
            Assert.AreEqual(rowsExpected, rowsActual, "row not added");

            // labels set

            // inputs cleared
            Assert.AreEqual(string.Empty, target.txtDescription.Text);
            Assert.AreEqual(string.Empty, target.txtCost.Text);
            Assert.AreEqual(-1, target.cboType.SelectedIndex);

            // focus set
            // can't test this because having an event handler on the enter event has strange side effects in
            // a testing environment. See frmSalesQuoteTest.btnCalculate_ClickTestValidates()
            //Assert.AreEqual(true, target.txtDescription.Focused, "didn't focus on txtDescription");
        }

        /// <summary>
        ///A test for updateSummaryLabels
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void updateSummaryLabelsTest()
        {
            frmService_Accessor target = new frmService_Accessor(); // TODO: Initialize to an appropriate value
            ServiceInvoice invoice = new ServiceInvoice(0.05, 0.08);
            target.invoice = invoice;
            // add a row to the datagrid
            // this triggers the RowAdded event which calls updateSummaryLabels
            target.dgvServices.Rows.Add(new[] { "1", "foo", target.cboType.Items[0].ToString(), "10" });
            //target.updateSummaryLabels();

            // make sure labels were set
            string notExpected = string.Empty;
            Assert.AreNotEqual(notExpected, target.lblSubtotal.Text);
            Assert.AreNotEqual(notExpected, target.lblGST.Text);
            Assert.AreNotEqual(notExpected, target.lblPST.Text);
            Assert.AreNotEqual(notExpected, target.lblTotal);

            // ensure row was added to invoice
            double expected = 10;
            double actual = invoice.SubTotal;
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for dgvServices_RowsAdded
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void dgvServices_RowsAddedTest()
        {
            frmService_Accessor target = new frmService_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewRowsAddedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.invoice = new ServiceInvoice(0, 0);
            target.dgvServices.Rows.Add(new[] { "1", "df", "Labour", "10" });
            target.dgvServices_RowsAdded(sender, e);
            bool expected = true;
            bool actual = target.mnuServiceGenerateInvoice.Enabled;
            
            // items are enabled
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, target.mnuContextClear.Enabled); 
            // assert summary label is updated.
            string notExpected = string.Empty;
            string subtotal = target.lblSubtotal.Text;
            Assert.AreNotEqual(notExpected, subtotal);

        }

        /// <summary>
        ///A test for dgvServices_RowsRemoved labels cleard
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void dgvServices_RowsRemovedTestClearLabels()
        {
            frmService_Accessor target = new frmService_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewRowsRemovedEventArgs e = null; // TODO: Initialize to an appropriate value
            try
            {
                target.dgvServices.Rows.Add(new string[] { });
            }
            catch (NullReferenceException ex)
            {
            }
            target.dgvServices_RowsRemoved(sender, e);
            string expected = string.Empty;
            string actual = target.lblSubtotal.Text;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for dgvServices_RowsRemoved rows left
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void dgvServices_RowsRemovedTestRowsLeft()
        {
            frmService_Accessor target = new frmService_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewRowsRemovedEventArgs e = null; // TODO: Initialize to an appropriate value
            try
            {
                target.dgvServices.Rows.Add(new string[] { });
                target.dgvServices.Rows.Add(new string[] { });
            }
            catch (NullReferenceException ex)
            {
            }
            target.dgvServices_RowsRemoved(sender, e);
            bool expected = true;
            bool actualInvoice = target.mnuServiceGenerateInvoice.Enabled;
            bool actualClear = target.mnuContextClear.Enabled;
            Assert.AreEqual(expected, actualClear);
            Assert.AreEqual(expected, actualInvoice);
        }

        /// <summary>
        ///A test for dgvServices_RowsRemoved no rows left
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void dgvServices_RowsRemovedTestNoRowsLeft()
        {
            frmService_Accessor target = new frmService_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewRowsRemovedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.dgvServices_RowsRemoved(sender, e);
            bool expected = false;
            bool actualInvoice = target.mnuServiceGenerateInvoice.Enabled;
            bool actualClear = target.mnuContextClear.Enabled;
            Assert.AreEqual(expected, actualClear);
            Assert.AreEqual(expected, actualInvoice);
            
        }

        /// <summary>
        ///A test for dgvServices_SelectionChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void dgvServices_SelectionChangedTest()
        {
            frmService_Accessor target = new frmService_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.invoice = new ServiceInvoice(0, 0);
            target.dgvServices.Rows.Add(new[] { "1", "foo", "Labour", "10" });
            target.dgvServices.Rows[0].Cells[0].Selected = true;
            int expected = 0;
            target.dgvServices_SelectionChanged(sender, e);
            int actual = target.dgvServices.SelectedCells.Count;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for mnuContextClear_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void mnuContextClear_ClickTest()
        {
            frmService_Accessor target = new frmService_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.invoice = new ServiceInvoice(0, 0);
            target.dgvServices.Rows.Add(new string[] {"1", "asdf", "Labour", "10"});
            target.mnuContextClear_Click(sender, e);
            double expected = 0;
            double actual = target.dgvServices.Rows.Count;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for clearSummaryLabels
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void clearSummaryLabelsTest()
        {
            frmService_Accessor target = new frmService_Accessor(); // TODO: Initialize to an appropriate value
            target.clearSummaryLabels();
            string expected = string.Empty;
            Assert.AreEqual(expected, target.lblSubtotal.Text);
            Assert.AreEqual(expected, target.lblGST.Text);
            Assert.AreEqual(expected, target.lblPST.Text);
            Assert.AreEqual(expected, target.lblTotal.Text);
        }
    }
}
