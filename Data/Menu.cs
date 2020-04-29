using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*

* Author: Zachary Terrell 

* Class name: Menu.cs

* Purpose: Represents the menu

*/
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

            menuList.Add(new CowboyCoffee());
            menuList.Add(new JerkedSoda());
            menuList.Add(new TexasTea());
            menuList.Add(new Water());
            return menuList;
        }

        /// <summary>
        /// Searches all of the menu items
        /// </summary>
        /// <param name="items"></param>
        /// <param name="term"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null) return CompleteMenu();

            foreach(IOrderItem item in items)
            {
                if(item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the menu items by catagory
        /// </summary>
        /// <param name="items"></param>
        /// <param name="catagory"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> catagory)
        {
            if (catagory == null || catagory.Count() == 0) return items;

            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in items)
            {
                if (catagory.Contains(item.GetType().BaseType.Name)){
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by the calories in each item
        /// </summary>
        /// <param name="items"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;

            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by the price of each item
        /// </summary>
        /// <param name="items"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
