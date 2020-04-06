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
using CashRegister;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {

        public TransactionControl()
        {
            InitializeComponent();

            CreditButton.Click += OnCreditButtonClicked;
            CashButton.Click += OnCashButtonClicked;
            CashControl.TotalChanged += OnTotalChanged;
            
        }

        private double tax;
        /// <summary>
        /// Gets the tax for the order.
        /// </summary>
        public double Tax
        {
            get
            {
                if (DataContext is Order o)
                {
                   tax = Math.Round(o.Subtotal * 0.16, 2);
                }

                return tax;
            }
        }


        private double total;
        /// <summary>
        /// Gets the Total for the order
        /// </summary>
        public double Total
        {
            get
            {
                if (DataContext is Order o)
                {
                   total = Math.Round(o.Subtotal + Tax, 2);
                }
                return total;
            }
        }

        /// <summary>
        /// Method to create a string representing the receipt for the current order.
        /// </summary>
        /// <returns>A string with the order number, date/time, items ordered, subtotal, tax, and total, each on thier own line. </returns>
        public string CreateReceipt()
        {
            string receipt = "\n";

            if(DataContext is Order order)
            {
                receipt += string.Format("Order {0}\n", order.OrderNumber);
                receipt += DateTime.Now.ToString() + '\n';
                foreach(IOrderItem item in order.Items)
                {
                    receipt += string.Format("{0}\t{1:C}\n", item.ToString(), item.Price);
                    foreach(string instruction in item.SpecialInstructions)
                    {
                        receipt += (string.Format("\t{0}\n", instruction));
                    }
                }
                receipt += string.Format("Subtotal:   {0:C}\nTax:        {1:C}\nTotal:      {2:C}\n", order.Subtotal, Tax, Total);
            }

            return receipt;
        }

        /// <summary>
        /// Handles the click event for the Credit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCreditButtonClicked(object sender, RoutedEventArgs e)
        {
            var cardProcessor = new CardTerminal();
            
            var transtactionResult = cardProcessor.ProcessTransaction(0);

            if(transtactionResult == ResultCode.Success)
            {
                MessageBox.Show("Success, printing receipt...");
                string CreditReceipt = CreateReceipt() + "\nCREDIT\n";
                var receiptPrinter = new ReceiptPrinter();
                receiptPrinter.Print(CreditReceipt);

                var orderControl = ExtensionMethods.FindAncestor<OrderControl>(this);
                orderControl.DataContext = new Order();
                orderControl.SwapScreen(new MenuItemSelectionControl());
            }
            else
            {
                MessageBox.Show(string.Format("{0}, please try again...",transtactionResult.ToString()));
            }
        }

        /// <summary>
        /// Enables the cash controls when the cash payment button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCashButtonClicked(object sender, RoutedEventArgs e)
        {
            CashPaymentBorder.IsEnabled = true; 
        }

        /// <summary>
        /// Calculates the change needed when the cash given is submitted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnTotalChanged(object sender, EventArgs e)
        {
            double change = 0.00;
            if(sender is CashRegisterControl CRC)
            {
                if (DataContext is Order o)
                {
                    change = Math.Round(Total - CRC.CashGiven, 2);
                }

                if (change < 0)
                {
                    MessageBox.Show(GetChangeReport(-change));
                    MessageBox.Show("Success, printing receipt...");
                    string CreditReceipt = CreateReceipt() + string.Format("\nCASH GIVEN: {0:C}\nCHANGE:\t{1:C}\n", CRC.CashGiven, - change);
                    var receiptPrinter = new ReceiptPrinter();
                    receiptPrinter.Print(CreditReceipt);

                    var orderControl = ExtensionMethods.FindAncestor<OrderControl>(this);
                    orderControl.DataContext = new Order();
                    orderControl.SwapScreen(new MenuItemSelectionControl());
                }
            }

            
        }

        /// <summary>
        /// Function to Generate a string of change to give based on the contents of the case drawer
        /// </summary>
        /// <param name="changeNeeded"></param>
        /// <returns></returns>
        public string GetChangeReport(double changeNeeded)
        {
            string ChangeReport = "Give this change:\n";

            if(changeNeeded >= 100.00 && OrderControl.CashDrawer.Hundreds > 0)
            {
                int BillsNeeded = 0;
                while (changeNeeded >= 100 && OrderControl.CashDrawer.Hundreds > 0)
                {
                    
                    changeNeeded -= 100;
                    BillsNeeded++;
                    OrderControl.CashDrawer.RemoveBill(Bills.Hundred, 1);
                }
                ChangeReport += string.Format("\n{0} Hundreds\n", BillsNeeded);             
            }

            if (changeNeeded >= 50.00 && OrderControl.CashDrawer.Fifties > 0)
            {
                int BillsNeeded = 0;
                while (changeNeeded >= 50 && OrderControl.CashDrawer.Fifties > 0)
                {
                    changeNeeded -= 50;
                    BillsNeeded++;
                    OrderControl.CashDrawer.RemoveBill(Bills.Fifty, 1);
                }
                ChangeReport += string.Format("\n{0} Fifties\n", BillsNeeded);   
            }

            if (changeNeeded >= 20.00 && OrderControl.CashDrawer.Twenties > 0)
            {
                int BillsNeeded = 0;
                while (changeNeeded >= 20 && OrderControl.CashDrawer.Twenties > 0)
                {
                    changeNeeded -= 20;
                    BillsNeeded++;
                    OrderControl.CashDrawer.RemoveBill(Bills.Twenty, 1);
                }
                ChangeReport += string.Format("\n{0} Twenties\n", BillsNeeded);   
            }

            if (changeNeeded >= 10.00 && OrderControl.CashDrawer.Tens > 0)
            {
                int BillsNeeded = 0;
                while (changeNeeded >= 10 && OrderControl.CashDrawer.Tens > 0)
                {
                    changeNeeded -= 10;
                    BillsNeeded++;
                    OrderControl.CashDrawer.RemoveBill(Bills.Ten, 1);
                }
                ChangeReport += string.Format("\n{0} Tens\n", BillsNeeded);               
            }

            if (changeNeeded >= 5.00 && OrderControl.CashDrawer.Fives > 0)
            {
                int BillsNeeded = 0;
                while (changeNeeded >= 5 && OrderControl.CashDrawer.Fives > 0)
                {
                    changeNeeded -= 5;
                    BillsNeeded++;
                    OrderControl.CashDrawer.RemoveBill(Bills.Five, 1);
                }
                ChangeReport += string.Format("\n{0} Fives\n", BillsNeeded);               
            }

            if (changeNeeded >= 2.00 && OrderControl.CashDrawer.Twos > 0)
            {
                int BillsNeeded = 0;
                while (changeNeeded >= 2 && OrderControl.CashDrawer.Twos > 0)
                {
                    changeNeeded -= 2;
                    BillsNeeded++;
                    OrderControl.CashDrawer.RemoveBill(Bills.Two, 1);
                }
                ChangeReport += string.Format("\n{0} Twos\n", BillsNeeded);                
            }

            if (changeNeeded >= 1.00 && OrderControl.CashDrawer.Ones > 0)
            {
                int BillsNeeded = 0;
                while (changeNeeded >= 1 && OrderControl.CashDrawer.Ones > 0)
                {
                    changeNeeded -= 1;
                    BillsNeeded++;
                    OrderControl.CashDrawer.RemoveBill(Bills.One, 1);
                }
                ChangeReport += string.Format("\n{0} Ones\n", BillsNeeded);              
            }

            if (changeNeeded >= 1.00 && OrderControl.CashDrawer.Dollars > 0)
            {
                int CoinsNeeded = 0;
                while (changeNeeded >= 1 && OrderControl.CashDrawer.Dollars > 0)
                {
                    changeNeeded -= 1;
                    CoinsNeeded++;
                    OrderControl.CashDrawer.RemoveCoin(Coins.Dollar, 1);
                }
                ChangeReport += string.Format("\n{0} Dollar Coins\n", CoinsNeeded);                
            }

            if (changeNeeded >= 0.50 && OrderControl.CashDrawer.HalfDollars > 0)
            {
                int CoinsNeeded = 0;
                while (changeNeeded >= 0.50 && OrderControl.CashDrawer.HalfDollars > 0)
                {
                    changeNeeded -= 0.50;
                    CoinsNeeded++;
                    OrderControl.CashDrawer.RemoveCoin(Coins.HalfDollar, 1);
                }
                ChangeReport += string.Format("\n{0} Half Dollars Coins\n", CoinsNeeded);               
            }

            if (changeNeeded >= 0.25 && OrderControl.CashDrawer.Quarters > 0)
            {
                int CoinsNeeded = 0;
                while (changeNeeded >= 0.25 && OrderControl.CashDrawer.Quarters > 0)
                {
                    changeNeeded -= 0.25;
                    CoinsNeeded++;
                    OrderControl.CashDrawer.RemoveCoin(Coins.Quarter, 1);
                }
                ChangeReport += string.Format("\n{0} Quarters\n", CoinsNeeded);
            }

            if (changeNeeded >= 0.10 && OrderControl.CashDrawer.Dimes > 0)
            {
                int CoinsNeeded = 0;
                while (changeNeeded >= 0.10 && OrderControl.CashDrawer.Dimes > 0)
                {
                    changeNeeded -= 0.10;
                    CoinsNeeded++;
                    OrderControl.CashDrawer.RemoveCoin(Coins.Dime, 1);
                }
                ChangeReport += string.Format("\n{0} Dimes\n", CoinsNeeded);
            }

            if (changeNeeded >= 0.05 && OrderControl.CashDrawer.Nickels > 0)
            {
                int CoinsNeeded = 0;
                while (changeNeeded >= 0.05 && OrderControl.CashDrawer.Nickels > 0)
                {
                    changeNeeded -= 0.05;
                    CoinsNeeded++;
                    OrderControl.CashDrawer.RemoveCoin(Coins.Nickel, 1);
                }
                ChangeReport += string.Format("\n{0} Nickels\n", CoinsNeeded);
            }

            if (changeNeeded >= 0.01 && OrderControl.CashDrawer.Pennies > 0)
            {
                int CoinsNeeded = 0;
                while (changeNeeded >= 0.01 && OrderControl.CashDrawer.Pennies > 0)
                {
                    changeNeeded -= 0.01;
                    CoinsNeeded++;
                    OrderControl.CashDrawer.RemoveCoin(Coins.Penny, 1);
                }
                ChangeReport += string.Format("\n{0} Pennies\n", CoinsNeeded);
            }

            if(changeNeeded > 0.01)
            {
                ChangeReport = "Can't make change...";
            }

            return ChangeReport;
        }

        
    }

    
}
