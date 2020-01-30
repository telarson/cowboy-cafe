/*PecosPulledPork.cs
 * Author: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Representation of the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork
    {
        /// <summary>
        /// Price for the Pecos Pulled Pork entree
        /// </summary>
        public double Price { get; } = 5.88;

        /// <summary>
        /// Calorie content for the Pecos Pulled Pork entree
        /// </summary>
        public uint Calories { get; } = 528;

        /// <summary>
        /// Boolean flag for Bread on the Pecos Pulled Pork entree
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// Boolean flag for pickles on the Pecos Pulled Pork entree
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Special instructions for the Pecos Pulled Pork entree
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
