using NETChrisUsick;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace ChrisUsickTest
{
    
    
    /// <summary>
    ///This is a test class for AutomotiveManagerTest and is intended
    ///to contain all AutomotiveManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AutomotiveManagerTest
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
        ///A test for IsNumeric with non-numeric input
        ///</summary>
        [TestMethod()]
        public void IsNumericTestNonNumeric()
        {
            string stringValue = "123f"; 
            bool expected = false; 
            bool actual;
            actual = AutomotiveManager.IsNumeric(stringValue);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IsNumeric with a number
        ///</summary>
        [TestMethod()]
        public void IsNumericTestNumeric()
        {
            string stringValue = "386";
            bool expected = true;
            bool actual = AutomotiveManager.IsNumeric(stringValue);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IsBeingTested
        ///</summary>
        [TestMethod()]
        public void IsBeingTestedTest()
        {
            bool actual;
            actual = AutomotiveManager.IsBeingTested;
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for MessageBoxResult
        ///</summary>
        [TestMethod()]
        public void MessageBoxResultTest()
        {
            DialogResult actual;
            actual = AutomotiveManager.MessageBoxResult;
            DialogResult expected = DialogResult.OK;
            Assert.AreEqual(expected, actual);
        }
    }
}
