/*

* Author: Zachary Terrell 

* Class name: Order.cs

* Purpose: Represents an order

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents an order
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// Holds items in order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Holds last order number
        /// </summary>
        private static uint lastOrderNumber = 1;

        /// <summary>
        /// Current Order number
        /// </summary>
        public uint OrderNumber
        {
            get
            {
                return lastOrderNumber++;
            }
        }

        /// <summary>
        /// The Items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();
        
        /// <summary>
        /// Current subtotal of order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double sub = 0;
                foreach(IOrderItem item in items)
                {
                    sub += item.Price;
                }
                return sub;
            }
        }

        /// <summary>
        /// Event handler for property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Adds to items
        /// </summary>
        /// <param name="item">Item being added</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Removes from items
        /// </summary>
        /// <param name="item">Item being removed</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
