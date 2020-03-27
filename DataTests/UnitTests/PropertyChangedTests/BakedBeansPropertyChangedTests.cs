using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {
        //Baked Beans should Implement INotifyPropertyChanged
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChaged()
        {
            var BB = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(BB);
        }

        //Changing "Size" Should invoke PropertyChanged for "Price", "Calories", and "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPriceCaloriesSize()
        {
            var BB = new BakedBeans();
            Assert.PropertyChanged(BB, "Size", () =>
            {
                BB.Size = Size.Large;
            });

            Assert.PropertyChanged(BB, "Calories", () =>
            {
                BB.Size = Size.Medium;
            });

            Assert.PropertyChanged(BB, "Price", () =>
            {
                BB.Size = Size.Small;
            });
        }
    }
}
