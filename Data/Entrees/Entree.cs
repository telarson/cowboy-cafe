/* Enrtree.cs
 * Author: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstact base class for Entrees
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        /// <summary>
        /// IEnumerable for special instrutions
        /// </summary>
        IEnumerable<string> IOrderItem.SpecialInstructions => SpecialInstructions.ToArray();

        /// <summary>
        /// Helper method for boolean prperty changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
