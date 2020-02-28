/* Order.cs
 * Author: Tristan Larson
 * Class to represent an order at the cowboy cafe
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent an order.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Event to be raised when bound properties change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// static uint to track the order number.
        /// </summary>
        static uint lastOrderNumber = 0;

        /// <summary>
        /// Private list of the items in the order.
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// IEnumerable to access the items of the order
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// Private backing variable for the subtotal
        /// </summary>
        private double subtotal;
        /// <summary>
        /// Returns the subtotal for the current order.
        /// </summary>
        public double Subtotal
        {
            get
            {
                subtotal = 0.00;
                foreach(IOrderItem o in this.Items)
                {
                    subtotal += o.Price;
                }
                return subtotal;
            }


        }

        /// <summary>
        /// Current order number
        /// </summary>
        public uint OrderNumber { get { return ++lastOrderNumber; } }

        /// <summary>
        /// Adds items to order
        /// </summary>
        /// <param name="item">IOrderItem to add</param>
        public void Add (IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Remove an item from the order
        /// </summary>
        /// <param name="item">IOrderItem to remove</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}