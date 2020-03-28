using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class TexasTeaPropertyChangedTests
    {
        //TexasTea should implement INotifyPropertyChanged
        [Fact]
        public void TexasTeaImplementsINotifyPropertyChanged()
        {
            var TT = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(TT);
        }

        //Changing "Size" Should invoke PropertyChanged for "Price", "Calories", and "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPriceCaloriesSize()
        {
            var TT = new TexasTea();
            Assert.PropertyChanged(TT, "Size", () =>
            {
                TT.Size = Size.Large;
            });

            Assert.PropertyChanged(TT, "Calories", () =>
            {
                TT.Size = Size.Medium;
            });

            Assert.PropertyChanged(TT, "Price", () =>
            {
                TT.Size = Size.Small;
            });
        }

        //Changing "Ice" should invoke PropertyChanged for "Ice" and "SpecialInstructions"
        [Fact]
        public void ChangingIceInvokesPropertyChangedForIceAndSpecialInstructions()
        {
            var TT = new TexasTea();
            Assert.PropertyChanged(TT, "Ice", () =>
            {
                TT.Ice = false;
            });

            Assert.PropertyChanged(TT, "SpecialInstructions", () =>
            {
                TT.Ice = true;
            });
        }

        //Changing "Sweet" should invoke PropertyChanged for "Sweet" and "SpecialInstructions"
        [Fact]
        public void ChangingSweetInvokesPropertyChangedForIceAndSpecialInstructions()
        {
            var TT = new TexasTea();
            Assert.PropertyChanged(TT, "Sweet", () =>
            {
                TT.Sweet = false;
            });

            Assert.PropertyChanged(TT, "SpecialInstructions", () =>
            {
                TT.Sweet = true;
            });
        }

        //Changing "Lemon" should invoke PropertyChanged for "Lemon" and "SpecialInstructions"
        [Fact]
        public void ChangingLemonInvokesPropertyChangedForIceAndSpecialInstructions()
        {
            var TT = new TexasTea();
            Assert.PropertyChanged(TT, "Lemon", () =>
            {
                TT.Lemon = false;
            });

            Assert.PropertyChanged(TT, "SpecialInstructions", () =>
            {
                TT.Lemon = true;
            });
        }


    }
}
