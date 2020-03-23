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

        /// <summary>
        /// Gets if the flavor is Birch Beer
        /// </summary>
        public bool BirchBeer
        {
            get
            {
                if (Flavor == SodaFlavor.BirchBeer)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value)
                {
                    Flavor = SodaFlavor.BirchBeer;
                    NotifyOfFlavorChange();
                }
            }
        }

        /// <summary>
        /// Gets if the flavor is Cream Soda
        /// </summary>
        public bool CreamSoda
        {
            get
            {
                if (Flavor == SodaFlavor.CreamSoda)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value)
                {
                    Flavor = SodaFlavor.CreamSoda;
                    NotifyOfFlavorChange();
                }
            }
        }

        /// <summary>
        /// Gets if the flavor is Orange Soda
        /// </summary>
        public bool OrangeSoda
        {
            get
            {
                if (Flavor == SodaFlavor.OrangeSoda)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value)
                {
                    Flavor = SodaFlavor.OrangeSoda;
                    NotifyOfFlavorChange();
                }
            }
        }

        /// <summary>
        /// Gets if the flavor is Root Beer
        /// </summary>
        public bool RootBeer
        {
            get
            {
                if (Flavor == SodaFlavor.RootBeer)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value)
                {
                    Flavor = SodaFlavor.RootBeer;
                    NotifyOfFlavorChange();
                }
            }
        }

        /// <summary>
        /// Gets if the flavor is Sarsaparilla
        /// </summary>
        public bool Sarsparilla
        {
            get
            {
                if (Flavor == SodaFlavor.Sarsparilla)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value)
                {
                    Flavor = SodaFlavor.Sarsparilla;
                    NotifyOfFlavorChange();
                }
            }
        }

        /// <summary>
        /// Displays item as a string
        /// </summary>
        public override string ToString()
        {
            switch (Flavor) {
                case SodaFlavor.BirchBeer:
                    return $"{Size} Birch Beer Jerked Soda";
                case SodaFlavor.CreamSoda:
                    return $"{Size} Cream Soda Jerked Soda";
                case SodaFlavor.OrangeSoda:
                    return $"{Size} Orange Soda Jerked Soda";
                case SodaFlavor.RootBeer:
                    return $"{Size} Root Beer Jerked Soda";
                case SodaFlavor.Sarsparilla:
                    return $"{Size} Sarsparilla Jerked Soda";
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
