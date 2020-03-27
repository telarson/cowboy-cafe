using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class TrailBurgerPropertyChangedTests
    {
        //TrailBurger Should Implement INotifyPropertyChanged
        [Fact]
        public void TrailBurgerShouldImplementINotifyPropertyChanged()
        {
            var TB = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(TB);
        }

        //Changing "Bun" should Invoke PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var TB = new TrailBurger();
            Assert.PropertyChanged(TB, "Bun", () =>
            {
                TB.Bun = false;
            });
        }

        //Changing "Bun" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TB = new TrailBurger();
            Assert.PropertyChanged(TB, "SpecialInstructions", () =>
            {
                TB.Bun = false;
            });
        }

        //Changing "Ketchup" should Invoke PropertyChanged for "Ketchup"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var TB = new TrailBurger();
            Assert.PropertyChanged(TB, "Ketchup", () =>
            {
                TB.Ketchup = false;
            });
        }

        //Changing "Ketchup" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TB = new TrailBurger();
            Assert.PropertyChanged(TB, "SpecialInstructions", () =>
            {
                TB.Ketchup = false;
            });
        }

        //Changing "Mustard" should Invoke PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var TB = new TrailBurger();
            Assert.PropertyChanged(TB, "Mustard", () =>
            {
                TB.Mustard = false;
            });
        }

        //Changing "Mustard" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TB = new TrailBurger();
            Assert.PropertyChanged(TB, "SpecialInstructions", () =>
            {
                TB.Mustard = false;
            });
        }

        //Changing "Pickle" should Invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var TB = new TrailBurger();
            Assert.PropertyChanged(TB, "Pickle", () =>
            {
                TB.Pickle = false;
            });
        }

        //Changing "Pickle" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TB = new TrailBurger();
            Assert.PropertyChanged(TB, "SpecialInstructions", () =>
            {
                TB.Pickle = false;
            });
        }

        //Changing "Cheese" should Invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var TB = new TrailBurger();
            Assert.PropertyChanged(TB, "Cheese", () =>
            {
                TB.Cheese = false;
            });
        }

        //Changing "Cheese" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TB = new TrailBurger();
            Assert.PropertyChanged(TB, "SpecialInstructions", () =>
            {
                TB.Cheese = false;
            });
        }
    }
}
