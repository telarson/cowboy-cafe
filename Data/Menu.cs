/* Menu.cs
 * Author: Tristan Larson
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
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
            List<IOrderItem> results = new List<IOrderItem>();

            if (searchTerm == null) { return orderItemsIn; }

            foreach(IOrderItem item in orderItemsIn)
            {
                if(item.ToString().Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> orderItemsIn, IEnumerable<string> categories)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (categories.Count() == 0) { return orderItemsIn; }

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
    }
}
