/*  Sodasaurus.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class for Sodasaurus
    /// </summary>
    public class SodaSaurus : ColdDrink
    {
        /// <summary>
        /// Private Backing variables
        /// </summary>
        private Size size;
        private SodasaurusFlavor flavor;

        /// <summary>
        /// The event handler notified is Price, Description, and Special properties.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor for Sodasaurus
        /// </summary>
        public SodaSaurus()
        {
            this.size = Size.Small;
            this.Ice = true;
            this.Flavor = SodasaurusFlavor.Cola;
            this.Ingredients = new List<string> { "Ice", "Sugar", "Water" };
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
                if (Ice) { special.Add("Hold Ice"); }
                return special.ToArray();
            }
        }

        /// <summary>
        /// Public enum that holds the Flavor
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Override Property that changes price and calories based upon size
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
                if (this.size == Size.Small) { this.Calories = 222; this.Price = 0.99; }
                if (this.size == Size.Medium) { this.Calories = 365; this.Price = 1.45; }
                if (this.size == Size.Large) { this.Calories = 480; this.Price = 1.95; }
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Price");
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
            NotifyOfPropertyChange("Ice");
            NotifyOfPropertyChange("Special");
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
