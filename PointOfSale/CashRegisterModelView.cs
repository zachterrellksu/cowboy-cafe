/*

* Author: Zachary Terrell 

* Class name:CashRegisterModelView.xaml.cs

* Purpose: Model View for CashRegister

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;
using CowboyCafe.Data;

namespace PointOfSale
{
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies of Property Changed events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The cashdrawer this class uses
        /// </summary>
        public CashDrawer drawer;
        
        /// <summary>
        /// The specific order
        /// </summary>
        Order order;

        /// <summary>
        /// The total amount of currency in the drawer
        /// </summary>
        public double TotalValue => drawer.TotalValue;

        /// <summary>
        /// How much the customer has paid
        /// </summary>
        public double Payment { get; private set; }

        /// <summary>
        /// Total cost of order
        /// </summary>
        public double OrderTotal
        {
            get
            {
                return order.Total;
            }
        }

        /// <summary>
        /// Amount of change
        /// </summary>
        public double Change
        {
            get
            {
                return Payment - order.Total;
            }          
        }
        

        /// <summary>
        /// The amount of change in specific denominations
        /// </summary>
        public List<string> FindAmounts
        {
            get
            {
                double[] denominations = { .50, .25, .10, .05, .1, 1.0, 2.0, 5.0, 10.0, 20.0, 50.0, 100.0};
                int[] number = {drawer.HalfDollars, drawer.Quarters, drawer.Dimes, drawer.Nickels, drawer.Pennies,
                                                                              drawer.Ones, drawer.Twos, drawer.Fives, drawer.Tens, drawer.Twenties, drawer.Fifties, drawer.Hundreds};
                double amount = Math.Round(Change,2);                
                List<string> change = new List<string>();
                double num;                
                for(int i = denominations.Length - 1; i >= 0; i--)
                {
                    num = (amount / denominations[i]);
                    if ((int)num != 0 && number[i] >= (int)num)
                    {
                        change.Add("Number of " + denominations[i] + "s: " + (int)num);
                        amount -= denominations[i] * (int)num;
                        amount = Math.Round(amount, 2);
                        int count = (int)num;
                        if(denominations[i] == .50)
                        {
                            drawer.RemoveCoin(Coins.HalfDollar, count);
                        }
                        else if(denominations[i] == .25)
                        {
                            drawer.RemoveCoin(Coins.Quarter, count);
                        }
                        else if (denominations[i] == .10)
                        {
                            drawer.RemoveCoin(Coins.Dime, count);
                        }
                        else if (denominations[i] == .05)
                        {
                            drawer.RemoveCoin(Coins.Nickel, count);
                        }
                        else if (denominations[i] == .1)
                        {
                            drawer.RemoveCoin(Coins.Penny, count);
                        }
                        else if (denominations[i] == 1.0)
                        {
                            drawer.RemoveBill(Bills.One, count);
                        }
                        else if (denominations[i] == 2.0)
                        {
                            drawer.RemoveBill(Bills.Two, count);
                        }
                        else if (denominations[i] == 5.0)
                        {
                            drawer.RemoveBill(Bills.Five, count);
                        }
                        else if (denominations[i] == 10.0)
                        {
                            drawer.RemoveBill(Bills.Ten, count);
                        }
                        else if (denominations[i] == 20.0)
                        {
                            drawer.RemoveBill(Bills.Twenty, count);
                        }
                        else if (denominations[i] == 50.0)
                        {
                            drawer.RemoveBill(Bills.Fifty, count);
                        }
                        else if (denominations[i] == 100.0)
                        {
                            drawer.RemoveBill(Bills.Hundred, count);
                        }
                    }                    
                }
                return change;
            }
        }

        /// <summary>
        /// Adds and Subtracts Pennies
        /// </summary>
        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0) return;
                var quantity = value - drawer.Pennies;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Penny, quantity);
                    Payment = Payment + (quantity * .01);                 
                }
                else
                {
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                    Payment += quantity * .01;
                }
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// Adds and Subtracts Nickels
        /// </summary>
        public int Nickels
        {
            get => drawer.Nickels;

            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quantity = value - drawer.Nickels;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Nickel, quantity);
                    Payment += quantity * .05;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                    Payment += quantity * .05;
                }
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// Adds and Subtracts Dimes
        /// </summary>
        public int Dimes
        {
            get => drawer.Dimes;

            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quantity = value - drawer.Dimes;
                if (quantity > 0)
                {
                    Payment += quantity * .10;
                    drawer.AddCoin(Coins.Dime, quantity);
                }
                else
                {
                    Payment += quantity * .10;
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                }
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// Adds and Subtracts Quarters
        /// </summary>
        public int Quarters
        {
            get => drawer.Quarters;

            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quantity = value - drawer.Quarters;
                if (quantity > 0)
                {
                    Payment += quantity * .25;
                    drawer.AddCoin(Coins.Quarter, quantity);
                }
                else
                {
                    Payment += quantity * .25;
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                }
                InvokePropertyChanged("Quarters");
            }
        }

        /// <summary>
        /// Adds and Subtracts HalfDollars
        /// </summary>
        public int HalfDollars
        {
            get => drawer.HalfDollars;

            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                var quantity = value - drawer.HalfDollars;
                if (quantity > 0)
                {
                    Payment += quantity * .50;
                    drawer.AddCoin(Coins.HalfDollar, quantity);
                }
                else
                {
                    Payment += quantity * .25;
                    drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                }
                InvokePropertyChanged("HalfDollars");
            }
        }

        /// <summary>
        /// Adds and Subtracts Dollars
        /// </summary>
        public int Dollars
        {
            get => drawer.Dollars;

            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quantity = value - drawer.Dollars;
                if (quantity > 0)
                {
                    Payment += quantity * 1.0;
                    drawer.AddCoin(Coins.Dollar, quantity);
                }
                else
                {
                    Payment += quantity * 1.0;
                    drawer.RemoveCoin(Coins.Dollar, -quantity);
                }
                InvokePropertyChanged("Dollars");
            }
        }

        /// <summary>
        /// Adds and Subtracts Ones
        /// </summary>
        public int Ones
        {
            get => drawer.Ones;

            set
            {
                if (drawer.Ones == value || value < 0) return;
                var quantity = value - drawer.Ones;
                if (quantity > 0)
                {
                    Payment = Payment + (quantity * 1.0);
                    drawer.AddBill(Bills.One, quantity);
                }
                else
                {
                    Payment += quantity * 1.0;
                    drawer.RemoveBill(Bills.One, -quantity);
                }
                InvokePropertyChanged("Ones");
            }
        }

        /// <summary>
        /// Adds and Subtracts Twos
        /// </summary>
        public int Twos
        {
            get => drawer.Twos;

            set
            {
                if (drawer.Twos == value || value < 0) return;
                var quantity = value - drawer.Twos;
                if (quantity > 0)
                {
                    Payment += quantity * 2.0;
                    drawer.AddBill(Bills.Two, quantity);
                }
                else
                {
                    Payment += quantity * 2.0;
                    drawer.RemoveBill(Bills.Two, -quantity);
                }
                InvokePropertyChanged("Twos");
            }
        }

        /// <summary>
        /// Adds and Subtracts Fives
        /// </summary>
        public int Fives
        {
            get => drawer.Fives;

            set
            {
                if (drawer.Fives == value || value < 0) return;
                var quantity = value - drawer.Fives;
                if (quantity > 0)
                {
                    Payment += quantity * 5.0;
                    drawer.AddBill(Bills.Five, quantity);
                }
                else
                {
                    Payment += quantity * 5.0;
                    drawer.RemoveBill(Bills.Five, -quantity);
                }
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// Adds and Subtracts Tens
        /// </summary>
        public int Tens
        {
            get => drawer.Tens;

            set
            {
                if (drawer.Tens == value || value < 0) return;
                var quantity = value - drawer.Tens;
                if (quantity > 0)
                {
                    Payment += quantity * 10.0;
                    drawer.AddBill(Bills.Ten, quantity);
                }
                else
                {
                    Payment += quantity * 10.0;
                    drawer.RemoveBill(Bills.Ten, -quantity);
                }
                InvokePropertyChanged("Tens");
            }
        }

        /// <summary>
        /// Adds and Subtracts Twenties
        /// </summary>
        public int Twenties
        {
            get => drawer.Twenties;

            set
            {
                if (drawer.Twenties == value || value < 0) return;
                var quantity = value - drawer.Twenties;
                if (quantity > 0)
                {
                    Payment += quantity * 20.0;
                    drawer.AddBill(Bills.Twenty, quantity);
                }
                else
                {
                    Payment += quantity * 20.0;
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                }
                InvokePropertyChanged("Twenties");
            }
        }

        /// <summary>
        /// Adds and Subtracts Fifties
        /// </summary>
        public int Fifties
        {
            get => drawer.Fifties;

            set
            {
                if (drawer.Fifties == value || value < 0) return;
                var quantity = value - drawer.Fifties;
                if (quantity > 0)
                {
                    Payment += quantity * 50.0;
                    drawer.AddBill(Bills.Fifty, quantity);
                }
                else
                {
                    Payment += quantity * 50.0;
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                }
                InvokePropertyChanged("Fifties");
            }
        }

        /// <summary>
        /// Adds and Subtracts Hundreds
        /// </summary>
        public int Hundreds
        {
            get => drawer.Hundreds;

            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                var quantity = value - drawer.Hundreds;
                if (quantity > 0)
                {
                    Payment += quantity * 100.0;
                    drawer.AddBill(Bills.Hundred, quantity);
                }
                else
                {
                    Payment += quantity * 100.0;
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                }
                InvokePropertyChanged("Hundreds");
            }
        }

        /// <summary>
        /// 2-arg subtractor
        /// </summary>
        /// <param name="d">the drawer</param>
        /// <param name="data">the order</param>
        public CashRegisterModelView(CashDrawer d, Order data)
        {
            drawer = d;
            order = data;
        }

        /// <summary>
        /// For triggering PropertyChagned
        /// </summary>
        /// <param name="denomination">Denomination of the currency</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Payment"));
        }
    }
}
