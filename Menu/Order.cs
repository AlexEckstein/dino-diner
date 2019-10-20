using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// Public property holding Items for order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items{ get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// Constructor for Order
        /// </summary>
        public Order()
        {

        }

        /// <summary>
        /// Holds the summed cost of the items in the order without tax.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotalCost = 0;
                foreach (IOrderItem i in Items)
                {
                    subtotalCost += i.Price;
                }
                if (subtotalCost < 0)
                    subtotalCost = 0;
                return subtotalCost;
            }
        }

        /// <summary>
        /// Tax Rate for sale
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// Sale Tax Total cost
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// Total cost of the order 
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
