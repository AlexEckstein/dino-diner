/*  SteakosaurusBurger.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class that holds the price, calories and ingredients of SteakosaurusBurger
    /// </summary>
    public class SteakosaurusBurger
    {
        /// <summary>
        /// Private bools for determining ingredients list
        /// </summary>
        private bool bun = true;
        private bool pickle = true;
        private bool mustard = true;
        private bool ketchup = true;

        /// <summary>
        /// Public double holding price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Public uint holding calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Public list holding ingredients
        /// </summary>
        public List<string> Ingredients { get; set; }

        /// <summary>
        /// Constructor for SteakosaurusBurger
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
            this.Ingredients = new List<string>()
            {
                "Steakburger Pattie"
            };

            if (bun) this.Ingredients.Add("Whole Wheat Bun");
            if (pickle) this.Ingredients.Add("Pickle");
            if (ketchup) this.Ingredients.Add("Ketchup");
            if (mustard) this.Ingredients.Add("Mustard");
        }
        /// <summary>
        /// Void method that removes Bun from ingredients list
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            this.Ingredients.Remove("Whole Wheat Bun");
        }
        /// <summary>
        /// Void method that removes Pickle from ingredients list
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            this.Ingredients.Remove("Pickle");
        }
        /// <summary>
        /// Void method that removes Ketchup from ingredients list
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            this.Ingredients.Remove("Ketchup");
        }
        /// <summary>
        /// Void method that removes Mustard from ingredients list
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            this.Ingredients.Remove("Mustard");
        }

    }
}