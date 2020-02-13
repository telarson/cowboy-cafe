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
    public class AngryChicken : Entree
    {
        /// <summary>
        /// The price of an Angry Chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The caloric content of the Angry Chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Bool representing if the Angry Chicken should include bread
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// Bool representing if pickle is included with the Angry Chicken
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// List to store special instructions for the Angry Chicken
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
    }
}
