using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        //TexasTripleBurger Should Implement INOtifyPropertyChanged
        [Fact]
        public void TexasTripleBurgerShouldImplementINotifyPropertyChanged()
        {
            var TTB = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(TTB);
        }

        //Changing "Bun" should Invoke PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "Bun", () =>
            {
                TTB.Bun = false;
            });
        }

        //Changing "Bun" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "SpecialInstructions", () =>
            {
                TTB.Bun = false;
            });
        }

        //Changing "Ketchup" should Invoke PropertyChanged for "Ketchup"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "Ketchup", () =>
            {
                TTB.Ketchup = false;
            });
        }

        //Changing "Ketchup" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "SpecialInstructions", () =>
            {
                TTB.Ketchup = false;
            });
        }

        //Changing "Mustard" should Invoke PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "Mustard", () =>
            {
                TTB.Mustard = false;
            });
        }

        //Changing "Mustard" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "SpecialInstructions", () =>
            {
                TTB.Mustard = false;
            });
        }

        //Changing "Pickle" should Invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "Pickle", () =>
            {
                TTB.Pickle = false;
            });
        }

        //Changing "Pickle" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "SpecialInstructions", () =>
            {
                TTB.Pickle = false;
            });
        }

        //Changing "Cheese" should Invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "Cheese", () =>
            {
                TTB.Cheese = false;
            });
        }

        //Changing "Cheese" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "SpecialInstructions", () =>
            {
                TTB.Cheese = false;
            });
        }

        //Changing "Tomato" should Invoke PropertyChanged for "Tomato"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "Tomato", () =>
            {
                TTB.Tomato = false;
            });
        }

        //Changing "Tomato" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "SpecialInstructions", () =>
            {
                TTB.Tomato = false;
            });
        }

        //Changing "Lettuce" should Invoke PropertyChanged for "Lettuce"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "Lettuce", () =>
            {
                TTB.Lettuce = false;
            });
        }

        //Changing "Lettuce" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "SpecialInstructions", () =>
            {
                TTB.Lettuce = false;
            });
        }

        //Changing "Mayo" should Invoke PropertyChanged for "Mayo"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "Mayo", () =>
            {
                TTB.Mayo = false;
            });
        }

        //Changing "Mayo" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "SpecialInstructions", () =>
            {
                TTB.Mayo = false;
            });
        }

        //Changing "Bacon" should Invoke PropertyChanged for "Bacon"
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForBacon()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "Bacon", () =>
            {
                TTB.Bacon = false;
            });
        }

        //Changing "Mayo" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "SpecialInstructions", () =>
            {
                TTB.Bacon = false;
            });
        }

        //Changing "Egg" should Invoke PropertyChanged for "Egg"
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForEgg()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "Egg", () =>
            {
                TTB.Egg = false;
            });
        }

        //Changing "Egg" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TTB = new TexasTripleBurger();
            Assert.PropertyChanged(TTB, "SpecialInstructions", () =>
            {
                TTB.Egg = false;
            });
        }
    }
}
