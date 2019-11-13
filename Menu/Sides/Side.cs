/*  Side.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Side : IMenuItem, IOrderItem
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
        public abstract string Description { get; }
        public abstract string[] Special { get; }

        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
