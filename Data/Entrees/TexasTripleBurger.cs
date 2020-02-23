/*TexasTripleBurger.cs
 * Author: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the TexasTripleBurger
    /// </summary>
    public class TexasTripleBurger : Entree
    {
        /// <summary>
        /// Price of the TexasTripleBurger
        /// </summary>
        public override double Price { get; } = 6.45;

        /// <summary>
        /// Calorie content of the TexasTripleBurger
        /// </summary>
        public override uint Calories { get; } = 698;

        /// <summary>
        /// Boolean flag for a Bun on the TexasTripleBurger
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Boolean flag for Ketchup on the TexasTripleBurger
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Boolean flag for Mustard on the TexasTripleBurger
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Boolean flag for Pickle on the TexasTripleBurger
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Boolean flag for Cheese on the TexasTripleBurger
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Boolean flag for Tomato on the TexasTripleBurger
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Boolean flag for Lettuce on the TexasTripleBurger
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Boolean flag for Mayo on the TexasTripleBurger
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Boolean flag for Bacon on the TexasTripleBurger
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Boolean flag for Egg on the TexasTripleBurger
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Special instructions for the TexasTripleBurger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bun) { instructions.Add("hold bun"); }
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if (!Mustard) { instructions.Add("hold mustard"); }
                if (!Cheese) { instructions.Add("hold cheese"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Tomato) { instructions.Add("hold tomato"); }
                if (!Lettuce) { instructions.Add("hold lettuce"); }
                if (!Mayo) { instructions.Add("hold mayo"); }
                if (!Bacon) { instructions.Add("hold bacon"); }
                if (!Egg) { instructions.Add("hold egg"); }

                return instructions;
            }
        }

        /// <summary>
        /// Returns the Entree name.
        /// </summary>
        /// <returns>Texas Triple Burger</returns>
        public override string ToString()
        {

            return "Texas Triple Burger";
        }


    }
}
