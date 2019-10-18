/*  SodaSaurus.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu.Enums;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class for SodaSaurus
    /// </summary>
    public class SodaSaurus : ColdDrink
    {
        

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
        /// Overides ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ($"{Size} {Flavor} Sodasaurus");
        }
    }
}
