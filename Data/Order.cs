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
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private uint lastOrderNumber = 1;

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items => items.ToArray();

        private double subtotal;
        public double Subtotal
        {
            get
            {                
                return subtotal;
            }


        }

        public uint OrderNumber { get { return ++lastOrderNumber; } }

        public void Add (IOrderItem item)
        {
            items.Add(item);
            subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void Remove(IOrderItem item)
        {
            items.Remove(item);
            subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}