/*

* Author: Zachary Terrell 

* Class name: MenuItemSelectionControl.xaml.cs

* Purpose: Interaction logic for MenuItemSelection.xaml

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
    /// Interaction logic for MenuItemSelection.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {

        /// <summary>
        /// Initializes the components and assigns click event handler
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddTrailburgerButton.Click += OnAddTrailburgerButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;
        }

        /// <summary>
        /// Click event handler for Angry Chicken Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new AngryChicken());
            }
        }

        /// <summary>
        /// Click event handler for Baked Beans Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void  OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new BakedBeans());
            }
        }

        /// <summary>
        /// Click event handler for Chili Cheese Fries Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new ChiliCheeseFries());
            }
        }

        /// <summary>
        /// Click event handler for Corn Dodgers Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// Click event handler for Cowboy Coffee Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowboyCoffee());
            }
        }

        /// <summary>
        /// Click event handler for Cowpoke Chili Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowpokeChili());
            }
        }

        /// <summary>
        /// Click event handler for Dakota Double Burger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new DakotaDoubleBurger());
            }
        }

        /// <summary>
        /// Click event handler for Jerked Soda Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new JerkedSoda());
            }
        }

        /// <summary>
        /// Click event handler for Pan de Campo Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PanDeCampo());
            }
        }

        /// <summary>
        /// Click event handler for Pecos Pulled Pork Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PecosPulledPork());
            }
        }

        /// <summary>
        /// Click event handler for Rustlers Ribs Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new RustlersRibs());
            }
        }

        /// <summary>
        /// Click event handler for Texas Tea Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTeaClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTea());
            }
        }

        /// <summary>
        /// Click event handler for Texas Triple Burger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTripleBurger());
            }
        }

        /// <summary>
        /// Click event handler for Trailburger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTrailburgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TrailBurger());
            }
        }

        /// <summary>
        /// Click event handler for Water Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new Water());
            }
        }
    }
}
