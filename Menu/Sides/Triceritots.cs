﻿/*  Triceritots.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Triceritots Class that inherits from Side
    /// </summary>
    public class Triceritots : Side
    {
        /// <summary>
        /// The event handler notified is Price, Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();

                return special.ToArray();
            }
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
                if (this.Size == Size.Small) { this.Calories = 352; this.Price = 0.99; }
                if (this.Size == Size.Medium) { this.Calories = 410; this.Price = 1.45; }
                if (this.Size == Size.Large) { this.Calories = 590; this.Price = 1.95; }
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
        /// Overrides the default ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (Size.ToString() + " Triceritots");
        }
    }
}
