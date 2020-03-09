/*TexasTripleBurger.cs
 * Author: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the TexasTripleBurger
    /// </summary>
    public class TexasTripleBurger : Entree
    {
        /// <summary>
        /// Price of the TexasTripleBurger
        /// </summary>
        public override double Price { get; } = 6.45;

        /// <summary>
        /// Calorie content of the TexasTripleBurger
        /// </summary>
        public override uint Calories { get; } = 698;

        private bool bun = true;
        /// <summary>
        /// Boolean flag for a Bun on the TexasTripleBurger
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
        /// Boolean flag for Ketchup on the TexasTripleBurger
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
        /// Boolean flag for Mustard on the TexasTripleBurger
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
        /// Boolean flag for Pickle on the TexasTripleBurger
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
        /// Boolean flag for Cheese on the TexasTripleBurger
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
        /// Boolean flag for Tomato on the TexasTripleBurger
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
        /// Boolean flag for Lettuce on the TexasTripleBurger
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
        /// Boolean flag for Mayo on the TexasTripleBurger
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

        private bool bacon = true;
        /// <summary>
        /// Boolean flag for Bacon on the TexasTripleBurger
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }

            set
            {
                bacon = value;
                NotifyPropertyChange("Bacon");
            }
        }

        private bool egg = true;
        /// <summary>
        /// Boolean flag for Egg on the TexasTripleBurger
        /// </summary>
        public bool Egg
        {
            get { return egg; }

            set
            {
                egg = value;
                NotifyPropertyChange("Egg");
            }
        }

        /// <summary>
        /// Special instructions for the TexasTripleBurger
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
                if (!Bacon) { instructions.Add("hold bacon"); }
                if (!Egg) { instructions.Add("hold egg"); }

                return instructions;
            }
        }

        /// <summary>
        /// Returns the Entree name.
        /// </summary>
        /// <returns>Texas Triple Burger</returns>
        public override string ToString()
        {

            return "Texas Triple Burger";
        }


    }
}
