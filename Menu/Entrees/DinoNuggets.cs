/*  DinoNuggets.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class holding Calories, Price, and Ingredients for DinoNuggets
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// The event handler notified is Price, Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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

        /// <summary>
        /// Public Property that returns the Special changes made to PBJ.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                int x = 0;
                foreach (string value in Ingredients)
                {
                    if (value == "Chicken Nugget") { x++; }
                }
                x -= 6;
                if (x > 0)
                {
                    special.Add($"{x} Extra Nuggets");
                }
                return special.ToArray();
            }
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
        /// Public method for adding nuggets. Increments Price and Calories
        /// </summary>
        public void AddNugget()
        {
            this.Price += 0.25;
            this.Calories += 59;
            this.Ingredients.Add("Chicken Nugget");

            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Calories");
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