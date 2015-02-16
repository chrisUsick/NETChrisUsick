using BusinessTier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChrisUsickTest
{
    
    
    /// <summary>
    ///This is a test class for ServiceInvoiceTest and is intended
    ///to contain all ServiceInvoiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ServiceInvoiceTest
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
        ///A test for LabourCost
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BusinessTier.dll")]
        public void LabourCostTest()
        {
            ServiceInvoice_Accessor target = new ServiceInvoice_Accessor(0, 0); 
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.LabourCost = expected;
            actual = target.LabourCost;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for PartsCost
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BusinessTier.dll")]
        public void PartsCostTest()
        {
            ServiceInvoice_Accessor target = new ServiceInvoice_Accessor(0, 0); 
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.PartsCost = expected;
            actual = target.PartsCost;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for MaterialCost
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BusinessTier.dll")]
        public void MaterialCostTest()
        {
            ServiceInvoice_Accessor target = new ServiceInvoice_Accessor(0,0); 
            double expected = 0F; 
            double actual;
            target.MaterialCost = expected;
            actual = target.MaterialCost;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for PSTCharged
        ///</summary>
        [TestMethod()]
        public void PSTChargedTest()
        {
           
            double pstRate = 0.1; // TODO: Initialize to an appropriate value
            double gstRate = 0F; // TODO: Initialize to an appropriate value
            ServiceInvoice target = new ServiceInvoice(pstRate, gstRate); // TODO: Initialize to an appropriate value
            target.AddCost(ServiceInvoice.CostType.Labour, 10);
            double expected = 10 * 0.1;
            double actual;
            actual = target.PSTCharged;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AddCost for Labour
        ///</summary>
        [TestMethod()]
        public void AddCostTestLabour()
        {
            double pstRate = 0F; // TODO: Initialize to an appropriate value
            double gstRate = 0F; // TODO: Initialize to an appropriate value
            ServiceInvoice target = new ServiceInvoice(pstRate, gstRate); // TODO: Initialize to an appropriate value
            ServiceInvoice.CostType costType = ServiceInvoice.CostType.Labour; // TODO: Initialize to an appropriate value
            double cost = 10; // TODO: Initialize to an appropriate value
            target.AddCost(costType, cost);
            double expected = cost;
            double actual = target.LabourCost;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AddCost Material
        ///</summary>
        [TestMethod()]
        public void AddCostTestMaterial()
        {
            double pstRate = 0F; // TODO: Initialize to an appropriate value
            double gstRate = 0F; // TODO: Initialize to an appropriate value
            ServiceInvoice target = new ServiceInvoice(pstRate, gstRate); // TODO: Initialize to an appropriate value
            ServiceInvoice.CostType costType = ServiceInvoice.CostType.Material; // TODO: Initialize to an appropriate value
            double cost = 10; // TODO: Initialize to an appropriate value
            target.AddCost(costType, cost);
            double expected = cost;
            double actual = target.MaterialCost;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AddCost Parts 
        ///</summary>
        [TestMethod()]
        public void AddCostTestParts()
        {
            double pstRate = 0F; // TODO: Initialize to an appropriate value
            double gstRate = 0F; // TODO: Initialize to an appropriate value
            ServiceInvoice target = new ServiceInvoice(pstRate, gstRate); // TODO: Initialize to an appropriate value
            ServiceInvoice.CostType costType = ServiceInvoice.CostType.Part; // TODO: Initialize to an appropriate value
            double cost = 10; // TODO: Initialize to an appropriate value
            target.AddCost(costType, cost);
            double expected = cost;
            double actual = target.PartsCost;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GSTCharged
        ///</summary>
        [TestMethod()]
        public void GSTChargedTest()
        {
            double pstRate = 0F; // TODO: Initialize to an appropriate value
            double gstRate = 0.1; // TODO: Initialize to an appropriate value
            ServiceInvoice target = new ServiceInvoice(pstRate, gstRate); // TODO: Initialize to an appropriate value
            target.AddCost(ServiceInvoice.CostType.Labour, 10);
            double expected = 10 * 0.1;
            double actual;
            actual = target.GSTCharged;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SubTotal
        ///</summary>
        [TestMethod()]
        public void SubTotalTest()
        {
            double pstRate = 0F; // TODO: Initialize to an appropriate value
            double gstRate = 0F; // TODO: Initialize to an appropriate value
            ServiceInvoice target = new ServiceInvoice(pstRate, gstRate); // TODO: Initialize to an appropriate value
            target.AddCost(ServiceInvoice.CostType.Labour, 10);
            target.AddCost(ServiceInvoice.CostType.Material, 10);
            double expected = 20;
            double actual;
            actual = target.SubTotal;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Total
        ///</summary>
        [TestMethod()]
        public void TotalTest()
        {
            double pstRate = 0.1; // TODO: Initialize to an appropriate value
            double gstRate = 0F; // TODO: Initialize to an appropriate value
            ServiceInvoice target = new ServiceInvoice(pstRate, gstRate); // TODO: Initialize to an appropriate value
            target.AddCost(ServiceInvoice.CostType.Labour, 10);
            target.AddCost(ServiceInvoice.CostType.Material, 10);
            double expected = 20 * 1.1;
            double actual;
            actual = target.Total;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ServiceInvoice Constructor
        ///</summary>
        [TestMethod()]
        public void ServiceInvoiceConstructorTest()
        {
            double pstRate = 0.08; // TODO: Initialize to an appropriate value
            double gstRate = 0.05; // TODO: Initialize to an appropriate value
            ServiceInvoice target = new ServiceInvoice(pstRate, gstRate);
            Assert.AreEqual(pstRate, target.PSTRate);
            Assert.AreEqual(gstRate, target.GSTRate);
        }
    }
}
