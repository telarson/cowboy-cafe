using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        //PanDeCampo should implement INotifyPropertyChanged
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var PDC = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(PDC);
        }

        //Changing "Size" Should invoke PropertyChanged for "Price", "Calories", and "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPriceCaloriesSize()
        {
            var PDC = new PanDeCampo();
            Assert.PropertyChanged(PDC, "Size", () =>
            {
                PDC.Size = Size.Large;
            });

            Assert.PropertyChanged(PDC, "Calories", () =>
            {
                PDC.Size = Size.Medium;
            });

            Assert.PropertyChanged(PDC, "Price", () =>
            {
                PDC.Size = Size.Small;
            });
        }
    }
}
