/*DakotaDoubleBurger.cs
 * Author: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class for the DakotaDoubleBurger
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// Price of the DakotaDoubleBurger
        /// </summary>
        public override double Price { get; } = 5.20;

        /// <summary>
        /// Calorie content of the DakotaDoubleBurger
        /// </summary>
        public override uint Calories { get; } = 464;

        /// <summary>
        /// Boolean flag for a Bun on the DakotaDoubleBurger
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Boolean flag for Ketchup on the DakotaDoubleBurger
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Boolean flag for Mustard on the DakotaDoubleBurger
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Boolean flag for Pickle on the DakotaDoubleBurger
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Boolean flag for Cheese on the DakotaDoubleBurger
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Boolean flag for Tomato on the DakotaDoubleBurger
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Boolean flag for Lettuce on the DakotaDoubleBurger
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Boolean flag for Mayo on the DakotaDoubleBurger
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Special instructions for the DakotaDoubleBurger
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

                return instructions;
            }
        }
    }
}
