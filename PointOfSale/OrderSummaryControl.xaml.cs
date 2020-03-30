/*

* Author: Zachary Terrell 

* Class name: OrderSummaryControl.xaml.cs

* Purpose: Interaction logic for OrderSummaryControl.xaml

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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        /// <summary>
        /// Initializes components 
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Event handler for a change in item customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">The Listbox</param>
        void ListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach(object item in e.AddedItems)
            {
                if(item is AngryChicken)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizeAngryChicken();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is BakedBeans)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizeBakedBeans();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is ChiliCheeseFries)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizeChiliCheeseFries();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is CornDodgers)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizeCornDodgers();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is CowboyCoffee)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizeCowboyCoffee();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is CowpokeChili)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizeCowpokeChili();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is DakotaDoubleBurger)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizeDakotaDoubleBurger();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is JerkedSoda)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizeJerkedSoda();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is PanDeCampo)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizePanDeCampo();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is PecosPulledPork)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizePecosPulledPork();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is TexasTea)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizeTexasTea();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is TexasTripleBurger)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizeTexasTripleBurger();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is TrailBurger)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizeTrailburger();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is Water)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                    var screen = new CustomizeWater();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Deletes item
        /// </summary>
        /// <param name="sender">The button</param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Remove((IOrderItem)button.DataContext);
                }
            }
        }
    }
}
