using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        //Water should implement INOtifyPropertyChanged
        [Fact]
        public void WaterImplementsINotifyPropertyChanged()
        {
            var W = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(W);
        }

        //Changing "Size" Should invoke PropertyChanged for "Price", "Calories", and "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPriceCaloriesSize()
        {
           var W = new Water();
            Assert.PropertyChanged(W, "Size", () =>
            {
                W.Size = Size.Large;
            });

            Assert.PropertyChanged(W, "Calories", () =>
            {
                W.Size = Size.Medium;
            });

            Assert.PropertyChanged(W, "Price", () =>
            {
                W.Size = Size.Small;
            });
        }

        //Changing "Ice" should invoke PropertyChanged for "Ice" and "SpecialInstructions"
        [Fact]
        public void ChangingIceInvokesPropertyChangedForIceAndSpecialInstructions()
        {
           var W = new Water();
            Assert.PropertyChanged(W, "Ice", () =>
            {
                W.Ice = false;
            });

            Assert.PropertyChanged(W, "SpecialInstructions", () =>
            {
                W.Ice = true;
            });
        }

        //Changing "Lemon" should invoke PropertyChanged for "Lemon" and "SpecialInstructions"
        [Fact]
        public void ChangingLemonInvokesPropertyChangedForIceAndSpecialInstructions()
        {
           var W = new Water();
            Assert.PropertyChanged(W, "Lemon", () =>
            {
                W.Lemon = false;
            });

            Assert.PropertyChanged(W, "SpecialInstructions", () =>
            {
                W.Lemon = true;
            });
        }
    }
}
