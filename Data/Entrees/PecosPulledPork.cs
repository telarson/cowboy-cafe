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
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// Price for the Pecos Pulled Pork entree
        /// </summary>
        public override double Price { get; } = 5.88;

        /// <summary>
        /// Calorie content for the Pecos Pulled Pork entree
        /// </summary>
        public override uint Calories { get; } = 528;

        private bool bread = true;
        /// <summary>
        /// Boolean flag for Bread on the Pecos Pulled Pork entree
        /// </summary>
        public bool Bread
        {
            get { return bread; }

            set
            {
                bread = value;
                NotifyPropertyChange("Bread");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// Boolean flag for pickles on the Pecos Pulled Pork entree
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                NotifyPropertyChange("Pickle");
            }
        }

        /// <summary>
        /// Special instructions for the Pecos Pulled Pork entree
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
        /// Returns the Entree name.
        /// </summary>
        /// <returns>Pecos Pulled Pork</returns>
        public override string ToString()
        {

            return "Pecos Pulled Pork";
        }
    }
}
