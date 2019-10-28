using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Public property holding Items for order.
        /// </summary>
        public IOrderItem[] Items { get { return items.ToArray(); }  } 

        private List<IOrderItem> items;

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
        public double SalesTaxCost { get { return SalesTaxRate * SubtotalCost; } }

        /// <summary>
        /// Total cost of the order 
        /// </summary>
        public double TotalCost { get { return SubtotalCost + SalesTaxCost; } }

        /// <summary>
        /// Constructor for Order
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
        }
        
        private void OnPriceChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));

        }
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnPriceChanged;
            items.Add(item);
            OnPriceChanged(this, new EventArgs());
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnPriceChanged(this, new EventArgs());
        }


    }
}
