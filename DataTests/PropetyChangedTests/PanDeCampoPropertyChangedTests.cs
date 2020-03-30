/*
 * Author: Zachary Terrell
 * 
 * Class name: PanDeCampoPropertyChangedTests.cs
 * 
 * Purpose: Tests Pan De Campo PropertyChanged features
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        //Pan De Campo should impliment the INotifyPropertyChangedInterface
        [Fact]
        public void PanDeCampoShouldImplementINotofyPropertyChanged()
        {
            var pan = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pan);
        }

        //Changing "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Size", () =>
            {
                pan.Size = Size.Medium;
            });
        }

        //Changing "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Price", () =>
            {
                pan.Size = Size.Medium;
            });
        }

        //Changing "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Calories", () =>
            {
                pan.Size = Size.Medium;
            });
        }
    }
}
