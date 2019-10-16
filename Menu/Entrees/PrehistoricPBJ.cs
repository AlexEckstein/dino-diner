using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// The event handler notified is Price, Description, and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ingredients.Contains("Peanut Butter")) special.Add("Hold Peanut Butter");
                if (!Ingredients.Contains("Jelly")) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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

        public void HoldPeanutButter()
        {
            this.Ingredients.Remove("Peanut Butter");
            NotifyOfPropertyChange("Special");
        }

        public void HoldJelly()
        {
            this.Ingredients.Remove("Jelly");
            NotifyOfPropertyChange("Special");
        }
        public override string ToString()
        {
            return ("Prehistoric PB&J");
        }
    }
}
