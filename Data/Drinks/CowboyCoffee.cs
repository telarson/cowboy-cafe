/* CowboyCoffee.cs
 * Author: Tristan Larson
 * Class for the Cowboy Coffee drink,
 * inherits from Drink.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// Bool flag for leaving room for cream in the coffee
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Bool flag for putting ice in the coffee
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Flag to put Ice in coffee
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// Property to return the price of the coffee based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
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
        /// Property to return the Calories in the coffee based on size
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
        /// Property that returns a list of special instructions for the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (Ice) { instructions.Add("Add Ice"); }
                if (RoomForCream) { instructions.Add("Room for Cream"); }
                if (Decaf) { instructions.Add("Decaf"); }

                return instructions;
            }
        }

        public override string ToString()
        {
            string item;
            if (Decaf) { item = $"{Size} Decaf Cowboy Coffee";}
            else { item = $"{Size} Cowboy Coffee"; }

            return item;
        }
    }
}
