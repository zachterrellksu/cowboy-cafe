/*

* Author: Zachary Terrell 

* Class name: DakotaDoubleBurger.cs

* Purpose: Represents the Dakota Double Burger entree

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the dakota double entree
    /// </summary>
    public class DakotaDoubleBurger: Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// If the entree should be served with a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// If the entree should be served with ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// If the entree should be served with mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// If the entree should be served with pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If the entree should be served with cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// If the entree should be served with tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// If the entree should be served with lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// If the entree should be served with mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// The special instructions for making the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) { instructions.Add("hold bun"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if (!Mustard) { instructions.Add("hold mustard"); }
                if (!Cheese) { instructions.Add("hold cheese"); }
                if (!Tomato) { instructions.Add("hold tomato"); }
                if (!Lettuce) { instructions.Add("hold lettuce"); }
                if (!Mayo) { instructions.Add("hold mayo"); }
                return instructions;
            }
        }

    }
}
