/*

* Author: Zachary Terrell 

* Class name: Water.cs

* Purpose: Represents the Water drink

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents the Water drink
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// The price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        /// <summary>
        /// The calories in the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// If the drink should contain lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The special instructions for making the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) { instructions.Add("Hold Ice"); }
                if (Lemon) { instructions.Add("Add Lemon"); }
                return instructions;
            }
        }
    }
}
