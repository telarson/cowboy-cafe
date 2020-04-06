/*OrderSummaryControl.xaml.cs
 * Author: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Extensions;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();  
        }

        /// <summary>
        /// Removes the asscociated item from the order when the button next it is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnListItemRemoveItemButtonPressed(object sender, RoutedEventArgs e)
        {
            var ancestor = ExtensionMethods.FindAncestor<OrderControl>(sender as Button);
            
            if (sender is Button r)
            {
                if (r.DataContext is IOrderItem i)
                { 
                    if (ancestor.DataContext is Order o)
                    {
                        o.Remove(i);
                    }
                }
            }
        }

    }

}
