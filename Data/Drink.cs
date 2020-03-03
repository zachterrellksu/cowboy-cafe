/*

* Author: Zachary Terrell 

* Class name: Drink.cs

* Purpose: Represents the base class of the drink

*/

using System;
using System.Collections.Generic;
using System.Text;


namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents the base class of the drink
    /// </summary>
    public abstract class Drink: IOrderItem
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the Calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets and sets the size of the drink
        /// </summary>
        public virtual Size Size{ get; set; } = Size.Small;

        /// <summary>
        /// Gets and sets whether or not the drink has ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// The special instructions for making the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get;}
    }
}
