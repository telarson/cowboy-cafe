/* IOrderItem.cs
 * Author: Tristan Larson
 * Iterface to allow any objects that could be part of an order to be treated in similar ways.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Interface for standardizing items that could be part of an order.
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Price of the item
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// Calories of the item
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// IEnumerable of special instructions for the item.
        /// </summary>
        public IEnumerable<string> SpecialInstructions { get; }
    }
}
