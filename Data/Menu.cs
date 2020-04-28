/* Menu.cs
 * Author: Tristan Larson
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The Menu class represents the menu of items for the Cowboy Cafe.
    /// </summary>
    public static class Menu
    {

        /// <summary>
        /// Method that gets an IEnumerable of all entrees.
        /// </summary>
        /// <returns>An IEnumerable containing an instance of each entree class</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            IEnumerable<IOrderItem> entreeEnumerable = new List<IOrderItem>
            {
                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger()
            };

            return entreeEnumerable;
        }

        /// <summary>
        /// Method that gets an IEnumerable of all sides.
        /// </summary>
        /// <returns>An IEnumerable containing an instance of each side class</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            IEnumerable<IOrderItem> sideEnumerable = new Side[]
            {
                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo()
            };
            return sideEnumerable;
        }

        /// <summary>
        /// Method that gets an IEnumerable of all drinks.
        /// </summary>
        /// <returns>An IEnumerable containing an instance of each drink class</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            IEnumerable<IOrderItem> drinkEnumerable = new Drink[]
            {
                new CowboyCoffee(),
                new TexasTea(),
                new Water(),
                new JerkedSoda()
            };

            return drinkEnumerable;
        }

        /// <summary>
        /// Method that gets an IEnumerable of all items.
        /// </summary>
        /// <returns>An IEnumerable containing an instance of each IOrderItem class</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            IEnumerable<IOrderItem> menuEnumerable = new IOrderItem[]
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

            return menuEnumerable;
        }

        /// <summary>
        /// Filters the given IEnumerable<IOrderItem> based on the given search terms
        /// </summary>
        /// <param name="orderItemsIn">The collection of items to be filtered</param>
        /// <param name="searchTerm">The string to filter by</param>
        /// <returns>A collection of IOrderItems whos ToStrings contain the search terms.</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> orderItemsIn, string searchTerm)
        {

            if (searchTerm == null) { return orderItemsIn; }

            List<IOrderItem> results = new List<IOrderItem>();

            foreach (IOrderItem item in orderItemsIn)
            {
                if(item.ToString().Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the given IEnumerable<IOrderItem> based on the string present in the given IEnumerable<string>
        /// </summary>
        /// <param name="orderItemsIn">The IOrderItems to be filtered</param>
        /// <param name="categories">The IEnumerable<string> containing the strings to filter by.</param>
        /// <returns>IEnumerable<IOrderItem> of the filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> orderItemsIn, IEnumerable<string> categories)
        {
            
            if (categories == null || categories.Count() == 0) { return orderItemsIn; }

            List<IOrderItem> results = new List<IOrderItem>();

            foreach (IOrderItem item in orderItemsIn)
            {
                if (item.GetType().BaseType == typeof(Entree) && categories.Contains("Entree"))
                {
                    results.Add(item);
                }
                else if (item.GetType().BaseType == typeof(Side) && categories.Contains("Side"))
                {
                    results.Add(item);
                }
                else if (item.GetType().BaseType == typeof(Drink) && categories.Contains("Drink"))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the given IEnumerable<IOrderItem> items based on the range given for calories
        /// </summary>
        /// <param name="orderItemsIn">The items to filter</param>
        /// <param name="min">The minimum calories</param>
        /// <param name="max">The maximum calories</param>
        /// <returns>A filtered IEnumerable<IOrderItem> based on the given calorie range</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> orderItemsIn, int? min, int? max)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null && max == null) { return orderItemsIn; }

            if(min != null && max == null)
            {
                foreach(IOrderItem item in orderItemsIn)
                {
                    if (item.Calories >= min)
                    {
                        results.Add(item);
                    }
                }
            }

            if (min == null && max != null)
            {
                foreach (IOrderItem item in orderItemsIn)
                {
                    if (item.Calories <= max)
                    {
                        results.Add(item);
                    }
                }
            }

            if (min != null && max != null)
            {
                foreach (IOrderItem item in orderItemsIn)
                {
                    if (item.Calories >= min && item.Calories <= max)
                    {
                        results.Add(item);
                    }
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the given IEnumerable<IOrderItem> items based on the range given for price
        /// </summary>
        /// <param name="orderItemsIn">The items to filter</param>
        /// <param name="min">The minimum calories</param>
        /// <param name="max">The maximum calories</param>
        /// <returns>A filtered IEnumerable<IOrderItem> based on the given calorie range</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> orderItemsIn, double? min, double? max)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null && max == null) { return orderItemsIn; }

            if (min != null && max == null)
            {
                foreach (IOrderItem item in orderItemsIn)
                {
                    if (item.Price >= min)
                    {
                        results.Add(item);
                    }
                }
            }

            if (min == null && max != null)
            {
                foreach (IOrderItem item in orderItemsIn)
                {
                    if (item.Price <= max)
                    {
                        results.Add(item);
                    }
                }
            }

            if (min != null && max != null)
            {
                foreach (IOrderItem item in orderItemsIn)
                {
                    if (item.Price >= min && item.Price <= max)
                    {
                        results.Add(item);
                    }
                }
            }

            return results;
        }


    }
}
