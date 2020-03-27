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
            ItemSelectionButton.Click += OnItemSelectionButton;

            OrderSummaryControl.OrderItemList.SelectionChanged += OnListItemSelection;
            
        }

        /// <summary>
        /// Swaps the content shown in Container with the given UIElement
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        /// <summary>
        /// Event handler for the ItemSelectionButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnItemSelectionButton(object sender, RoutedEventArgs e)
        {
            SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Event handler for CancelOrderButton, creates a new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCancelOrderButton(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Event handler for the CompleteOrderButton, creates a new order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCompleteOrderButton(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            SwapScreen(new MenuItemSelectionControl());
        }


        /// <summary>
        /// Eventhandler that opens a customization screen for the selected item in the 
        /// OrderSummaryControl's ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnListItemSelection(object sender, RoutedEventArgs e)
        {
            
            if (sender is ListBox lb)
            {
                IOrderItem selected = lb.SelectedItem as IOrderItem;

                //this.DataContext = sender as IOrderItem;
                if (selected is Entree)
                {
                    SwapScreen(new CustomizeEntree(selected));
                }
                else if (selected is Drink)
                {
                    SwapScreen(new CustomizeDrink(selected));
                }
                else if (selected is Side)
                {
                    //this.DataContext = selected;
                    var sideCustomizer = new CustomizeSide();
                    sideCustomizer.DataContext = selected;
                    SwapScreen(sideCustomizer);
                }
            }
        }

        void OnListItemRemoveItemButtonPressed(object sender, RoutedEventArgs e)
        {

        }

    }
}
