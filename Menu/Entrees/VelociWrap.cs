/*  VelociWrap.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class holding Price, Calories, and Ingredients for VelociWrap
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// The event handler notified is Price, Description, and Special properties.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

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

                if (!Ingredients.Contains("Ceasar Dressing")) special.Add("Hold Ceasar Dressing");
                if (!Ingredients.Contains("Romaine Lettuce")) special.Add("Hold Romaine Lettuce");
                if (!Ingredients.Contains("Parmesan Cheese")) special.Add("Hold Parmesan Cheese");
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
        /// Void method that removes Ceasar Dressing from ingredients list
        /// </summary>
        public void HoldDressing()
        {
            this.Ingredients.Remove("Ceasar Dressing");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Void method that removes Romaine Lettuce from ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.Ingredients.Remove("Romaine Lettuce");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Void method that removes Parmesan Cheese from ingredients list 
        /// </summary>
        public void HoldCheese()
        {
            this.Ingredients.Remove("Parmesan Cheese");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Public Method that returns an override of ToString()
        /// </summary>
        /// <returns>"Veloci-Wrap"</returns>
        public override string ToString()
        {
            return ("Veloci-Wrap");
        }
    }
}
