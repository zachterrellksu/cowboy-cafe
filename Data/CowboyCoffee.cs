/*

* Author: Zachary Terrell 

* Class name: CowboyCoffee.cs
* 
* Purpose: Represents the Cowboy Coffee drink

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// The price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return .60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories in the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// If the drink should contain room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// If the drink should contain ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// If the drink should be decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// The special instructions for making the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get 
            { 
                List<string> instructions = new List<string>();
                if(Ice) { instructions.Add("Add Ice"); }
                if (RoomForCream) { instructions.Add("Room for Cream"); }
                return instructions;
            }
        }
    }
}
