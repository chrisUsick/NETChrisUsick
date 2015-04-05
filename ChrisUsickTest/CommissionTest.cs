using BusinessTier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChrisUsickTest
{
    
    
    /// <summary>
    ///This is a test class for CommissionTest and is intended
    ///to contain all CommissionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CommissionTest
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
        ///A test for getCommission
        ///</summary>
        [TestMethod()]
        public void getCommissionTestLess10()
        {
            Commission target = new Commission(); // TODO: Initialize to an appropriate value
            
            DateTime startDate = new DateTime(2015, 1, 1); // TODO: Initialize to an appropriate value
            double purchasePrice = 100; // TODO: Initialize to an appropriate value
            double optionsPrice = 10; // TODO: Initialize to an appropriate value
            double expected = purchasePrice * 0.02 + optionsPrice * 0.02; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.getCommission(startDate, purchasePrice, optionsPrice);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getCommission
        ///</summary>
        [TestMethod()]
        public void getCommissionTest10To14()
        {
            Commission target = new Commission(); // TODO: Initialize to an appropriate value
            DateTime startDate = new DateTime(2004, 1, 1); // TODO: Initialize to an appropriate value
            double purchasePrice = 100; // TODO: Initialize to an appropriate value
            double optionsPrice = 10; // TODO: Initialize to an appropriate value
            double expected = purchasePrice * 0.05 + optionsPrice * 0.02; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.getCommission(startDate, purchasePrice, optionsPrice);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getCommission
        ///</summary>
        [TestMethod()]
        public void getCommissionTestOver15()
        {
            Commission target = new Commission(); // TODO: Initialize to an appropriate value
            DateTime startDate = new DateTime(1991, 1, 1); // TODO: Initialize to an appropriate value
            double purchasePrice = 100; // TODO: Initialize to an appropriate value
            double optionsPrice = 10; // TODO: Initialize to an appropriate value
            double expected = purchasePrice * 0.1 + optionsPrice * 0.02; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.getCommission(startDate, purchasePrice, optionsPrice);
            Assert.AreEqual(expected, actual);
        }
    }
}
