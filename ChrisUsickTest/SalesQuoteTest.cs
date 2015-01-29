using BusinessTier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChrisUsickTest
{
    
    
    /// <summary>
    ///This is a test class for SalesQuoteTest and is intended
    ///to contain all SalesQuoteTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SalesQuoteTest
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
        ///A test for AccessoryCost
        ///</summary>
        [TestMethod()]
        public void AccessoryCostTest()
        {
            double vehicleSalePrice = 0F;
            double tradeInValue = 0F; 
            double salesTaxRate = 0F;
            SalesQuote.Accessories accessoriesChosen = SalesQuote.Accessories.StereoAndNavigation; 
            SalesQuote.ExteriorFinish exteriorFinshChosen = SalesQuote.ExteriorFinish.None; 
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinshChosen); 
            double actual;
            actual = target.AccessoryCost;
            double expected = SalesQuote.Accessory.STEREO_SYSTEM + SalesQuote.Accessory.COMPUTER_NAVIGATION;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FinishCost
        ///</summary>
        [TestMethod()]
        public void FinishCostTest()
        {
            double vehicleSalePrice = 0F;
            double tradeInValue = 0F; 
            double salesTaxRate = 0F; 
            SalesQuote.Accessories accessoriesChosen = new SalesQuote.Accessories();
            SalesQuote.ExteriorFinish exteriorFinshChosen = SalesQuote.ExteriorFinish.Custom;
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinshChosen);
            double actual;
            actual = target.FinishCost;
            double expected = SalesQuote.Finish.CUSTOM;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SubTotal
        ///</summary>
        [TestMethod()]
        public void SubTotalTest()
        {
            double vehicleSalePrice = 100;
            double tradeInValue = 0F;
            double salesTaxRate = 0F;
            SalesQuote.Accessories accessoriesChosen = SalesQuote.Accessories.LeatherInterior;
            SalesQuote.ExteriorFinish exteriorFinshChosen = SalesQuote.ExteriorFinish.Custom;
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinshChosen);
            double actual;
            actual = target.SubTotal;
            double expected = SalesQuote.Finish.CUSTOM + SalesQuote.Accessory.LEATHER_INTERIOR + 100;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SalesTax
        ///</summary>
        [TestMethod()]
        public void SalesTaxTest()
        {
            double vehicleSalePrice = 100;
            double tradeInValue = 0F;
            double salesTaxRate = 0.1;
            SalesQuote.Accessories accessoriesChosen = SalesQuote.Accessories.None;
            SalesQuote.ExteriorFinish exteriorFinshChosen = SalesQuote.ExteriorFinish.Standard;
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinshChosen);
            double actual;
            actual = target.SalesTax;
            double expected = 100 * salesTaxRate;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Total
        ///</summary>
        [TestMethod()]
        public void TotalTest()
        {
            double vehicleSalePrice = 100;
            double tradeInValue = 0F;
            double salesTaxRate = 0.1;
            SalesQuote.Accessories accessoriesChosen = SalesQuote.Accessories.None;
            SalesQuote.ExteriorFinish exteriorFinshChosen = SalesQuote.ExteriorFinish.Standard;
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinshChosen);
            double actual;
            actual = target.Total;
            double expected = vehicleSalePrice * salesTaxRate + vehicleSalePrice;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AmountDue
        ///</summary>
        [TestMethod()]
        public void AmountDueTest()
        {
            double vehicleSalePrice = 100;
            double tradeInValue = 10;
            double salesTaxRate = 0.1;
            SalesQuote.Accessories accessoriesChosen = SalesQuote.Accessories.None;
            SalesQuote.ExteriorFinish exteriorFinshChosen = SalesQuote.ExteriorFinish.Standard;
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinshChosen);
            double actual;
            actual = target.AmountDue;
            double expected = vehicleSalePrice * salesTaxRate + vehicleSalePrice - tradeInValue;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SalesQuote Constructor
        ///</summary>
        [TestMethod()]
        public void SalesQuoteConstructorTest()
        {
            double vehicleSalePrice = 0F; 
            double tradeInValue = 0F; 
            double salesTaxRate = 0F; 
            SalesQuote.Accessories accessoriesChosen = SalesQuote.Accessories.None; 
            SalesQuote.ExteriorFinish exteriorFinshChosen = SalesQuote.ExteriorFinish.Custom;
            SalesQuote_Accessor target = new SalesQuote_Accessor(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinshChosen);
            Assert.AreEqual(vehicleSalePrice, target.vehicleSalePrice);
            Assert.AreEqual(tradeInValue, target.tradeInValue);
            Assert.AreEqual(salesTaxRate, target.salesTaxRate);
            Assert.AreEqual(accessoriesChosen, target.accessoriesChosen);
            Assert.AreEqual(exteriorFinshChosen, target.exteriorFinishChosen);
        }
    }
}
