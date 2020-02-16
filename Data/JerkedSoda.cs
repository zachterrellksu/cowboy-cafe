/*

* Author: Zachary Terrell 

* Class name: JerkedSoda.cs

* Purpose: Represents the Jerked Soda drink

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents the Jerked Soda drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// Represents the flavor of the drink
        /// </summary>
        public SodaFlavor Flavor { get; set; }

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
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
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
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The special instructions for making the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) { instructions.Add("Hold Ice"); }
                return instructions;
            }
        }

    }
}
