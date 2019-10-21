/*  PrehistoricPBJ.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// The event handler notified is Price, Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor for PBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
            this.Ingredients = new List<string>()
            {
                "Bread",
                "Peanut Butter",
                "Jelly"
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
                if (!Ingredients.Contains("Peanut Butter")) special.Add("Hold Peanut Butter");
                if (!Ingredients.Contains("Jelly")) special.Add("Hold Jelly");
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
        /// Public void method that removes Peanut Butter and notifies that a property was changed.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.Ingredients.Remove("Peanut Butter");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Public void method that removes Jelly and notifies that a property was changed.
        /// </summary>
        public void HoldJelly()
        {
            this.Ingredients.Remove("Jelly");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Public Method that returns an override of ToString()
        /// </summary>
        /// <returns>"Prehistoric PB&J"</returns>
        public override string ToString()
        {
            return ("Prehistoric PB&J");
        }
    }
}
