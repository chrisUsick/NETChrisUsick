using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    /// <summary>
    /// a class used to determine a vehicle sales quotes for the RRC Automotive Group
    /// </summary>
    public class SalesQuote
    {
        /// <summary>
        /// Options for accessories of a vehicle
        /// </summary>
        public enum Accessories
        {
            None,
            StereoSystem,
            LeatherInterior,
            StereoAndLeather,
            ComputerNavigation,
            StereoAndNavigation,
            LeatherAndNavigation,
            All
        }

        /// <summary>
        /// Specifies the cost of the possible accessories of a vehicle
        /// </summary>
        public static class Accessory
        {
            public const double STEREO_SYSTEM = 505.05;
            public const double LEATHER_INTERIOR = 1010.10;
            public const double COMPUTER_NAVIGATION = 1515.15;
        }

        /// <summary>
        /// Options for the exterior finish of a vehicle
        /// </summary>
        public enum ExteriorFinish
        {
            None,
            Standard,
            Pearlized,
            Custom
        }

        /// <summary>
        /// Specifies the cost of possible finishes of a vehicle
        /// </summary>
        public static class Finish
        {
            public const double STANDARD = 0;
            public const double PEARLIZED = 404.04;
            public const double CUSTOM = 606.06;
        }
        
        // private properties, set in the constructor
        private double vehicleSalePrice;
        private double tradeInValue;
        private double salesTaxRate;
        private Accessories accessoriesChosen;
        private ExteriorFinish exteriorFinishChosen;

        // read only property to get the cost of the accessory for this quote
        public double AccessoryCost
        {
            get
            {
                // cost to be returned
                double cost = 0;

                // calculate cost based on the value of accessoriesChosen
                switch (accessoriesChosen)
                {
                    case Accessories.None:
                        cost = 0;
                        break;
                    case Accessories.StereoSystem:
                        cost = Accessory.STEREO_SYSTEM;
                        break;
                    case Accessories.LeatherInterior:
                        cost = Accessory.LEATHER_INTERIOR;
                        break;
                    case Accessories.StereoAndLeather:
                        cost = Accessory.LEATHER_INTERIOR + Accessory.STEREO_SYSTEM;
                        break;
                    case Accessories.ComputerNavigation:
                        cost = Accessory.COMPUTER_NAVIGATION;
                        break;
                    case Accessories.StereoAndNavigation:
                        cost = Accessory.COMPUTER_NAVIGATION + Accessory.STEREO_SYSTEM;
                        break;
                    case Accessories.LeatherAndNavigation:
                        cost = Accessory.LEATHER_INTERIOR + Accessory.COMPUTER_NAVIGATION;
                        break;
                    case Accessories.All:
                        cost = Accessory.LEATHER_INTERIOR + Accessory.COMPUTER_NAVIGATION + Accessory.STEREO_SYSTEM;
                        break;
                }
                // return the calculated cost
                return cost; 
            }
        }

        // read only property to get the cost of the exterior finish of the quote
        public double FinishCost
        {
            get
            {
                // cost to be return
                double cost = 0;

                // calculate the cost based on the value of exteriorFinishChosen
                switch (exteriorFinishChosen)
                {
                    case ExteriorFinish.None:
                        cost = 0;
                        break;
                    case ExteriorFinish.Standard:
                        cost = Finish.STANDARD;
                        break;
                    case ExteriorFinish.Pearlized:
                        cost = Finish.PEARLIZED;
                        break;
                    case ExteriorFinish.Custom:
                        cost = Finish.CUSTOM;
                        break;
                }

                // return the calculated cost
                return cost;
            }
        }

        // read only property to get the sub total price of the quote
        public double SubTotal
        {
            get
            {
                // the subTotal is the vehicle Sale Price + accessory cost + the finish cost
                return (vehicleSalePrice + AccessoryCost + FinishCost);
            }
        }

        // read-only property to get the sales tax
        public double SalesTax
        {
            get
            {
                // return the sales tax which is the product of subTotal and the sales tax rate
                return salesTaxRate * SubTotal;
            }
        }

        // read-only property to get the Total cost of the quote
        public double Total
        {
            get
            {
                // Total is the sales tax plus the sub total
                return SalesTax + SubTotal;
            }
        }

        // read ony property to get the amount due for the quote
        public double AmountDue
        {
            get
            {
                // amount due equals the total less the trade In Value
                return Total - tradeInValue;
            }
        }
        /// <summary>
        /// Constructs a sales quote
        /// </summary>
        /// <param name="vehicleSalePrice">sale price of the vehicle</param>
        /// <param name="tradeInValue">trade in value of the vehicle</param>
        /// <param name="salesTaxRate">the sales tax rate for this sale (harmonized)</param>
        /// <param name="accessoriesChosen">the accessories chosen for this vehicle</param>
        /// <param name="exteriorFinshChosen">The exterior finish chosen for this vehicle</param>
        public SalesQuote(double vehicleSalePrice, 
                          double tradeInValue, 
                          double salesTaxRate, 
                          Accessories accessoriesChosen, 
                          ExteriorFinish exteriorFinshChosen)
        {
            this.vehicleSalePrice = vehicleSalePrice;
            this.tradeInValue = tradeInValue;
            this.salesTaxRate = salesTaxRate;
            this.accessoriesChosen = accessoriesChosen;
            this.exteriorFinishChosen = exteriorFinshChosen;
        }
    }
}
