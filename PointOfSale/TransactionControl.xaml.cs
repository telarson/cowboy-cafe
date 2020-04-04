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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {

        private double total = 0.00;

        public TransactionControl()
        {
            InitializeComponent();

            CreditButton.Click += OnCreditButtonClicked;

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
                receipt += "Order " + order.OrderNumber + '\n';
                receipt += DateTime.Now.ToString() + '\n';
                foreach(IOrderItem item in order.Items)
                {
                    receipt += item.ToString() + ' ' + item.Price + '\n';
                    foreach(string instruction in item.SpecialInstructions)
                    {
                        receipt += instruction + '\n';
                    }
                }
                receipt += string.Format("Subtotal:   {0:C}\nTax:        {1:C}\nTotal:      {2:C}\n", order.Subtotal, order.Subtotal * 0.16, order.Subtotal * 1.16);
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
                string CreditReceipt = CreateReceipt() + "\nCREDIT";
                var receiptPrinter = new ReceiptPrinter();
                receiptPrinter.Print(CreditReceipt);
            }
            else
            {
                MessageBox.Show(transtactionResult.ToString());
            }
        } 
    }
}
