/*  Drink.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class of Drink
    /// </summary>
    public abstract class Drink : IMenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

    }
}
