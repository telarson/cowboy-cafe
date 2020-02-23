/*ChiliCheeseFries.cs
 * Author: Tristan Larson
 * Class for the Chili Cheese Fries side, inherits from
 * the Side base class.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class Representing the Chili Cheese Fries entree
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// Property that returns the calories of the side based on it's size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Property that returns the Price of the side based on it's size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns the side size and name.
        /// </summary>
        /// <returns>{Size} Chili Cheese Fries</returns>
        public override string ToString()
        {
            return $"{Size} Chili Cheese Fries";
        }
    }
}
