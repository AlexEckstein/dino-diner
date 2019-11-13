/*  Water.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu;
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public Class holding Water
    /// </summary>
    public class Water : ColdDrink
    {
        private Size size;

        /// <summary>
        /// The event handler notified is Price, Description, and Special properties.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor for Water
        /// </summary>
        public Water()
        {
            this.size = Size.Small;
            this.Ice = true;
            this.Price = 0.10;
            this.Ingredients = new List<string>()
            {
                "Water"
            };
            this.Calories = 0;
            this.Lemon = false;
        }

        /// <summary>
        /// Override public method for holding ice
        /// </summary>
        public override void HoldIce()
        {
            this.Ice = false;
            this.Ingredients.Remove("Ice");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ice");
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
                if (!Ice) { special.Add("Hold Ice"); }
                if (Lemon) { special.Add("Add Lemon"); }
                return special.ToArray();
            }
        }

        /// <summary>
        /// Override for selecting size
        /// </summary>
        public override Size Size { get { return size; }  set { this.size = value; } }

        /// <summary>
        /// Bool for Lemon
        /// </summary>
        public bool Lemon { get; protected set; }

        /// <summary>
        /// Void private method that is called when an event happens.
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Void method that changes Lemon to true
        /// </summary>
        public void AddLemon()
        {
            this.Ingredients.Add("Lemon");
            this.Lemon = true;
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Lemon");
        }

        /// <summary>
        /// Public Method that returns an override of ToString()
        /// </summary>
        /// <returns>Size & Water</returns>
        public override string ToString()
        {
            return ($"{Size} Water");
        }
    }
}
