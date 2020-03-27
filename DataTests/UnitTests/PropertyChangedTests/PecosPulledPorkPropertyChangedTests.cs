using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        //PecosPulledPork should Implement INotifyPropertyChanged
        [Fact]
        public void PecosPulledPorkShouldImplementINotifyPropertyChanged()
        {
            var PPP = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(PPP);
        }

        //Changing "Bread" Should Invoke PropertyChanged for "Bread"
        [Fact]
        public void ChangingBreadShouldInvokeINotifyPropertyChangedForBread()
        {
            var PPP = new PecosPulledPork();
            Assert.PropertyChanged(PPP, "Bread", () =>
            {
                PPP.Bread = false;
            });
        }

        //Changing "Bread" Should Invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBreadShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var PPP = new PecosPulledPork();
            Assert.PropertyChanged(PPP, "SpecialInstructions", () =>
            {
                PPP.Bread = false;
            });
        }

        //Changing "Pickle" Should Invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokeINotifyPropertyChangedForPickle()
        {
            var PPP = new PecosPulledPork();
            Assert.PropertyChanged(PPP, "Pickle", () =>
            {
                PPP.Pickle = false;
            });
        }

        //Changing "Pickle" Should Invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var PPP = new PecosPulledPork();
            Assert.PropertyChanged(PPP, "SpecialInstructions", () =>
            {
                PPP.Pickle = false;
            });
        }
    }
}
