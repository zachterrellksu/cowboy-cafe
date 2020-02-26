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
        
        double Price { get; set; }

        /// <summary>
        /// Special instructions for the order item
        /// </summary>
        List<string> SpecialInstructions { get; set; }
    }
}
