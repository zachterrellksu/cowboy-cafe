/*
 * Author: Zachary Terrell
 * 
 * Class name: CowpokeChiliPropertyChangedTests.cs
 * 
 * Purpose: Tests Cowpoke Chili PropertyChanged features
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetyChangedTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        //Cowpoke Chili should impliment the INotifyPropertyChangedInterface
        [Fact]
        public void CowpokeChiliShouldImplementINotofyPropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }

        //Changing "Cheese" property should invoke PropertyChanged for "Cheese"        
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "Cheese", () =>
            {
                chili.Cheese = false;
            });
        }

        //Changing "Cheese" property should invoke PropertyChanged for "SpecialInstructions" 
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {

                chili.Cheese = false;
            });
        }

        //Changing "SourCream" property should invoke PropertyChanged for "SourCream"        
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSoureCream()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () =>
            {
                chili.SourCream = false;
            });
        }

        //Changing "SourCream" property should invoke PropertyChanged for "SpecialInstructions" 
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.SourCream = false;
            });
        }

        //Changing "GreenOnions" property should invoke PropertyChanged for "GreenOnions"        
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForGreenOnions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "GreenOnions", () =>
            {
                chili.GreenOnions = false;
            });
        }

        //Changing "GreenOnions" property should invoke PropertyChanged for "SpecialInstructions" 
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.GreenOnions = false;
            });
        }

        //Changing "TortillaStrips" property should invoke PropertyChanged for "TortillaStrips"        
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForTortillaStrips()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "TortillaStrips", () =>
            {
                chili.TortillaStrips = false;
            });
        }

        //Changing "TortillaStrips" property should invoke PropertyChanged for "SpecialInstructions" 
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.TortillaStrips = false;
            });
        }
    }
}
