using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        //JerkedSoda should implement INotifyPropertyChanged
        [Fact]
        public void JekedSodaImplementsINotifyPropertyChanged()
        {
            var JS = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(JS);
        }

        //Changing "Size" Should invoke PropertyChanged for "Price", "Calories", and "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPriceCaloriesSize()
        {
            var JS = new JerkedSoda();
            Assert.PropertyChanged(JS, "Size", () =>
            {
                JS.Size = Size.Large;
            });

            Assert.PropertyChanged(JS, "Calories", () =>
            {
                JS.Size = Size.Medium;
            });

            Assert.PropertyChanged(JS, "Price", () =>
            {
                JS.Size = Size.Small;
            });
        }

        //Chaning "Flavor" should invoke PropertyChanged on "Flavor" and "SpecialInstructions"
        [Fact]
        public void ChangingFlavorInvokesPropertyChangedForFlavorAndSpecialInstructions()
        {
            var JS = new JerkedSoda();
            Assert.PropertyChanged(JS, "Flavor", () =>
            {
                JS.Flavor = SodaFlavor.RootBeer;
            });

            Assert.PropertyChanged(JS, "SpecialInstructions", () =>
            {
                JS.Flavor = SodaFlavor.OrangeSoda;
            });
        }

        //Changing "Ice" should invoke PropertyChanged for "Ice" and "SpecialInstructions"
        [Fact]
        public void ChangingIceInvokesPropertyChangedForIceAndSpecialInstructions()
        {
            var JS = new JerkedSoda();
            Assert.PropertyChanged(JS, "Ice", () =>
            {
                JS.Ice = false;
            });

            Assert.PropertyChanged(JS, "SpecialInstructions", () =>
            {
                JS.Ice = true;
            });
        }
    }
}
