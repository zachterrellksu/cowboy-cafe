using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Accesses all of the entrees
        /// </summary>
        /// <returns>List of entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeList = new List<IOrderItem>();
            entreeList.Add(new AngryChicken());
            entreeList.Add(new CowpokeChili());
            entreeList.Add(new DakotaDoubleBurger());
            entreeList.Add(new PecosPulledPork());
            entreeList.Add(new RustlersRibs());
            entreeList.Add(new TexasTripleBurger());
            entreeList.Add(new TrailBurger());

            return entreeList;
        }

        /// <summary>
        /// Accesses all of the sides
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sidesList = new List<IOrderItem>();
            sidesList.Add(new BakedBeans());
            sidesList.Add(new ChiliCheeseFries());
            sidesList.Add(new CornDodgers());
            sidesList.Add(new PanDeCampo());

            return sidesList;
        }

        /// <summary>
        /// Accesses all of the drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinksList = new List<IOrderItem>();
            drinksList.Add(new CowboyCoffee());
            drinksList.Add(new JerkedSoda());
            drinksList.Add(new TexasTea());
            drinksList.Add(new Water());

            return drinksList;
        }

        /// <summary>
        /// Accesses all of the menu items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> menuList = new List<IOrderItem>();
            menuList.Add(new AngryChicken());
            menuList.Add(new CowpokeChili());
            menuList.Add(new DakotaDoubleBurger());
            menuList.Add(new PecosPulledPork());
            menuList.Add(new RustlersRibs());
            menuList.Add(new TexasTripleBurger());
            menuList.Add(new TrailBurger());

            menuList.Add(new BakedBeans());
            menuList.Add(new ChiliCheeseFries());
            menuList.Add(new CornDodgers());
            menuList.Add(new PanDeCampo());

            menuList.Add(new BakedBeans());
            menuList.Add(new ChiliCheeseFries());
            menuList.Add(new CornDodgers());
            menuList.Add(new PanDeCampo());
            return menuList;
        }
    }
}
