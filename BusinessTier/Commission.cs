using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    /// <summary>
    /// class to calculate a commission
    /// </summary>
    public static class Commission
    {
        // rate of employee with less than 10 years experience
        private const double JUNIOR_RATE = 0.02;

        // rate for 10-14 years experience
        private const double SENIOR_RATE = 0.05;

        // rate for 15 or more years of experience
        private const double EXECUTIVE_RATE = 0.1;

        // commission rate for adding options
        private const double OPTIONS_COMMISSIONS_RATE = 0.02;
        
        /// <summary>
        /// calculate the commission of a sale
        /// </summary>
        /// <param name="startDate">start date of employee</param>
        /// <param name="purchasePrice">price of the vehicle sale</param>
        /// <param name="optionsPrice">price of the options on the vehicle</param>
        /// <returns>price of commission</returns>
        public static double getCommission (DateTime startDate, double purchasePrice, double optionsPrice = 0)
        {
            double years = (DateTime.Now - startDate).TotalDays / 365.25;
            double pay = 0;
            // list of associated experience levels to pay rates
            List<double[]> rates = new List<double[]>();
            rates.AddRange(new[] {
                new[] {10, JUNIOR_RATE},
                new[] {15, SENIOR_RATE},
                new[] {double.PositiveInfinity, EXECUTIVE_RATE}
            });

            // loop through each rate
            foreach (double[] rate in rates)
            {
                if (years < rate[0])
                {
                    pay = purchasePrice * rate[1];

                    // exit the loop 
                    break;
                }
            }

            pay += optionsPrice * OPTIONS_COMMISSIONS_RATE;

            return pay;
        }
    }
}
