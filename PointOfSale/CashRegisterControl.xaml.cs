/*CashRegisterControl.xaml.cs
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
using CashRegister;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        public CashRegisterControl()
        {
            InitializeComponent();
            PennyControl.AmountChanged += OnAmountChanged;
            NickelControl.AmountChanged += OnAmountChanged;
            DimeControl.AmountChanged += OnAmountChanged;
            QuarterControl.AmountChanged += OnAmountChanged;
            HalfDollarControl.AmountChanged += OnAmountChanged;
            DollarControl.AmountChanged += OnAmountChanged;
            OneControl.AmountChanged += OnAmountChanged;
            TwoControl.AmountChanged += OnAmountChanged;
            FiveControl.AmountChanged += OnAmountChanged;
            TenControl.AmountChanged += OnAmountChanged;
            TwentyControl.AmountChanged += OnAmountChanged;
            FiftyControl.AmountChanged += OnAmountChanged;
            HundredControl.AmountChanged += OnAmountChanged;

            SubmitCashButton.Click += OnSubmitButtonClicked;
            SubmitCashButton.Click += OnAmountChanged;
        }

        /// <summary>
        /// Event to be thrown when the total cash given changes
        /// </summary>
        public event EventHandler TotalChanged;

        public static readonly DependencyProperty CashGivenProperty = DependencyProperty.Register(
            "CashGiven",
            typeof(double),
            typeof(CashRegisterControl),
            new PropertyMetadata()
            );
        /// <summary>
        /// The cash given by the customer
        /// </summary>
        public double CashGiven
        {
            get { return (double)GetValue(CashGivenProperty); }
            set { SetValue(CashGivenProperty, value); }
        }

        /// <summary>
        /// Event handler for when the amount of a bill or coin given changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAmountChanged(object sender, EventArgs e)
        {
            CashGiven = 0.00;

            foreach (object obj in CashControlGrid.Children)
            {
                if (obj is CoinControl c)
                {
                    switch (c.Denomination)
                    {
                        case Coins.Penny:
                            CashGiven += 0.01 * c.Amount;
                            break;
                        case Coins.Nickel:
                            CashGiven += 0.05 * c.Amount;
                            break;
                        case Coins.Dime:
                            CashGiven += 0.10 * c.Amount;
                            break;
                        case Coins.Quarter:
                            CashGiven += 0.25 * c.Amount;
                            break;
                        case Coins.HalfDollar:
                            CashGiven += 0.50 * c.Amount;
                            break;
                        case Coins.Dollar:
                            CashGiven += 1.00 * c.Amount;
                            break;
                    }
                }
                else if (obj is BillControl b)
                {
                    switch (b.Denomination)
                    {
                        case Bills.One:
                            CashGiven += 1.00 * b.Amount;
                            break;
                        case Bills.Two:
                            CashGiven += 2.00 * b.Amount;
                            break;
                        case Bills.Five:
                            CashGiven += 5.00 * b.Amount;
                            break;
                        case Bills.Ten:
                            CashGiven += 10.00 * b.Amount;
                            break;
                        case Bills.Twenty:
                            CashGiven += 20.00 * b.Amount;
                            break;
                        case Bills.Fifty:
                            CashGiven += 50.00 * b.Amount;
                            break;
                        case Bills.Hundred:
                            CashGiven += 100.00 * b.Amount;
                            break;
                    }
                }
            }

            if(DataContext is Order order)
            {
                if (CashGiven >= Math.Round(order.Subtotal * 1.16, 2))
                {
                    SubmitCashButton.IsEnabled = true;
                }
            }

        }

        /// <summary>
        /// Event handler for when the submit button for cash transactions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            TotalChanged?.Invoke(this, new EventArgs());           

            foreach (object obj in CashControlGrid.Children)
            {
                if (obj is CoinControl c)
                {
                    switch (c.Denomination)
                    {
                        case CashRegister.Coins.Penny:
                            OrderControl.CashDrawer.AddCoin(CashRegister.Coins.Penny, c.Amount);
                            c.Amount = 0;
                            break;
                        case CashRegister.Coins.Nickel:
                            OrderControl.CashDrawer.AddCoin(CashRegister.Coins.Nickel, c.Amount);
                            c.Amount = 0;
                            break;
                        case CashRegister.Coins.Dime:
                            OrderControl.CashDrawer.AddCoin(CashRegister.Coins.Dime, c.Amount);
                            c.Amount = 0;
                            break;
                        case CashRegister.Coins.Quarter:
                            OrderControl.CashDrawer.AddCoin(CashRegister.Coins.Quarter, c.Amount);
                            c.Amount = 0;
                            break;
                        case CashRegister.Coins.HalfDollar:
                            OrderControl.CashDrawer.AddCoin(CashRegister.Coins.HalfDollar, c.Amount);
                            c.Amount = 0;
                            break;
                        case CashRegister.Coins.Dollar:
                            OrderControl.CashDrawer.AddCoin(CashRegister.Coins.Dollar, c.Amount);
                            c.Amount = 0;
                            break;
                    }
                }
                else if (obj is BillControl b)
                {
                    switch (b.Denomination)
                    {
                        case CashRegister.Bills.One:
                            OrderControl.CashDrawer.AddBill(CashRegister.Bills.One, b.Amount);
                            b.Amount = 0;
                            break;
                        case CashRegister.Bills.Two:
                            OrderControl.CashDrawer.AddBill(CashRegister.Bills.Two, b.Amount);
                            b.Amount = 0;
                            break;
                        case CashRegister.Bills.Five:
                            OrderControl.CashDrawer.AddBill(CashRegister.Bills.Five, b.Amount);
                            b.Amount = 0;
                            break;
                        case CashRegister.Bills.Ten:
                            OrderControl.CashDrawer.AddBill(CashRegister.Bills.Ten, b.Amount);
                            b.Amount = 0;
                            break;
                        case CashRegister.Bills.Twenty:
                            OrderControl.CashDrawer.AddBill(CashRegister.Bills.Twenty, b.Amount);
                            b.Amount = 0;
                            break;
                        case CashRegister.Bills.Fifty:
                            OrderControl.CashDrawer.AddBill(CashRegister.Bills.Fifty, b.Amount);
                            b.Amount = 0;
                            break;
                        case CashRegister.Bills.Hundred:
                            OrderControl.CashDrawer.AddBill(CashRegister.Bills.Hundred, b.Amount);
                            b.Amount = 0;
                            break;
                    }
                }
            }
        }
    }
}
