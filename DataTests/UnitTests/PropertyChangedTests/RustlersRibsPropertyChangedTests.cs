using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class RustlersRibsPropertyChangedTests
    {
        //RustlersRibs Should Implement INotifyPropertyChanged
        [Fact]
        public void RustlersRibsShouldImplementINotifyPropertyChanged()
        {
            var RR = new RustlersRibs();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(RR);
        }
    }
}
