/*  Triceritots.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu.Enums;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Triceritots Class that inherits from Side
    /// </summary>
    public class Triceritots : Side
    {
        /// <summary>
        /// Constructor for Triceritots
        /// </summary>
        public Triceritots()
        {
            this.Size = Size.Small;
            this.Calories = 352;
            this.Price = 0.99;
            this.Ingredients = new List<string>()
            {
                "Potatoes",
                "Salt",
                "Vegtable Oil"
            };
        }

        /// <summary>
        /// Public Property that returns the ToString() method.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        public override string[] Special => throw new System.NotImplementedException();

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
                if (this.Size == Size.Small) { this.Calories = 352; this.Price = 0.99; }
                if (this.Size == Size.Medium) { this.Calories = 410; this.Price = 1.45; }
                if (this.Size == Size.Large) { this.Calories = 590; this.Price = 1.95; }
            }
        }
        /// <summary>
        /// Overrides the default ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (Size.ToString() + " Triceritots");
        }
    }
}
