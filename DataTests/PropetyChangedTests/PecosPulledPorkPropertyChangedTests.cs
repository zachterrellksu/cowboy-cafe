/*
 * Author: Zachary Terrell
 * 
 * Class name: PecosPulledPorkPropertyChangedTests.cs
 * 
 * Purpose: Tests Pecos Pulled Pork PropertyChanged features
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetyChangedTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        //PecosPulledPork should impliment the INotifyPropertyChangedInterface
        [Fact]
        public void PecosPulledPorkShouldImplementINotofyPropertyChanged()
        {
            var pulledPork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pulledPork);
        }

        //Changing "Bread" property should invoke PropertyChanged for "Bread"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var pulledPork = new PecosPulledPork();
            Assert.PropertyChanged(pulledPork, "Bread", () =>
            {
                pulledPork.Bread = false;
            });
        }

        //Changing "Bread" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pulledPork = new PecosPulledPork();
            Assert.PropertyChanged(pulledPork, "SpecialInstructions", () =>
            {
                pulledPork.Bread = false;
            });
        }

        //Changing "Pickle" property should invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var pulledPork = new PecosPulledPork();
            Assert.PropertyChanged(pulledPork, "Pickle", () =>
            {
                pulledPork.Pickle = false;
            });
        }

        //Changing "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedSpecialInstructions()
        {
            var pulledPork = new PecosPulledPork();
            Assert.PropertyChanged(pulledPork, "SpecialInstructions", () =>
            {
                pulledPork.Pickle = false;
            });
        }
    }
}
