/*  TRexKingBurger.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class holding Price, Calories, and Ingredients for VelociWrap
    /// </summary>
    public class VelociWrap : Entree
    {

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
            this.Ingredients = new List<string>()
            {
                "Flour Tortilla", "Chicken Breast",
                "Parmesan Cheese","Romaine Lettuce",
                "Ceasar Dressing"
            };
        }
        /// <summary>
        /// Void method that removes Ceasar Dressing from ingredients list
        /// </summary>
        public void HoldDressing()
        {
            this.Ingredients.Remove("Ceasar Dressing");
        }
        /// <summary>
        /// Void method that removes Romaine Lettuce from ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.Ingredients.Remove("Romaine Lettuce");
        }
        /// <summary>
        /// Void method that removes Parmesan Cheese from ingredients list 
        /// </summary>
        public void HoldCheese()
        {
            this.Ingredients.Remove("Parmesan Cheese");
        }
        public override string ToString()
        {
            return ("Veloci-Wrap");
        }
    }
}
