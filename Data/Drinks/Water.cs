/* Water.cs
 * Author: Tristan Larson
 * Class for the Water drink,
 * inherits from Drink.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {

        private bool lemon = false;
        /// <summary>
        /// Flag for adding a lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }

            set
            {
                lemon = value;
                NotifyPropertyChange("Lemon");
            }
        }

        /// <summary>
        /// Property that returns the price of a water
        /// </summary>
        public override double Price
        {
            get { return 0.12;}
        }

        /// <summary>
        /// Property that returns the calories in a water
        /// </summary>
        public override uint Calories
        {
            get { return 0; }
        }

        /// <summary>
        /// Property that returns the list of special instructions for the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Ice) { instructions.Add("Hold Ice"); }
                if (Lemon) { instructions.Add("Add Lemon"); }

                return instructions;
            }
        }

        /// <summary>
        /// ToString Override to print the items attributes. 
        /// </summary>
        /// <returns>The item size and name.</returns>
        public override string ToString()
        {
            return $"{Size} Water";
        }
    }
}
