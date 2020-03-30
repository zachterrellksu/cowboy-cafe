/*
 * Author: Zachary Terrell
 * 
 * Class name: RustlersRibsPropertyChangedTests.cs
 * 
 * Purpose: Tests Rustlers Ribs PropertyChanged features
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetyChangedTests
{
    public class RustlersRibsPropertyChangedTests
    {
        //RustlersRibs should impliment the INotifyPropertyChangedInterface
        [Fact]
        public void RustlersRibsShouldImplementINotofyPropertyChanged()
        {
            var ribs = new RustlersRibs();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ribs);
        }
    }
}
