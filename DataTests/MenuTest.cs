using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class MenuTest
    {
        /// <summary>
        /// Should return all of the entrees
        /// </summary>
        [Fact]
        public void MenuEntreesShouldContainExpectedItems()
        {
            Assert.Collection(
                Menu.Entrees(),
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }

        /// <summary>
        /// Should return all of the sides
        /// </summary>
        [Fact]
        public void MenuSidesShouldContainExpectedItems()
        {
            Assert.Collection(
                Menu.Sides(),
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        /// <summary>
        /// Should return all of the drinks
        /// </summary>
        [Fact]
        public void MenuDrinksShouldContainExpectedItems()
        {
            Assert.Collection(
                Menu.Drinks(),
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        /// <summary>
        /// Should return all of the items
        /// </summary>
        [Fact]
        public void MenuShouldContainExpectedItems()
        {
            Assert.Collection(
                Menu.CompleteMenu(),
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },

                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },

                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        /// <summary>
        /// Returns all items when search is empty
        /// </summary>
        [Fact]
        public void EmptySearchReturnsAllItems()
        {
            Assert.Collection(
                Menu.Search(Menu.CompleteMenu(), null),
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },

                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },

                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        /// <summary>
        /// Should show items that is searched for
        /// </summary>
        [Fact]
        public void SearchReturnsItem()
        {
            Assert.Collection(
                Menu.Search(Menu.CompleteMenu(), "angry"),
                (ac) => { Assert.IsType<AngryChicken>(ac); }
                );
        }

        /// <summary>
        /// No catagory returns all items
        /// </summary>
        [Fact]
        public void NoSpecificCatagoryReturnsAllItems()
        {
            List<string> category = null;
            var items = Menu.CompleteMenu();
            Assert.Equal(items, Menu.FilterByCategory(items, category));
        }

        /// <summary>
        /// Correct calories when setting bounds
        /// </summary>
        [Fact]
        public void FilteringCaloriesReturnsRightCalories()
        {
            Assert.Collection(
                Menu.FilterByCalories(Menu.CompleteMenu(), 1, 50),
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); }
                );
        }

        /// <summary>
        /// All foods with calories above number
        /// </summary>
        [Fact]
        public void CorrectNumberOfItemsWithCaloriesAboveNumber()
        {
            Assert.Collection(
                Menu.FilterByCalories(Menu.CompleteMenu(), 893, null),
                (ac) => { Assert.IsType<RustlersRibs>(ac); }
                );
        }

        /// <summary>
        /// All foods with calories below number
        /// </summary>
        [Fact]
        public void CorrectNumberOfItemsWithCaloriesBelowNumber()
        {
            Assert.Collection(
                Menu.FilterByCalories(Menu.CompleteMenu(), null, 1),
                (cc) => { Assert.IsType<Water>(cc); }
                );
        }

        /// <summary>
        /// Returns all items
        /// </summary>
        [Fact]
        public void NoCalorieSpecReturnsAll()
        {
            var items = Menu.CompleteMenu();
            Assert.Equal(items, Menu.FilterByCalories(items, null, null));
        }

        /// <summary>
        /// Correct price when setting bounds
        /// </summary>
        [Fact]
        public void FilteringPriceReturnsRightPrice()
        {
            Assert.Collection(
                Menu.FilterByPrice(Menu.CompleteMenu(), 6.00, 6.20),
                (cc) => { Assert.IsType<CowpokeChili>(cc); }
                );
        }

        /// <summary>
        ///  All foods with price above number
        /// </summary>
        [Fact]
        public void CorrectNumberOfItemsWithPriceAboveNumber()
        {
            Assert.Collection(
                Menu.FilterByPrice(Menu.CompleteMenu(), 7.4, null),
                (ac) => { Assert.IsType<RustlersRibs>(ac); }
                );
        }

        /// <summary>
        /// All foods with price below number
        /// </summary>
        [Fact]
        public void CorrectNumberOfItemsWithPriceBelowNumber()
        {
            Assert.Collection(
                Menu.FilterByPrice(Menu.CompleteMenu(), null, .13),
                (cc) => { Assert.IsType<Water>(cc); }
                );
        }

        /// <summary>
        /// Returns all items
        /// </summary>
        [Fact]
        public void NoPriceSpecReturnsAll()
        {
            var items = Menu.CompleteMenu();
            Assert.Equal(items, Menu.FilterByPrice(items, null, null));
        }

    }
}
