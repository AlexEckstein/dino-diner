/*  TRexKingBurger.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class holding Price, Calories, and Ingredients for VelociWrap
    /// </summary>
    public class VelociWrap
    {
        /// <summary>
        /// Private variables to determine ingredients
        /// </summary>
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients { get; set; }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
            this.Ingredients = new List<string>()
            {
                "Flour Tortilla", "Chicken Breast"
            };
            if (dressing) this.Ingredients.Add("Ceasar Dressing");
            if (lettuce) this.Ingredients.Add("Romaine Lettuce");
            if (cheese) this.Ingredients.Add("Parmesan Cheese");

        }
        /// <summary>
        /// Void method that removes Ceasar Dressing from ingredients list
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            this.Ingredients.Remove("Ceasar Dressing");
        }
        /// <summary>
        /// Void method that removes Romaine Lettuce from ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            this.Ingredients.Remove("Romaine Lettuce");
        }
        /// <summary>
        /// Void method that removes Parmesan Cheese from ingredients list 
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            this.Ingredients.Remove("Parmesan Cheese");
        }
    }
}
