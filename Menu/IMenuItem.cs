/*  IMenuItem.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for Menu Item
    /// </summary>
    public interface IMenuItem 
    {

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        List<string> Ingredients { get; }
    }
}