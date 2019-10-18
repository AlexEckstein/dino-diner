﻿/*  Water.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu.Enums;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public Class holding Water
    /// </summary>
    public class Water : ColdDrink
    {
        
        /// <summary>
        /// Constructor for Water
        /// </summary>
        public Water()
        {
            this.Size = Size.Small;
            this.Ice = true;
            this.Price = 0.10;
            this.Ingredients = new List<string>()
            {
                "Water"
            };
            this.Calories = 0;
            this.Lemon = false;
        }
        
        /// <summary>
        /// Override for selecting size
        /// </summary>
        public override Size Size { get; set; }

        /// <summary>
        /// Bool for Lemon
        /// </summary>
        public bool Lemon { get; protected set; }

        /// <summary>
        /// Void method that changes Lemon to true
        /// </summary>
        public void AddLemon()
        {
            this.Ingredients.Add("Lemon");
            this.Lemon = true;
        }

        /// <summary>
        /// Public Method that returns an override of ToString()
        /// </summary>
        /// <returns>Size & Water</returns>
        public override string ToString()
        {
            return ($"{Size} Water");
        }
    }
}
