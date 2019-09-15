/*  Brontowurst.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class that holds the price, calories and ingredients of Brontowurst
    /// </summary>
    public class Brontowurst
    {
        /// <summary>
        /// Private variables for Brontowurst class
        /// </summary>
        private double price;
        private uint calories;
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// Public double holding price
        /// </summary>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        /// <summary>
        /// Public list holding Ingredients
        /// </summary>
        public List<string> Ingredients { get; set; }
        /// <summary>
        /// Public uint holding calories
        /// </summary>
        public uint Calories
        {
            get { return calories; }
            set { calories = value; }
        }
        /// <summary>
        /// Constructor of the class, adds ingredients to list if not held
        /// </summary>
        public Brontowurst()
        {
            this.Calories = 498;
            this.Price = 5.36;
            this.Ingredients = new List<string>()
            {
                "Brautwurst"
            };
            if (bun) Ingredients.Add("Whole Wheat Bun");

            if (peppers) Ingredients.Add("Peppers");

            if (onions) Ingredients.Add("Onion");
            
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
        /// Void method that removes Peppers from ingredients list
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            this.Ingredients.Remove("Peppers");
        }
        /// <summary>
        /// Void method that removes Onions from ingredients list
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            this.Ingredients.Remove("Onion");
        }
    }
}
