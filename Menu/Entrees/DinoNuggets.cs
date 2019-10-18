/*  DinoNuggets.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class holding Calories, Price, and Ingredients for DinoNuggets
    /// </summary>
    public class DinoNuggets : Entree
    {   

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
        /// Public Property that returns the ToString() method.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        public override string[] Special => throw new System.NotImplementedException();

        /// <summary>
        /// Public method for adding nuggets. Increments Price and Calories
        /// </summary>
        public void AddNugget()
        {
            this.Price += 0.25;
            this.Calories += 59;
            this.Ingredients.Add("Chicken Nugget");
        }

        /// <summary>
        /// Public Method that returns an override of ToString()
        /// </summary>
        /// <returns>"Dino-Nuggets"</returns>
        public override string ToString()
        {
            return ("Dino-Nuggets");
        }
        
    }
}