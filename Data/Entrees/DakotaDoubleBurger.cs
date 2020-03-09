/*DakotaDoubleBurger.cs
 * Author: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class for the DakotaDoubleBurger
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// Price of the DakotaDoubleBurger
        /// </summary>
        public override double Price { get; } = 5.20;

        /// <summary>
        /// Calorie content of the DakotaDoubleBurger
        /// </summary>
        public override uint Calories { get; } = 464;

        private bool bun = true;
        /// <summary>
        /// Boolean flag for a Bun on the DakotaDoubleBurger
        /// </summary>
        public bool Bun
        {
            get { return bun; }

            set
            {
                bun = value;
                NotifyPropertyChange("Bun");
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// Boolean flag for Ketchup on the DakotaDoubleBurger
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }

            set
            {
                ketchup = value;
                NotifyPropertyChange("Ketchup");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// Boolean flag for Mustard on the DakotaDoubleBurger
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }

            set
            {
                mustard = value;
                NotifyPropertyChange("Mustard");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// Boolean flag for Pickle on the DakotaDoubleBurger
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }

            set
            {
                pickle = value;
                NotifyPropertyChange("Pickle");
            }
        }

        private bool cheese = true;
        /// <summary>
        /// Boolean flag for Cheese on the DakotaDoubleBurger
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }

            set
            {
                cheese = value;
                NotifyPropertyChange("Cheese");
            }
        }

        private bool tomato = true;
        /// <summary>
        /// Boolean flag for Tomato on the DakotaDoubleBurger
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }

            set
            {
                tomato = value;
                NotifyPropertyChange("Tomato");
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// Boolean flag for Lettuce on the DakotaDoubleBurger
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }

            set
            {
                lettuce = value;
                NotifyPropertyChange("Lettuce");
            }
        }

        private bool mayo = true;
        /// <summary>
        /// Boolean flag for Mayo on the DakotaDoubleBurger
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }

            set
            {
                mayo = value;
                NotifyPropertyChange("Mayo");

            }
        }

        /// <summary>
        /// Special instructions for the DakotaDoubleBurger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bun) { instructions.Add("hold bun"); }
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if (!Mustard) { instructions.Add("hold mustard"); }
                if (!Cheese) { instructions.Add("hold cheese"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Tomato) { instructions.Add("hold tomato"); }
                if (!Lettuce) { instructions.Add("hold lettuce"); }
                if (!Mayo) { instructions.Add("hold mayo"); }

                return instructions;
            }
        }

        /// <summary>
        /// Returns the Entree name.
        /// </summary>
        /// <returns>Dakota Double Burger</returns>
        public override string ToString()
        {

            return "Dakota Double Burger";
        }
    }
}
