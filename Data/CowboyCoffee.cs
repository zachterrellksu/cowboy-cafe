using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
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

        public bool RoomForCream { get; set; } = false;

        public bool Decaf { get; set; } = false;

        public override List<string> SpecialInstructions
        {
            get 
            { 
                List<string> instructions = new List<string>();
                if(Decaf) { instructions.Add("Add Ice"); }
                if (RoomForCream) { instructions.Add("Room for Cream"); }
                return instructions;
            }
        }
    }
}
