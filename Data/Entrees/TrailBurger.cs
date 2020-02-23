/*Trailburger.cs
 * Author: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representation of the Trailburger entree
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// Price for the Trailburger entree
        /// </summary>
        public override double Price { get; } = 4.50;

        /// <summary>
        /// Calorie content for the Trailburger entree
        /// </summary>
        public override uint Calories { get; } = 288;

        /// <summary>
        /// Boolean flag for a Bun on the Trailburger
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Boolean flag for Ketchup on the Trailburger
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Boolean flag for Mustard on the Trailburger
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Boolean flag for Pickle on the Trailburger
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Boolean flag for Cheese on the Trailburger
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Special instructions for the Trailburger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bun) { instructions.Add("hold bun"); }
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if(!Mustard) { instructions.Add("hold mustard"); }
                if(!Cheese) { instructions.Add("hold cheese"); }
                if (!Pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }
        }

        /// <summary>
        /// Returns the Entree name.
        /// </summary>
        /// <returns>Trail Burger</returns>
        public override string ToString()
        {

            return "Trail Burger";
        }
    }
}
