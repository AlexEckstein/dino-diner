/*  SteakosaurusBurger.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class that holds the price, calories and ingredients of SteakosaurusBurger
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// The event handler notified is Price, Description, and Special properties.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

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
        /// Void private method that is called when an event happens.
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
                if (!Ingredients.Contains("Whole Wheat Bun")) special.Add("Hold Bun");
                if (!Ingredients.Contains("Pickle")) special.Add("Hold Pickle");
                if (!Ingredients.Contains("Ketchup")) special.Add("Hold Ketchup");
                if (!Ingredients.Contains("Mustard")) special.Add("Hold Mustard");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Void method that removes Bun from ingredients list
        /// </summary>
        public void HoldBun()
        {
            this.Ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Void method that removes Pickle from ingredients list
        /// </summary>
        public void HoldPickle()
        {
            this.Ingredients.Remove("Pickle");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Void method that removes Ketchup from ingredients list
        /// </summary>
        public void HoldKetchup()
        {
            this.Ingredients.Remove("Ketchup");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Void method that removes Mustard from ingredients list
        /// </summary>
        public void HoldMustard()
        {
            this.Ingredients.Remove("Mustard");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Public Method that returns an override of ToString()
        /// </summary>
        /// <returns>"Steakosaurus Burger"</returns>
        public override string ToString()
        {
            return ("Steakosaurus Burger");
        }
    }
}