/*  Fryceritops.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu.Enums;
using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Public class Fryceritops inheritance from Side
    /// </summary>
    public class Fryceritops : Side
    {

        public Fryceritops()
        {
            this.Size = Size.Small;
            this.Calories = 222;
            this.Price = 0.99;
            this.Ingredients = new List<string>()
            {
                "Potato",
                "Salt",
                "Vegtable Oil"
            };

        }
        /// <summary>
        /// Changes Calories and Price according to size
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
    }
}
