/*CowpokeChili.cs
 * Author: Nathan Bean
 * Edited by: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class CowpokeChili : Entree
    {
        /// <summary>
        /// Private backing variable for Cheese;
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// If the chili is topped with cheese
        /// </summary>
        public bool Cheese 
        {
            get
            {
                return cheese;
            }
            set 
            {
                cheese = value;
                NotifyPropertyChange("Cheese");
            } 
        }

        /// <summary>
        /// Private backing variable for SoourCream;
        /// </summary>
        private bool sourCream = true;
        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool SourCream
        {
            get
            {
                return sourCream;
            }

            set
            {
                sourCream = value;
                NotifyPropertyChange("SourCream");
            }
        }

        /// <summary>
        /// Private backing variable for GreenOnions;
        /// </summary>
        private bool greenOnions = true;

        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool GreenOnions
        {
            get
            {
                return greenOnions;
            }

            set
            {
                greenOnions = value;
                NotifyPropertyChange("GreenOnions");
            }
        }

        /// <summary>
        /// Private backing variable for TortillaStrips;
        /// </summary>
        public bool tortillaStrips = true;

        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool TortillaStrips
        {
            get { return tortillaStrips; }

            set
            {
                tortillaStrips = value;
                NotifyPropertyChange("TortillaStrips");
            }
        }

        /// <summary>
        /// The price of the chili
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.10;
            }
        }

        /// <summary>
        /// The calories of the chili
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 171;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Cheese) instructions.Add("hold cheese");
                if (!SourCream) instructions.Add("hold sour cream");
                if (!GreenOnions) instructions.Add("hold green onions");
                if (!TortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the Entree name.
        /// </summary>
        /// <returns>Cowpoke Chili</returns>
        public override string ToString()
        {

            return "Cowpoke Chili";
        }

        
    }
}

