/* MenuTests.cs
 * Author: Tristan Larson
 * Tests for the Menu class
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.Linq;

namespace CowboyCafe.DataTests.UnitTests
{
    /// <summary>
    /// Tests for the Menu class
    /// </summary>
    public class MenuTests
    {
        //Entrees should return an IEnumberable containing one instance of each entree class
        [Fact]
        public void EntreesShouldReturnIEnumerableWithEachEntree()
        {
            List<Type> ListOfEntreeTypes = new List<Type>()
            {
                new AngryChicken().GetType(),
                new CowpokeChili().GetType(),
                new DakotaDoubleBurger().GetType(),
                new PecosPulledPork().GetType(),
                new RustlersRibs().GetType(),
                new TexasTripleBurger().GetType(),
                new TrailBurger().GetType()
            };

            IEnumerable<IOrderItem> EntreesReturned = Menu.Entrees();

            foreach(IOrderItem entree in EntreesReturned)
            {
                Assert.Contains(entree.GetType(), ListOfEntreeTypes);
            }
            
        }


        //Sides should return an IEnumerable containing one instance of each side class
        [Fact]
        public void SidesShouldReturnIEnumerableWithEachSide()
        {
            List<Type> ListOfSideTypes = new List<Type>()
            {
                new BakedBeans().GetType(),
                new ChiliCheeseFries().GetType(),
                new CornDodgers().GetType(),
                new PanDeCampo().GetType()
            };

            IEnumerable<IOrderItem> SidesReturned = Menu.Sides();

            foreach(IOrderItem sides in SidesReturned)
            {
                Assert.Contains(sides.GetType(), ListOfSideTypes);
            }
        }

        //Drinks should return an IEnumerable containing one instance of each drink class
        [Fact]
        public void DrinksShouldReturnIEnumerableWithEachDrink()
        {
            List<Type> ListOfDrinkTypes = new List<Type>()
            {
                new CowboyCoffee().GetType(),
                new TexasTea().GetType(),
                new Water().GetType(),
                new JerkedSoda().GetType()
            };

            IEnumerable<IOrderItem> DrinksReturned = Menu.Drinks();

            foreach (IOrderItem drink in DrinksReturned)
            {
                Assert.Contains(drink.GetType(), ListOfDrinkTypes);
            }
        }

        //All should return an IEnumerable containing one instacnce of each IOrderItem class
        [Fact]
        public void AllShouldReturnIEnumerableWithEachIOrderItem()
        {
            List<Type> ListOfIOrderItemTypes = new List<Type>()
            {
                new AngryChicken().GetType(),
                new CowpokeChili().GetType(),
                new DakotaDoubleBurger().GetType(),
                new PecosPulledPork().GetType(),
                new RustlersRibs().GetType(),
                new TexasTripleBurger().GetType(),
                new TrailBurger().GetType(),
                new BakedBeans().GetType(),
                new ChiliCheeseFries().GetType(),
                new CornDodgers().GetType(),
                new PanDeCampo().GetType(),
                new CowboyCoffee().GetType(),
                new JerkedSoda().GetType(),
                new TexasTea().GetType(),
                new Water().GetType()
            };

            IEnumerable<IOrderItem> IOrderItemsReturned = Menu.CompleteMenu();

            foreach (IOrderItem all in IOrderItemsReturned)
            {
                Assert.Contains(all.GetType(), ListOfIOrderItemTypes);
            }
        }

        //Search should return items with the search string in the name

        //FilterByCategory should return IEnumerable of IOrderItems matching the category

        //FilterByCalories should return IEnumeerable of IOrderItems with calories in the given range

        //FilterByPrice should return IEnumeerable of IOrderItems with price in the given range
    }
}
