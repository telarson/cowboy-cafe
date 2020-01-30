/*AngryChicken.cs
 * Author: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken
    {
        /// <summary>
        /// The price of an Angry Chicken
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The caloric content of the Angry Chicken
        /// </summary>
        public uint Calories
        {
            get
            {
                return 190;
            }
        }

        private bool bread = true;
        /// <summary>
        /// Bool representing if the Angry Chicken should include bread
        /// </summary>
        public bool Bread
        {
            get
            {
                return bread;
            }

            set
            {
                bread = value;
            }
        }

        /// <summary>
        /// Bool representing if pickle is included with the Angry Chicken
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// List to store special instructions for the Angry Chicken
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
