/* Enrtree.cs
 * Author: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstact base class for Entrees
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Gets Price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets Calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets Special instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        IEnumerable<string> IOrderItem.SpecialInstructions => SpecialInstructions.ToArray();

    }
}
