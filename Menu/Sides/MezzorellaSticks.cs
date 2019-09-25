/*  Mezzorellasticks.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;
using DinoDiner.Menu.Enums;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// MezzorellaSticks Class that inherits from Side
    /// </summary>
    public class MezzorellaSticks: Side
    {
        public MezzorellaSticks()
        {
            this.Size = Size.Small;
            this.Ingredients = new List<string>()
            {
                "Cheese Product",
                "Breading",
                "Vegtable Oil"
            };
        }
        /// <summary>
        /// Changes Calories and Price according to size
        /// </summary>
        public override Size Size
        {
            get {
                return this.Size;
            }
            set {
                this.Size = value;
                if (this.Size == Size.Small) { this.Calories = 540; this.Price = 0.99; }
                if (this.Size == Size.Medium){ this.Calories = 610; this.Price = 1.45; }
                if (this.Size == Size.Large) { this.Calories = 720; this.Price = 1.95; }
            }
        }
    }
}
