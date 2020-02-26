﻿/* Order.cs
 * Author: Tristan Larson
 * Class to represent an order at the cowboy cafe
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        static uint lastOrderNumber = 0;

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items => items.ToArray();

        private double subtotal;
        /// <summary>
        /// 
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