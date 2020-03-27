using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class AngryChickenPropertyChangedTests
    {
        //Angry Chicken should implement INotifyPropertyChanged interface
        [Fact]
        public void AngryChickenShouldImplemenINotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }

        //Changing "Bread" Property should invoke PropertyChanged for "Bread"
        [Fact]
        public void ChaningBreadShouldInvokePropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () =>
            {
                chicken.Bread = false;
            });
        }

        //Changing "Bread" should invoke PropertyChanged for "SpecialInstructions
        [Fact]
        public void ChaningBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Bread = false;
            });
        }

        //Changing "Pickle" Property should invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangeForPickle()
        {
            {
                var chicken = new AngryChicken();
                Assert.PropertyChanged(chicken, "Pickle", () =>
                {
                    chicken.Pickle = false;
                });
            }
        }

        //Changing "Pickle" Property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangeForSpecialInstructions()
        {
            {
                var chicken = new AngryChicken();
                Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
                {
                    chicken.Pickle = false;
                });
            }
        }
    }
}
