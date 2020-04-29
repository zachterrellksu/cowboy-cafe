/*

* Author: Zachary Terrell 

* Class name: IOrderItem.cs

* Purpose: Represents an order item

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents a single item in an order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The Calories in the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions for the order item
        /// </summary>
        List<string> SpecialInstructions { get;}
    }
}
