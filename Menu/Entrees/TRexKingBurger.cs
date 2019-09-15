/*  TRexKingBurger.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class TRexKingBurger contains price, calories, and ingredients
    /// </summary>
    public class TRexKingBurger
    {
        /// <summary>
        /// Private bools for determining ingredients list
        /// </summary>
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool mustard = true;
        private bool ketchup = true;
        private bool mayo = true;

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
        /// Constructor for TRexKingBurger
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
            this.Ingredients = new List<string>()
            {
                "Steakburger Pattie","Steakburger Pattie",
                "Steakburger Pattie"
            };

            //Conditionals for ingredients
            if (bun) this.Ingredients.Add("Whole Wheat Bun");
            if (lettuce) this.Ingredients.Add("Lettuce");
            if (tomato) this.Ingredients.Add("Tomato");
            if (onion) this.Ingredients.Add("Onion");
            if (pickle) this.Ingredients.Add("Pickle");
            if (ketchup) this.Ingredients.Add("Ketchup");
            if (mustard) this.Ingredients.Add("Mustard");
            if (mayo) this.Ingredients.Add("Mayo");
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
        /// Void method that removes Lettuce from ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            this.Ingredients.Remove("Lettuce");
        }
        /// <summary>
        /// Void method that removes Tomato from ingredients list
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            this.Ingredients.Remove("Tomato");
        }
        /// <summary>
        /// Void method that removes Onion from ingredients list
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            this.Ingredients.Remove("Onion");
        }
        /// <summary>
        /// Void method that removes Pickele from ingredients list
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            this.Ingredients.Remove("Pickle");
        }
        /// <summary>
        /// Void method that removes Mustard from ingredients list
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            this.Ingredients.Remove("Mustard");
        }
        /// <summary>
        /// Void method that removes the Mustard from ingredients list 
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            this.Ingredients.Remove("Ketchup");
        }
        /// <summary>
        /// Void method that removes Mayo from the ingredients list
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            this.Ingredients.Remove("Mayo");
        }
    }
}
