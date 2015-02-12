using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    abstract class Invoice
    {
        /// <summary>
        /// read only property to get the PST applied to this sale
        /// </summary>
        public double PSTRate { get; private set; }

        /// <summary>
        /// read-only property to get the GST applied to this sale
        /// </summary>
        public double GSTRate { get; private set; }

        /// <summary>
        /// read only property storing the amount of PST charged
        /// </summary>
        public abstract double PSTCharged
        {
            get;
        }

        /// <summary>
        /// read only property storing the amount of GST charged
        /// </summary>
        public abstract double GSTCharged
        {
            get;
        }

        /// <summary>
        /// read only property storing the subTotal of this invoice
        /// </summary>
        public abstract double SubTotal
        {
            get;
        }

        /// <summary>
        /// read only property to store the total cost of this invoice
        /// </summary>
        public abstract double Total
        {
            get;
        }

        /// <summary>
        /// constructs an invoice, sets the tax rates
        /// </summary>
        /// <param name="pstRate">PST to apply to the invoice</param>
        /// <param name="gstRate">GST to apply to the invoice</param>
        public Invoice(double pstRate, double gstRate)
        {
            //set this objects PST and GST rate
            this.PSTRate = pstRate;
            this.GSTRate = gstRate;
        }       
    }
}
