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
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddDakotaDoubleBurgerButton.Click += AddDakotaDoubleBurgerButtonClicked;
            AddAngryChickenButton.Click += AddAngryChickenButtonClicked;
        }

        /// <summary>
        /// Event handler for the AddCowpokeChili button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowpokeChili());
        }

        /// <summary>
        /// Event handler for the AddDakotaDoubleBurger button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Event handler for AddAngryChickenButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new AngryChicken());
        }
    }
}
