/*

* Author: Zachary Terrell 

* Class name: TransactionCOntrol.xaml.cs

* Purpose: Backend for TransactionControl
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
using CowboyCafe.Extensions;
using CashRegister;
using System.Threading;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        /// <summary>
        /// 0-arg constructor
        /// </summary>
        public TransactionControl(CashDrawer d)
        {
            InitializeComponent();
            drawer = d;
        }

        CashDrawer drawer;

        /// <summary>
        /// Indicates if the customer used Credit
        /// </summary>
        public bool UsedCredit { get; set; }

        /// <summary>
        /// Indicates if the customer used Cash
        /// </summary>
        public bool UsedCash { get; set; }

        /// <summary>
        /// CLick event for cash button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCashButtonClicked(object sender, RoutedEventArgs e)
        {
            UsedCash = true;
            if (DataContext is Order data)
            {
                var screen = new CashRegisterControl(drawer, data);
                MainTransactionControl.Child = screen;
                PrintReciept(data);
            }
        }

        /// <summary>
        /// Click event for credit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CreditButtonClicked(object sender, RoutedEventArgs e)
        {
            UsedCredit = true;
            Cash.IsEnabled = false;

            CardOutput.Items.Add("Reading Card....");
            var terminal = new CardTerminal();
            if(DataContext is Order data)
            {
                ResultCode result = terminal.ProcessTransaction(data.Total);
                if(result == ResultCode.Success)
                {
                    CardOutput.Items.Add("Card Read Success");
                    CancelOrder.IsEnabled = false;
                    Credit.IsEnabled = false;
                    PrintAndContinue.IsEnabled = true;
                }
                else
                {
                    CardOutput.Items.Add("Error. Please try again or use a different form of payment.");
                    Cash.IsEnabled = true;
                }
            }
        }

        /// <summary>
        /// Click event of cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderClick(object sender, RoutedEventArgs e)
        {
            var screen = new OrderControl();
            MainTransactionControl.Child = screen;
        }

        /// <summary>
        /// Click event of print button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPrintButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                PrintReciept(data);
                var screen = new OrderControl();
                MainTransactionControl.Child = screen;
            }
        }

        private void PrintReciept(Order data)
        {
            ReceiptPrinter printer = new ReceiptPrinter();
            
            printer.Print(Convert.ToString("Order #" + data.OrderNumber + "\n"));
            printer.Print(Convert.ToString(DateTime.Now + "\n"));
            foreach (IOrderItem item in data.Items)
            {
                printer.Print(item.ToString() + " - ");
                printer.Print(Convert.ToString(item.Price + "\n"));
                foreach (string i in item.SpecialInstructions)
                {
                    printer.Print(i + "\n");
                }
                printer.Print("\n");
            }
            printer.Print("\n");

            var s = Math.Round(data.Total, 2);
            printer.Print("Subtotal: $" + Convert.ToString(s) + "\n");
            var t = Math.Round(data.Total, 2);
            printer.Print("Total: $" + Convert.ToString(t) + "\n");
            if (UsedCredit)
            {
                printer.Print("Paid with credit" + "\n");                
            }
            else
            {
                printer.Print("Paid with cash" + "\n");                             
            }
        }
    }
}
