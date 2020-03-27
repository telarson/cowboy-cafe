using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class DakotaDoubleBurgerPropertyChangedTests
    {
        //DakotaDoubleBurger should Implement INotifyPropertyChanged
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(DDB);
        }

        //Changing "Bun" should Invoke PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "Bun", () =>
            {
                DDB.Bun = false;
            });
        }

        //Changing "Bun" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "SpecialInstructions", () =>
            {
                DDB.Bun = false;
            });
        }

        //Changing "Ketchup" should Invoke PropertyChanged for "Ketchup"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "Ketchup", () =>
            {
                DDB.Ketchup = false;
            });
        }

        //Changing "Ketchup" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "SpecialInstructions", () =>
            {
                DDB.Ketchup = false;
            });
        }

        //Changing "Mustard" should Invoke PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "Mustard", () =>
            {
                DDB.Mustard = false;
            });
        }

        //Changing "Mustard" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "SpecialInstructions", () =>
            {
                DDB.Mustard = false;
            });
        }

        //Changing "Pickle" should Invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "Pickle", () =>
            {
                DDB.Pickle = false;
            });
        }

        //Changing "Pickle" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "SpecialInstructions", () =>
            {
                DDB.Pickle = false;
            });
        }

        //Changing "Cheese" should Invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "Cheese", () =>
            {
                DDB.Cheese = false;
            });
        }

        //Changing "Cheese" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "SpecialInstructions", () =>
            {
                DDB.Cheese = false;
            });
        }

        //Changing "Tomato" should Invoke PropertyChanged for "Tomato"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "Tomato", () =>
            {
                DDB.Tomato = false;
            });
        }

        //Changing "Tomato" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "SpecialInstructions", () =>
            {
                DDB.Tomato = false;
            });
        }

        //Changing "Lettuce" should Invoke PropertyChanged for "Lettuce"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "Lettuce", () =>
            {
                DDB.Lettuce = false;
            });
        }

        //Changing "Lettuce" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "SpecialInstructions", () =>
            {
                DDB.Lettuce = false;
            });
        }

        //Changing "Mayo" should Invoke PropertyChanged for "Mayo"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "Mayo", () =>
            {
                DDB.Mayo = false;
            });
        }

        //Changing "Mayo" should Invoke PropertyChanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var DDB = new DakotaDoubleBurger();
            Assert.PropertyChanged(DDB, "SpecialInstructions", () =>
            {
                DDB.Mayo = false;
            });
        }

    }
}
