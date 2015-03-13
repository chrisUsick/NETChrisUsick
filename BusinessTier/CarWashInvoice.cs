using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    public class CarWashInvoice : Invoice
    {
        /// <summary>
        /// property storing the package cost of the invoice
        /// </summary>
        public double PackageCost { get; set; }

        /// <summary>
        /// property storing the fragrance cost of the invoice
        /// </summary>
        public double FragranceCost { get; set; }

        /// <summary>
        /// read only property which returns the PST charged
        /// </summary>
        public override double PSTCharged
        {
            get 
            {
                return SubTotal * PSTRate;
            }
        }

        /// <summary>
        /// read only property which returns the GST charged
        /// </summary>
        public override double GSTCharged
        {
            get
            {
                return SubTotal * GSTRate;
            }
        }

        /// <summary>
        /// read only property of the sub total of the invoice
        /// </summary>
        public override double SubTotal
        {
            get
            {
                return PackageCost + FragranceCost;
            }
        }
        
        /// <summary>
        /// read only property storing the total cost of the invoice
        /// </summary>
        public override double Total
        {
            get
            {
                return SubTotal + PSTCharged + GSTCharged;
            }
        }

        public CarWashInvoice(double pstRate, double gstRate)
            : base(pstRate, gstRate) { }

        public CarWashInvoice(double pstRate, double gstRate, double packageCost, double fragranceCost)
            : this(pstRate, gstRate)
        {
            PackageCost = packageCost;
            FragranceCost = fragranceCost;
        }
    }
}
