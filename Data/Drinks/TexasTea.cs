/* TexasTea.cs
 * Author: Tristan Larson
 * Class for the Texas Tea drink,
 * inherits from Drink.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class for the Texas Tea drink item
    /// </summary>
    public class TexasTea : Drink
    {
        private bool sweet = true;
        /// <summary>
        /// Flag for making the Tea sweet
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                sweet = value;
                NotifyPropertyChange("Sweet");
            }
        }

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
        /// Property that returns price of tea based on size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Property that returns the Calories in the tea based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        /// <summary>
        /// Property that returns the special instructions for the tea
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
        /// <returns>The item size, sweet type, and name.</returns>
        public override string ToString()
        {
            string item;

            if(Sweet) { item = $"{Size} Texas Sweet Tea"; }
            else { item = $"{Size} Texas Plain Tea"; }

            return item;
        }
    }
}
