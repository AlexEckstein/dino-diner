/*  TRexKingBurger.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class TRexKingBurger contains price, calories, and ingredients
    /// </summary>
    public class TRexKingBurger : Entree
    {
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
                "Steakburger Pattie", "Whole Wheat Bun",
                "Lettuce","Tomato","Onion","Pickle",
                "Ketchup","Mustard","Mayo"
            };
        }

        /// <summary>
        /// Public Property that returns the ToString() method.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ingredients.Contains("Whole Wheat Bun")) special.Add("Hold Whole Wheat Bun");
                if (!Ingredients.Contains("Pickle")) special.Add("Hold Pickle");
                if (!Ingredients.Contains("Ketchup")) special.Add("Hold Ketchup");
                if (!Ingredients.Contains("Mustard")) special.Add("Hold Mustard");
                if (!Ingredients.Contains("Lettuce")) special.Add("Hold Lettuce");
                if (!Ingredients.Contains("Tomato")) special.Add("Hold Tomato");
                if (!Ingredients.Contains("Onion")) special.Add("Hold Onion");
                if (!Ingredients.Contains("Mayo")) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Void method that removes Bun from ingredients list
        /// </summary>
        public void HoldBun()
        {
            this.Ingredients.Remove("Whole Wheat Bun");
        }
        /// <summary>
        /// Void method that removes Lettuce from ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.Ingredients.Remove("Lettuce");
        }
        /// <summary>
        /// Void method that removes Tomato from ingredients list
        /// </summary>
        public void HoldTomato()
        {
            this.Ingredients.Remove("Tomato");
        }
        /// <summary>
        /// Void method that removes Onion from ingredients list
        /// </summary>
        public void HoldOnion()
        {
            this.Ingredients.Remove("Onion");
        }
        /// <summary>
        /// Void method that removes Pickele from ingredients list
        /// </summary>
        public void HoldPickle()
        {
            this.Ingredients.Remove("Pickle");
        }
        /// <summary>
        /// Void method that removes Mustard from ingredients list
        /// </summary>
        public void HoldMustard()
        {
            this.Ingredients.Remove("Mustard");
        }
        /// <summary>
        /// Void method that removes the Mustard from ingredients list 
        /// </summary>
        public void HoldKetchup()
        {
            this.Ingredients.Remove("Ketchup");
        }
        /// <summary>
        /// Void method that removes Mayo from the ingredients list
        /// </summary>
        public void HoldMayo()
        {
            this.Ingredients.Remove("Mayo");
        }
        /// <summary>
        /// Public Method that returns an override of ToString()
        /// </summary>
        /// <returns>"TRex King Burger"</returns>
        public override string ToString()
        {
            return ("TRex King Burger");
        }
    }
}