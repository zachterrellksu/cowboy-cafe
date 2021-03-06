﻿/*

* Author: Zachary Terrell 

* Class name: PecosPulledPork.cs

* Purpose: Represents the Pecos Pulled pork side

*/


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents the Pecos Pulled pork side
    /// </summary>
    public class PecosPulledPork: Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories in the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        private bool bread = true;
        /// <summary>
        /// If the entree should be served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set
            {
                bread = value;
                NotifyOfPropertyChange("Bread");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the entree should be served with a pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        /// <summary>
        /// The special instructions for making the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bread) { instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                return instructions;
            }
        }

        /// <summary>
        /// Displays item as a string
        /// </summary>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }


    }
}
