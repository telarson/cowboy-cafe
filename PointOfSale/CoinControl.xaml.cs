/* CoinControl.xaml.cs
 * Author: Tristan Larson
 * Control for recieving coins
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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {
        public CoinControl()
        {
            InitializeComponent();
            DecrementButton.Click += OnDecrementClicked;
            IncrementButton.Click += OnIncrementClicked;

        }

        /// <summary>
        /// Event to be invoked when the amount of a coin given changes
        /// </summary>
        public event EventHandler AmountChanged;

        public static readonly DependencyProperty AmountProperty = DependencyProperty.Register(
            "Amount",
            typeof(int),
            typeof(CoinControl),
            new PropertyMetadata()
            );
        /// <summary>
        /// The amount of a coin given
        /// </summary>
        public int Amount
        {
            get { return (int)GetValue(AmountProperty); }
            set { SetValue(AmountProperty, value); }
        }

        public static readonly DependencyProperty DenominationProperty = DependencyProperty.Register(
            "Denomination",
            typeof(Coins),
            typeof(CoinControl),
            new PropertyMetadata(Coins.Nickel)
            );

        /// <summary>
        /// The denomination of the coin
        /// </summary>
        public Coins Denomination
        {
            get { return (Coins)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        /// <summary>
        /// Handles clcking the button to decrement the coin amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDecrementClicked(object sender, RoutedEventArgs e)
        {
            Amount--;
            AmountChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Handles clicking the button to increment the coin amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnIncrementClicked(object sender, RoutedEventArgs e)
        {
            Amount++;
            AmountChanged?.Invoke(this, new EventArgs());
        }
    }
}
