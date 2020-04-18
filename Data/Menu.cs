/* Menu.cs
 * Author: Tristan Larson
 * 
 */
using System;
using System.Collections.Generic;
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
            IEnumerable<IOrderItem> entreeEnumerable = new Entree[]
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
                new JerkedSoda(),
                new TexasTea(),
                new Water()
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
    }
}
