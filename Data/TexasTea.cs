﻿/*

* Author: Zachary Terrell 

* Class name: TexasTea.cs

* Purpose: Represents the Texas Tea drink

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents the Texas Tea drink
    /// </summary>
    public class TexasTea : Drink
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
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private bool sweet = true;
        /// <summary>
        /// If the tea should be sweet or not
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                NotifyOfPropertyChange("Sweet");
            }
        }


        /// <summary>
        /// The calories in the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        private bool lemon = false;
        /// <summary>
        /// If the drink should contain lemon
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
                NotifyOfPropertyChange("Lemon");
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
                if (Lemon) { instructions.Add("Add Lemon"); }
                return instructions;
            }
        }

        /// <summary>
        /// Displays item as a string
        /// </summary>
        public override string ToString()
        {
            if (Sweet)
            {
                return $"{Size} Texas Sweet Tea";
            }

            else
            {
                return $"{Size} Texas Plain Tea";
            }
        }
    }
}
