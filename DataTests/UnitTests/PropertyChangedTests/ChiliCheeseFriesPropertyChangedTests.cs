using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        //ChiliCheeseFries Should Implement INotifiyPropertyChanged
        [Fact]
        public void ChiliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var CCF = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(CCF);
        }

        //Changing "Size" Should invoke PropertyChanged for "Price", "Calories", and "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPriceCaloriesSize()
        {
            var CCF = new ChiliCheeseFries();
            Assert.PropertyChanged(CCF, "Size", () =>
            {
                CCF.Size = Size.Large;
            });

            Assert.PropertyChanged(CCF, "Calories", () =>
            {
                CCF.Size = Size.Medium;
            });

            Assert.PropertyChanged(CCF, "Price", () =>
            {
                CCF.Size = Size.Small;
            });
        }
    }
}
