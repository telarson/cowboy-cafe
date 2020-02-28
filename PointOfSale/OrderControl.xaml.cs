/*OrderControl.cs
 * Author: Tristan Larson
 * Contains event handlers and logic for the buttons in the OrderControl.
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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {

        public OrderControl()
        {
            InitializeComponent();


            this.DataContext = new Order();

            CompleteOrderButton.Click += OnCompleteOrderButton;
            CancelOrderButton.Click += OnCancelOrderButton;
        }

        /// <summary>
        /// Event handler for the ItemSelectionButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnItemSelectionButton(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Event handler for CancelOrderButton, creates a new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCancelOrderButton(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Event handler for the CompleteOrderButton, creates a new order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCompleteOrderButton(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }


    }
}
