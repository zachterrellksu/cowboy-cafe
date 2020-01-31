using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories in the pulled pork
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// If the entree should be served with bread
        /// </summary>
        public bool Bread { get; set; } = true;

        private bool pickle = true;
        /// <summary>
        /// If the entree should be served with a pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// The special instructions for making the entree
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bread) { instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                return instructions;
            }
        }



    }
}
