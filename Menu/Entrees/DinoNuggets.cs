/*  DinoNuggets.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class holding Calories, Price, and Ingredients for DinoNuggets
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// Public uint holding calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Public list holding ingredients 
        /// </summary>
        public List<string> Ingredients { get; set; }
        /// <summary>
        /// Public double holding price
        /// </summary>
        public double Price { get;  set; }

        /// <summary>
        /// Constructor for DinoNuggets
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
            this.Ingredients = new List<string>()
            {
                "Chicken Nugget", "Chicken Nugget",
                "Chicken Nugget", "Chicken Nugget",
                "Chicken Nugget","Chicken Nugget"
            };
        }
        /// <summary>
        /// Public method for adding nuggets. Increments Price and Calories
        /// </summary>
        public void AddNugget()
        {
            this.Price += 0.25;
            this.Calories += 59;
            this.Ingredients.Add("Chicken Nugget");
        }
    }
}