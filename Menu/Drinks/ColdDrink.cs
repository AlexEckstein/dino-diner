/*  ColdDrink.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu.Enums;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class that inherits from Drink and includes Ice and HoldIce
    /// </summary>
    public abstract class ColdDrink : IMenuItem
    {
        public bool Ice { get; protected set; }

        public void HoldIce()
        {
            this.Ice = false;
        }

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
