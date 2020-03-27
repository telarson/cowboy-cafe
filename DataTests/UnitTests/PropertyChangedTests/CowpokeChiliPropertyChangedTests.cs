using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        //CowpokeChili should Implement INotifyPropertyChanged
        [Fact]
        public void CowpokeChiliShouldImplementINotifyPropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }

        //Changing cheese should invoke PropertyChanged for Cheese
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "Cheese", () =>
            {
                chili.Cheese = false;
            });
        }

        //Changing cheese should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.Cheese = false;
            });
        }

        //Changing SourCream should invoke PropertyChanged for SourCream
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSourCream()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () =>
            {
                chili.SourCream = false;
            });
        }

        //Changing cheese should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.SourCream = false;
            });
        }

        //Changing SourCream should invoke PropertyChanged for SourCream
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForGreenOnions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "GreenOnions", () =>
            {
                chili.GreenOnions = false;
            });
        }

        //Changing cheese should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.GreenOnions = false;
            });
        }

        //Changing SourCream should invoke PropertyChanged for SourCream
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForTortillaStrips()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "TortillaStrips", () =>
            {
                chili.TortillaStrips = false;
            });
        }

        //Changing cheese should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.TortillaStrips = false;
            });
        }
    }
}
