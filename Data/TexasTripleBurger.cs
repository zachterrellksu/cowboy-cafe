using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the texas triple entree
    /// </summary>
    public class TexasTripleBurger
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// If the entree should be served with a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// If the entree should be served with a bun
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// If the entree should be served with a bun
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// If the entree should be served with a bun
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If the entree should be served with a bun
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// If the entree should be served with a bun
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// If the entree should be served with a bun
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// If the entree should be served with a bun
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// If the entree should be served with a bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// If the entree should be served with a egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// The special instructions for making the entree
        /// </summary>
        public List<string> SpecialInstructions
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
                if (!Egg) { instructions.Add("hold egg"); }
                if (!Bacon) { instructions.Add("hold bacon"); }
                return instructions;
            }
        }
    }
}
