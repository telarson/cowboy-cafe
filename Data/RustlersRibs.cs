/*RustlersRibs.cs
 * Author: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Rustlers Ribs menu entree
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the rustlers ribs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The caloric content of the ribs
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// List to store special instructions for the Ribs
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

    }
}
