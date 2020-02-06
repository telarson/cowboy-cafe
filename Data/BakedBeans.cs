/* BakedBeans.cs
 * Author: Tristan Larson
 * Class for the baked beans side.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents a side of Baked Beans
    /// </summary>
    public class BakedBeans : Side
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
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
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
    }
}
