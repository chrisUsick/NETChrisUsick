using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    public class ServiceInvoice : Invoice
    {
        /// <summary>
        /// the different types of cost to add
        /// </summary>
        public enum CostType
        {
            Labour,
            Part,
            Material
        }

        /// <summary>
        /// the cost of labour for this invoice
        /// </summary>
        public double LabourCost { get; private set; }

        /// <summary>
        /// the cost of parts for this invoice
        /// </summary>
        public double PartsCost { get; private set; }

        /// <summary>
        /// the cost of materials for this invoice
        /// </summary>
        public double MaterialCost { get; private set; }

        /// <summary>
        /// read only propertythe PST charged on this invoice
        /// </summary>
        public override double PSTCharged
        {
            get 
            {
                return (MaterialCost + PartsCost) * PSTRate;
            }
        }

        /// <summary>
        /// read only property the GST charged on this invoice
        /// </summary>
        public override double GSTCharged
        {
            get 
            {
                return SubTotal * GSTRate;
            }
        }

        /// <summary>
        /// read only property sub total of the invoice
        /// </summary>
        public override double SubTotal
        {
            get 
            {
                // return the sum of all costs
                return LabourCost + MaterialCost + PartsCost;
            }
        }

        /// <summary>
        /// read only property to return the total cost (subtotal plus taxes)
        /// </summary>
        public override double Total
        {
            get 
            {
                // return the subtotal and tax
                return SubTotal + PSTCharged + GSTCharged;
            }
        }

        /// <summary>
        /// constructs A service invoice
        /// </summary>
        /// <param name="pstRate">the PST to apply</param>
        /// <param name="gstRate">the GST to apply</param>
        public ServiceInvoice(double pstRate, double gstRate)
            : base(pstRate, gstRate) { }


        /// <summary>
        /// add cost to the invoice
        /// </summary>
        /// <param name="costType">type of cost to add</param>
        /// <param name="cost">cost to add</param>
        public void AddCost(CostType costType, double cost)
        {
            switch (costType)
            {
                case CostType.Labour:
                    LabourCost += cost;
                    break;
                case CostType.Material:
                    MaterialCost += cost;
                    break;
                case CostType.Part:
                    PartsCost += cost;
                    break;
            }
        }
    }

    
}
