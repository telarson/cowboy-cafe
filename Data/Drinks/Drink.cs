/* Drink.cs
 * Author: Tristan Larson
 * Abstract class representing a Drink
 * that includes Size, Price, Calories, Ice,
 * and Special Instructions.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstract Class for Drinks
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Price of the drink
        /// </summary>
        public abstract double Price { get;}

        /// <summary>
        /// Calories in the drink.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Flag for Ice in the drink
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// List of special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
