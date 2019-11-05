/*  PterodactylWings.cs
*   Author: Alex Eckstein
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class that holds the price, calories and ingredients of PterodactylWings
    /// </summary>
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// The event handler notified is Price, Description, and Special properties.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor for PterodactylWings 
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
            this.Ingredients = new List<string>()
            {
                "Chicken", "Wing Sauce"
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
                if (!Ingredients.Contains("Wing Sauce")) special.Add("Hold sauce");
                return special.ToArray();
            }
        }

        public void HoldSauce()
        {
            this.Ingredients.Remove("Wing Sauce");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");

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
        /// Public Method that returns an override of ToString()
        /// </summary>
        /// <returns>"Pterodactyl Wings"</returns>
        public override string ToString()
        {
            return ("Pterodactyl Wings");
        }
    }
}