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

        public event EventHandler AmountChanged;

        public static readonly DependencyProperty AmountProperty = DependencyProperty.Register(
            "Amount",
            typeof(int),
            typeof(CoinControl),
            new PropertyMetadata()
            );

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

        public void OnDecrementClicked(object sender, RoutedEventArgs e)
        {
            Amount--;
            AmountChanged?.Invoke(this, new EventArgs());
        }

        public void OnIncrementClicked(object sender, RoutedEventArgs e)
        {
            Amount++;
            AmountChanged?.Invoke(this, new EventArgs());
        }
    }
}
