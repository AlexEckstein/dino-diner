/*  SteakosaurusBurger.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class that holds the price, calories and ingredients of SteakosaurusBurger
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Constructor for SteakosaurusBurger
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
            this.Ingredients = new List<string>()
            {
                "Steakburger Pattie",
                "Whole Wheat Bun",
                "Pickle",
                "Ketchup",
                "Mustard"
            };
        }
        /// <summary>
        /// Void method that removes Bun from ingredients list
        /// </summary>
        public void HoldBun()
        {
            this.Ingredients.Remove("Whole Wheat Bun");
        }
        /// <summary>
        /// Void method that removes Pickle from ingredients list
        /// </summary>
        public void HoldPickle()
        {
            this.Ingredients.Remove("Pickle");
        }
        /// <summary>
        /// Void method that removes Ketchup from ingredients list
        /// </summary>
        public void HoldKetchup()
        {
            this.Ingredients.Remove("Ketchup");
        }
        /// <summary>
        /// Void method that removes Mustard from ingredients list
        /// </summary>
        public void HoldMustard()
        {
            this.Ingredients.Remove("Mustard");
        }
        public override string ToString()
        {
            return ("Steakosaurus Burger");
        }
    }
}