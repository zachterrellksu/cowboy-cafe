using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        public bool Lemon { get; set; } = true;

        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) { instructions.Add("Hold Ice"); }
                if (Lemon) { instructions.Add("Add lemon"); }
                return instructions;
            }
        }
    }
}
