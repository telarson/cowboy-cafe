/* JerkedSoda.cs
 * Author: Tristan Larson
 * Class for the Jerked Soda drink,
 * inherits from Drink.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        private SodaFlavor flavor = SodaFlavor.CreamSoda;
        /// <summary>
        /// The flavor of the soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }

            set 
            { 
                flavor = value;
                NotifyPropertyChange("Flavor");
            }
        }

        /// <summary>
        /// Property that returns the price of the drink based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Property that returns the calories in a drink based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Property that returns a list of special instructions for the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Ice) { instructions.Add("Hold Ice"); }

                return instructions;
            }
        }

        /// <summary>
        /// ToString Override to print the items attributes. 
        /// </summary>
        /// <returns>The item size, flavor, and name.</returns>
        public override string ToString()
        {
            string item = "";

            switch (Flavor)
            {
                case SodaFlavor.BirchBeer:
                    item = $"{Size} Birch Beer Jerked Soda";
                    break;
                case SodaFlavor.CreamSoda:
                    item = $"{Size} Cream Soda Jerked Soda";
                    break;
                case SodaFlavor.OrangeSoda:
                    item = $"{Size} Orange Soda Jerked Soda";
                    break;
                case SodaFlavor.RootBeer:
                    item = $"{Size} Root Beer Jerked Soda";
                    break;
                case SodaFlavor.Sarsparilla:
                    item = $"{Size} Sarsparilla Jerked Soda";
                    break;
                default:
                    item = $"{Size} Jerked Soda";
                    break;
            }
            return item;
        }
    }
}
