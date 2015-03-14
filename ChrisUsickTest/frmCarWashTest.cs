using NETChrisUsick;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChrisUsickTest
{
    
    
    /// <summary>
    ///This is a test class for frmCarWashTest and is intended
    ///to contain all frmCarWashTest Unit Tests
    ///</summary>
    [TestClass()]
    public class frmCarWashTest
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
        ///A test for setOptions
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void setOptionsTest()
        {
            frmCarWash_Accessor target = new frmCarWash_Accessor(); // TODO: Initialize to an appropriate value
            string rawData = "opt1\nopt2"; // TODO: Initialize to an appropriate value
            List<string> list = new List<string>(); // TODO: Initialize to an appropriate value
            target.setOptions(rawData, list);
            int expected = 2;
            int actual = list.Count;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for populateComboBoxes
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void populateComboBoxesTest()
        {
            frmCarWash_Accessor target = new frmCarWash_Accessor(); // TODO: Initialize to an appropriate value
            string cvsString = "frag 1,2.0\nfrag 2,5.5"; // TODO: Initialize to an appropriate value
            ComboBox comboBox = target.cboFragrance; // TODO: Initialize to an appropriate value
            int selectedIndex = 0; // TODO: Initialize to an appropriate value
            target.populateComboBoxes(cvsString, comboBox, selectedIndex);
            int lengthExpected = 2;
            int lengthActual = target.cboFragrance.Items.Count;
            Assert.AreEqual(lengthExpected, lengthActual);
            Assert.AreEqual(selectedIndex, target.cboFragrance.SelectedIndex, "Didn't select the correct item");
        }

        /// <summary>
        ///A test for updateListBox
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void updateListBoxTest()
        {
            frmCarWash_Accessor target = new frmCarWash_Accessor(); // TODO: Initialize to an appropriate value
            ListBox listBox = target.lstInterior; // TODO: Initialize to an appropriate value

            // populate combobox
            target.populateComboBoxes("opt 1,23\nopt 2,34\nopt 3,23", target.cboPackage, 0);
            List<string> options = new List<string>(new[] { "opt 1", "opt 2" }); // TODO: Initialize to an appropriate value
            target.updateListBox(listBox, options);
            Assert.AreEqual(1, target.lstInterior.Items.Count, "incorrect amount of items added");
        }

        /// <summary>
        ///A test for control_Changed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETChrisUsick.exe")]
        public void control_ChangedTest()
        {
            frmCarWash_Accessor target = new frmCarWash_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            // populate combobox
            target.populateComboBoxes("opt 1,23\nopt 2,34\nopt 3,23", target.cboPackage, 0);
            target.populateComboBoxes("fOpt 1,25\nfOpt 2, 54", target.cboFragrance, 1);

            // set options values
            target.setOptions("op1\nop2\nop3", target.InteriorOptions);
            target.setOptions("op1\nop2\nop3\n", target.ExteriorOptions);

            target.control_Changed(sender, e);
            string notExpected = string.Empty;
            
            // labels are set
            Assert.AreNotEqual(notExpected,target.lblSubtotal.Text, "labels weren't set");
            Assert.AreNotEqual(notExpected, target.lblPst.Text);
            Assert.AreNotEqual(notExpected, target.lblGst.Text);
            Assert.AreNotEqual(notExpected, target.lblTotal.Text);

            //list boxes set
            Assert.AreEqual(1, target.lstInterior.Items.Count);
            Assert.AreEqual(1, target.lstExterior.Items.Count);

            //fragrance item is set
            // 3 is the length of the first value of interior options
            bool fragranceTest = 3 <= target.lstInterior.Items[0].ToString().Length;
            Assert.IsTrue(fragranceTest);
        }
    }
}
