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

            foreach (IOrderItem entree in EntreesReturned)
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

            foreach (IOrderItem sides in SidesReturned)
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
        [Theory]
        [InlineData("cow")]
        [InlineData("6")]
        [InlineData("")]
        [InlineData("Burger")]
        public void SearchShouldReturnCollectionFilteredBySearchTerms(string searchTerms)
        {
            // Collection of all menu items for testing the search and filters.
            List<IOrderItem> AllItems = new List<IOrderItem>()
            {

                    new AngryChicken(),
                    new CowpokeChili(),
                    new DakotaDoubleBurger(),
                    new PecosPulledPork(),
                    new RustlersRibs(),
                    new TexasTripleBurger(),
                    new TrailBurger(),
                    new BakedBeans(),
                    new ChiliCheeseFries(),
                    new CornDodgers(),
                    new PanDeCampo(),
                    new CowboyCoffee(),
                    new JerkedSoda(),
                    new TexasTea(),
                    new Water()
            };

            var results = Menu.Search(AllItems, searchTerms);

            foreach(IOrderItem item in results)
            {
                Assert.Contains(searchTerms, item.ToString(), StringComparison.InvariantCultureIgnoreCase);
            }
        }


        //FilterByCategory should return IEnumerable of IOrderItems matching the category
        [Theory]
        [InlineData(new object[] { new string[] { "Entree", "Side", "Drink" } })]
        [InlineData(new object[] { new string[] { "Entree", "Side" } })]
        [InlineData(new object[] { new string[] { "Entree" } })]
        [InlineData(new object[] { new string[] { "Side", "Drink" } })]
        [InlineData(new object[] { new string[] { "Entree", "Drink" } })]
        [InlineData(new object[] { new string[] { "Drink" } })]
        [InlineData(new object[] { new string[] { "Side" } })]
        [InlineData(new object[] { new string[] { "" } })]
        public void FilterByCategoryShouldReturnCollectionFilteredByCategories(string[] categories)
        {
            // Collection of all menu items for testing the search and filters.
            List<IOrderItem> AllItems = new List<IOrderItem>()
            {

                    new AngryChicken(),
                    new CowpokeChili(),
                    new DakotaDoubleBurger(),
                    new PecosPulledPork(),
                    new RustlersRibs(),
                    new TexasTripleBurger(),
                    new TrailBurger(),
                    new BakedBeans(),
                    new ChiliCheeseFries(),
                    new CornDodgers(),
                    new PanDeCampo(),
                    new CowboyCoffee(),
                    new JerkedSoda(),
                    new TexasTea(),
                    new Water()
            };

            var results = Menu.FilterByCategory(AllItems, categories);

            foreach(IOrderItem item in results)
            {
                if (item.GetType().BaseType == typeof(Entree))
                {
                    Assert.Contains("Entree", categories);
                }
                else if (item.GetType().BaseType == typeof(Side))
                {
                    Assert.Contains("Side", categories);
                }
                else if (item.GetType().BaseType == typeof(Drink))
                {
                    Assert.Contains("Drink", categories);
                }
            }
        }

        //FilterByCalories should return IEnumeerable of IOrderItems with calories in the given range
        [Theory]
        [InlineData(0, 5)]
        [InlineData(100, 100)]
        [InlineData(250, 500)]
        [InlineData(100, 50)]
        [InlineData(100, null)]
        [InlineData(null, 500)]
        [InlineData(null, null)]
        public void FilterByCaloriesReturnsACollectionOfItemsWithCaloriesInRange(int? max, int? min)
        {
            // Collection of all menu items for testing the search and filters.
            List<IOrderItem> AllItems = new List<IOrderItem>()
            {

                    new AngryChicken(),
                    new CowpokeChili(),
                    new DakotaDoubleBurger(),
                    new PecosPulledPork(),
                    new RustlersRibs(),
                    new TexasTripleBurger(),
                    new TrailBurger(),
                    new BakedBeans(),
                    new ChiliCheeseFries(),
                    new CornDodgers(),
                    new PanDeCampo(),
                    new CowboyCoffee(),
                    new JerkedSoda(),
                    new TexasTea(),
                    new Water()
            };

            var results = Menu.FilterByCalories(AllItems, min, max);

            foreach(IOrderItem item in results)
            {
                if(min != null && max != null)
                {
                    Assert.True(item.Calories >= min && item.Calories <= max);
                }
                else if(min == null && max != null)
                {
                    Assert.True(item.Calories <= max);
                }
                else if(min != null && max == null)
                {
                    Assert.True(item.Calories >= min);
                }
                else
                {
                    Assert.Equal(results, AllItems);
                }
            }
        }

        //FilterByPrice should return IEnumeerable of IOrderItems with price in the given range
        [Theory]
        [InlineData(0, 5)]
        [InlineData(0.5, 10)]
        [InlineData(2.50, 7.99)]
        [InlineData(8.99, 5.34)]
        [InlineData(10.22, null)]
        [InlineData(null, 10.22)]
        [InlineData(null, null)]
        public void FilterByPriceReturnsACollectionOfItemsWithPriceInRange(double? max, double? min)
        {
            // Collection of all menu items for testing the search and filters.
            List<IOrderItem> AllItems = new List<IOrderItem>()
            {

                    new AngryChicken(),
                    new CowpokeChili(),
                    new DakotaDoubleBurger(),
                    new PecosPulledPork(),
                    new RustlersRibs(),
                    new TexasTripleBurger(),
                    new TrailBurger(),
                    new BakedBeans(),
                    new ChiliCheeseFries(),
                    new CornDodgers(),
                    new PanDeCampo(),
                    new CowboyCoffee(),
                    new JerkedSoda(),
                    new TexasTea(),
                    new Water()
            };

            var results = Menu.FilterByPrice(AllItems, min, max);

            foreach (IOrderItem item in results)
            {
                if (min != null && max != null)
                {
                    Assert.True(item.Price >= min && item.Price <= max);
                }
                else if (min == null && max != null)
                {
                    Assert.True(item.Price <= max);
                }
                else if (min != null && max == null)
                {
                    Assert.True(item.Price >= min);
                }
                else
                {
                    Assert.Equal(results, AllItems);
                }
            }
        }
    }
}
