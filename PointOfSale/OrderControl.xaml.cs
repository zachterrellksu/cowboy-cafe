/*

* Author: Zachary Terrell 

* Class name: OrderControl.xaml.cs

* Purpose: Interaction logic for OrderControl.xaml

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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Initializes the components and assigns click event handler
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            CancelOrder.Click += OnCancelOrderButtonClicked;
            CompleteOrder.Click += OnCompleteOrderButtonClicked;
            ItemSelection.Click += OnItemSelectionButtonClicked;
        }

        /// <summary>
        /// Click event handler for Cancel Order Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            {
                this.DataContext = new Order();
            }
        }

        /// <summary>
        /// Click event handler for Complete Order Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                this.DataContext = new Order();
            }
        }

        /// <summary>
        /// Click event handler for Item Selection Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                //Not implemented
            }
        }

        private void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            //Accidently double clicked, forgot how to delete without breaking code
        }

        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            //Accidently double clicked, forgot how to delete without breaking code
        }
    }
}
