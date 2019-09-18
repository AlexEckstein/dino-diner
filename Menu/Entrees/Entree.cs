/*  Entree.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    public abstract class Entree
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
        public List<string> Ingredients { get; }
    }
}
