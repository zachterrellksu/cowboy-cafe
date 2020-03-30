/*
 * Author: Zachary Terrell
 * 
 * Class name: CornDodgersPropertyChangedTests.cs
 * 
 * Purpose: Tests Corn Dodgers PropertyChanged features
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        //Corn Dodgers should impliment the INotifyPropertyChangedInterface
        [Fact]
        public void CornDodgersShouldImplementINotofyPropertyChanged()
        {
            var dodgers = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dodgers);
        }

        //Changing "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Size", () =>
            {
                dodgers.Size = Size.Medium;
            });
        }

        //Changing "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var dodgers = new BakedBeans();
            Assert.PropertyChanged(dodgers, "Price", () =>
            {
                dodgers.Size = Size.Medium;
            });
        }

        //Changing "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Calories", () =>
            {
                dodgers.Size = Size.Medium;
            });
        }
    }
}
