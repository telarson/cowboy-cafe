using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        //CornDodgers Should Implement INotifyPropertyChanged
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var CD = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(CD);
        }

        //Changing "Size" Should invoke PropertyChanged for "Price", "Calories", and "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPriceCaloriesSize()
        {
            var CD = new CornDodgers();
            Assert.PropertyChanged(CD, "Size", () =>
            {
                CD.Size = Size.Large;
            });

            Assert.PropertyChanged(CD, "Calories", () =>
            {
                CD.Size = Size.Medium;
            });

            Assert.PropertyChanged(CD, "Price", () =>
            {
                CD.Size = Size.Small;
            });
        }
    }
}
