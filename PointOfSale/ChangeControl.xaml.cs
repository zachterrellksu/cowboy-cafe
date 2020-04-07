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
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ChangeControl.xaml
    /// </summary>
    public partial class ChangeControl : UserControl
    {
        /// <summary>
        /// 1-arg constructor
        /// </summary>
        /// <param name="mv"></param>
        public ChangeControl(CashRegisterModelView mv)
        {
            InitializeComponent();
            DataContext = mv;
        }

        /// <summary>
        /// Click event for done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButtonClicked(object sender, RoutedEventArgs e) 
        {
            ChangeScreen.Child = new OrderControl();            
        }
    }
}
