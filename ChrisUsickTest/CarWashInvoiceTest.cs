using BusinessTier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChrisUsickTest
{
    
    
    /// <summary>
    ///This is a test class for CarWashInvoiceTest and is intended
    ///to contain all CarWashInvoiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CarWashInvoiceTest
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
        ///A test for CarWashInvoice Constructor
        ///</summary>
        [TestMethod()]
        public void CarWashInvoiceConstructorTest()
        {
            double pstRate = 0.1; // TODO: Initialize to an appropriate value
            double gstRate = 0.1; // TODO: Initialize to an appropriate value
            double packageCost = 10; // TODO: Initialize to an appropriate value
            double fragranceCost = 10; // TODO: Initialize to an appropriate value
            CarWashInvoice target = new CarWashInvoice(pstRate, gstRate, packageCost, fragranceCost);
            Assert.AreEqual(packageCost, target.PackageCost);
            Assert.AreEqual(fragranceCost, target.FragranceCost);
            Assert.AreEqual(pstRate, target.PSTRate);
            Assert.AreEqual(gstRate, target.GSTRate);
        }

        /// <summary>
        ///A test for CarWashInvoice Constructor
        ///</summary>
        [TestMethod()]
        public void CarWashInvoiceConstructorTest1()
        {
            double pstRate = 0.1; // TODO: Initialize to an appropriate value
            double gstRate = 0.1; // TODO: Initialize to an appropriate value
            CarWashInvoice target = new CarWashInvoice(pstRate, gstRate);
            Assert.AreEqual(pstRate, target.PSTRate);
            Assert.AreEqual(gstRate, target.GSTRate);
        }

        /// <summary>
        ///A test for Total
        ///</summary>
        [TestMethod()]
        public void TotalTest()
        {
            double pstRate = 0.1; // TODO: Initialize to an appropriate value
            double gstRate = 0.1; // TODO: Initialize to an appropriate value
            double packageCost = 10; // TODO: Initialize to an appropriate value
            double fragranceCost = 10; // TODO: Initialize to an appropriate value
            CarWashInvoice target = new CarWashInvoice(pstRate, gstRate, packageCost, fragranceCost);
            double expected = (10 + 10) * 1.2;
            Assert.AreEqual(expected, target.Total);
        }

        /// <summary>
        ///A test for SubTotal
        ///</summary>
        [TestMethod()]
        public void SubTotalTest()
        {
            double pstRate = 0.1; // TODO: Initialize to an appropriate value
            double gstRate = 0.1; // TODO: Initialize to an appropriate value
            double packageCost = 10; // TODO: Initialize to an appropriate value
            double fragranceCost = 10; // TODO: Initialize to an appropriate value
            CarWashInvoice target = new CarWashInvoice(pstRate, gstRate, packageCost, fragranceCost);
            double expected = (10 + 10);
            Assert.AreEqual(expected, target.SubTotal);
        }

        /// <summary>
        ///A test for GSTCharged
        ///</summary>
        [TestMethod()]
        public void GSTChargedTest()
        {
            double pstRate = 0.1; // TODO: Initialize to an appropriate value
            double gstRate = 0.1; // TODO: Initialize to an appropriate value
            double packageCost = 10; // TODO: Initialize to an appropriate value
            double fragranceCost = 10; // TODO: Initialize to an appropriate value
            CarWashInvoice target = new CarWashInvoice(pstRate, gstRate, packageCost, fragranceCost);
            double expected = (10 + 10) * gstRate;
            Assert.AreEqual(expected, target.GSTCharged);
        }

        /// <summary>
        ///A test for PSTCharged
        ///</summary>
        [TestMethod()]
        public void PSTChargedTest()
        {
            double pstRate = 0.1; // TODO: Initialize to an appropriate value
            double gstRate = 0.1; // TODO: Initialize to an appropriate value
            double packageCost = 10; // TODO: Initialize to an appropriate value
            double fragranceCost = 10; // TODO: Initialize to an appropriate value
            CarWashInvoice target = new CarWashInvoice(pstRate, gstRate, packageCost, fragranceCost);
            double expected = (10 + 10) * pstRate;
            Assert.AreEqual(expected, target.PSTCharged);
        }

        /// <summary>
        ///A test for PackageCost
        ///</summary>
        [TestMethod()]
        public void PackageCostTest()
        {
            double pstRate = 0F; // TODO: Initialize to an appropriate value
            double gstRate = 0F; // TODO: Initialize to an appropriate value
            CarWashInvoice target = new CarWashInvoice(pstRate, gstRate); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.PackageCost = expected;
            actual = target.PackageCost;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FragranceCost
        ///</summary>
        [TestMethod()]
        public void FragranceCostTest()
        {
            double pstRate = 0F; // TODO: Initialize to an appropriate value
            double gstRate = 0F; // TODO: Initialize to an appropriate value
            CarWashInvoice target = new CarWashInvoice(pstRate, gstRate); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.FragranceCost = expected;
            actual = target.FragranceCost;
            Assert.AreEqual(expected, actual);
        }
    }
}
