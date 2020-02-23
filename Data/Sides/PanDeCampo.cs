/* PanDeCampo.cs
 * Author: Tristan Larson
 * Class for the Pan de Campo side.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents a side of Pan de Campo
    /// </summary>
    public class PanDeCampo : Side
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
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
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
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns the side size and name.
        /// </summary>
        /// <returns>{Size} Pan De Campos</returns>
        public override string ToString()
        {
            return $"{Size} Pan de Campo";
        }
    }
}
