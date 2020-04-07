/*

* Author: Zachary Terrell 

* Class name: CashRegisterCOntrol.xaml.cs

* Purpose: Backend for CashRegisterControl
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
using CowboyCafe.Extensions;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {

        CashRegisterModelView mv;

        /// <summary>
        /// 2-arg constructor
        /// </summary>
        /// <param name="drawer"></param>
        /// <param name="data"></param>
        public CashRegisterControl(CashDrawer drawer, Order data)
        {
            InitializeComponent();            
            mv = new CashRegisterModelView(drawer, data);
            DataContext = mv;
        }

        /// <summary>
        /// When the done button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashRegisterModelView data)
            {
                if(data.Payment < data.OrderTotal)
                {
                    MessageBox.Show("Please add payment");
                }
                else
                {
                    double change = data.Payment - data.OrderTotal;
                    OrderControl orderControl = this.FindAncestor<OrderControl>();
                    orderControl.Main.Child = new ChangeControl(mv);
                }
            }
        }

    }
}
