/*  SodaSaurus.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class for SodaSaurus
    /// </summary>
    public class SodaSaurus : ColdDrink
    {
        /// <summary>
        /// The event handler notified is Price, Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor for SodaSaurus
        /// </summary>
        public SodaSaurus()
        {
            this.Size = Size.Small;
            this.Ice = true;
            this.Flavor = SodaSaurusFlavor.Cola;
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
        /// Public enum that holds the Flavor
        /// </summary>
        public SodaSaurusFlavor Flavor { get; set; }

        /// <summary>
        /// Override Property that changes price and calories based upon size
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.Size;
            }
            set
            {
                this.Size = value;
                if (this.Size == Size.Small) { this.Calories = 222; this.Price = 0.99; }
                if (this.Size == Size.Medium) { this.Calories = 365; this.Price = 1.45; }
                if (this.Size == Size.Large) { this.Calories = 480; this.Price = 1.95; }
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
        /// Override public method for holding ice
        /// </summary>
        public override void HoldIce()
        {
            this.Ice = false;
            this.Ingredients.Remove("Ice");
        }
        /// <summary>
        /// Overides ToString method
        /// </summary>
        /// <returns> Returns Size Flavor and Sodasaurus</returns>
        public override string ToString()
        {
            return ($"{Size} {Flavor} Sodasaurus");
        }
    }
}
