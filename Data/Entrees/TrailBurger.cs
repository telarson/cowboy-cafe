/*Trailburger.cs
 * Author: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representation of the Trailburger entree
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// Price for the Trailburger entree
        /// </summary>
        public override double Price { get; } = 4.50;

        /// <summary>
        /// Calorie content for the Trailburger entree
        /// </summary>
        public override uint Calories { get; } = 288;

        private bool bun = true;
        /// <summary>
        /// Boolean flag for a Bun on the TrailBurger
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
        /// Boolean flag for Ketchup on the TrailBurger
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
        /// Boolean flag for Mustard on the TrailBurger
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
        /// Boolean flag for Pickle on the TrailBurger
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
        /// Boolean flag for Cheese on the TrailBurger
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

        /// <summary>
        /// Special instructions for the Trailburger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bun) { instructions.Add("hold bun"); }
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if(!Mustard) { instructions.Add("hold mustard"); }
                if(!Cheese) { instructions.Add("hold cheese"); }
                if (!Pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }
        }

        /// <summary>
        /// Returns the Entree name.
        /// </summary>
        /// <returns>Trail Burger</returns>
        public override string ToString()
        {

            return "Trail Burger";
        }
    }
}
