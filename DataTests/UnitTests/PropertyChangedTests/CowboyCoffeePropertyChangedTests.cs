using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        //CowboyCoffee should implement INotifyPropertyChange
        [Fact]
        public void CowboyCoffeeShouldImplementINOtifyPropertyChanged()
        {
            var CC = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(CC);
        }

        //Changing "Size" Should invoke PropertyChanged for "Price", "Calories", and "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPriceCaloriesSize()
        {
            var CC = new CowboyCoffee();
            Assert.PropertyChanged(CC, "Size", () =>
            {
                CC.Size = Size.Large;
            });

            Assert.PropertyChanged(CC, "Calories", () =>
            {
                CC.Size = Size.Medium;
            });

            Assert.PropertyChanged(CC, "Price", () =>
            {
                CC.Size = Size.Small;
            });
        }

        //Changing "RoomForCream" should invoke PropertyChanged for "RoomForCream" and "SpecialInstructions"
        [Fact]
        public void ChangingRoomForCreamInvokesPropertyChangedForRoomForCreamAndSpecialInstructions()
        {
            var CC = new CowboyCoffee();
            Assert.PropertyChanged(CC, "RoomForCream", () =>
            {
                CC.RoomForCream = true;
            });

            Assert.PropertyChanged(CC, "SpecialInstructions", () =>
            {
                CC.RoomForCream = false;
            });
        }

        //Changing "Decaf" should invoke PropertyChanged for "Decaf" and "SpecialInstructions"
        [Fact]
        public void ChangingDecafInvokesPropertyChangedForDecafAndSpecialInstructions()
        {
            var CC = new CowboyCoffee();
            Assert.PropertyChanged(CC, "Decaf", () =>
            {
                CC.Decaf = true;
            });

            Assert.PropertyChanged(CC, "SpecialInstructions", () =>
            {
                CC.Decaf = false;
            });
        }

        //Changing "Ice" should invoke PropertyChanged for "Ice" and "SpecialInstructions"
        [Fact]
        public void ChangingIceInvokesPropertyChangedForIceAndSpecialInstructions()
        {
            var CC = new CowboyCoffee();
            Assert.PropertyChanged(CC, "Ice", () =>
            {
                CC.Ice = true;
            });

            Assert.PropertyChanged(CC, "SpecialInstructions", () =>
            {
                CC.Ice = false;
            });
        }
    }
}
