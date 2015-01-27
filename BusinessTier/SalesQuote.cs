using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    public class SalesQuote
    {
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

        public static class Accessory
        {
            public const double STEREO_SYSTEM = 505.05;
            public const double LEATHER_INTERIOR = 1010.10;
            public const double COMPUTER_NAVIGATION = 1515.15;
        }

        public enum ExteriorFinish
        {
            None,
            Standard,
            Pearlized,
            Custom
        }

        public static class Finish
        {
            public const double STANDARD = 0;
            public const double PEARLIZED = 404.04;
            public const double CUSTOM = 606.06;
        }
        private double vehicleSalePrice;
        private double tradeInValue;
        private double salesTaxRate;
        private Accessories AccessoriesChosen;
        private ExteriorFinish exteriorFinishChosen;
        public double AccessoryCost
        {
            get
            {
                double cost = 0;

                switch (AccessoriesChosen)
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

                return cost; 
            }
        }

        public double FinishCost
        {
            get
            {
                double cost = 0;
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
                return cost;
            }
        }

        public double SubTotal
        {
            get
            {
                return (vehicleSalePrice + AccessoryCost + FinishCost);
            }
        }

        public double SalesTax
        {
            get
            {
                return salesTaxRate * SubTotal;
            }
        }

        public double Total
        {
            get
            {
                return SalesTax + SubTotal;
            }
        }

        public double AmountDue
        {
            get
            {
                return Total - tradeInValue;
            }
        }
        public SalesQuote(double vehicleSalePrice, double tradeInValue, double salesTaxRate, Accessories accessoriesChosen, ExteriorFinish exteriorFinshChosen)
        {
            this.vehicleSalePrice = vehicleSalePrice;
            this.tradeInValue = tradeInValue;
            this.salesTaxRate = salesTaxRate;
            this.AccessoriesChosen = accessoriesChosen;
            this.exteriorFinishChosen = exteriorFinshChosen;
        }
    }
}
