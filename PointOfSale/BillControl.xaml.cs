/*BillControl.xaml.cs
 * Author: Tristan Larson
 * Control for adding bills
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
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {
        public BillControl()
        {
            InitializeComponent();
            DecrementButton.Click += OnDecrementClicked;
            IncrementButton.Click += OnIncrementClicked;

        }

        /// <summary>
        /// Event for when the selected amount of a bill changes
        /// </summary>
        public event EventHandler AmountChanged;


        public static readonly DependencyProperty AmountProperty = DependencyProperty.Register(
            "Amount",
            typeof(int),
            typeof(BillControl),
            new PropertyMetadata()
            );
        /// <summary>
        /// The amount of this type of bill given
        /// </summary>
        public int Amount
        {
            get { return (int)GetValue(AmountProperty); }
            set { SetValue(AmountProperty, value); }
        }


        public static readonly DependencyProperty DenominationProperty = DependencyProperty.Register(
            "Denomination",
            typeof(Bills),
            typeof(BillControl),
            new PropertyMetadata(Bills.One)
            );

        /// <summary>
        /// The denomination of the Bill
        /// </summary>
        public Bills Denomination
        {
            get { return (Bills)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        /// <summary>
        /// Handles a click event for the DecrementButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDecrementClicked(object sender, RoutedEventArgs e)
        {
            Amount--;
            AmountChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Handles a click event for IncrementBUtton
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
