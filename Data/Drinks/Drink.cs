/* Drink.cs
 * Author: Tristan Larson
 * Abstract class representing a Drink
 * that includes Size, Price, Calories, Ice,
 * and Special Instructions.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstract Class for Drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing variable for Size
        /// </summary>
        private Size size;
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Price of the drink
        /// </summary>
        public abstract double Price { get;}

        /// <summary>
        /// Calories in the drink.
        /// </summary>
        public abstract uint Calories { get; }

        private bool ice = true;
        /// <summary>
        /// Flag for Ice in the drink
        /// </summary>
        public virtual bool Ice
        {
            get { return ice; }

            set
            {
                ice = value;
                NotifyPropertyChange("Ice");
            }
        }

        /// <summary>
        /// List of special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

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
