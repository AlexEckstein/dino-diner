/*  Tyrannotea.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu.Enums;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class that holds Tyrannotea
    /// </summary>
    public class Tyrannotea : ColdDrink
    {
        /// <summary>
        /// Public bool holding Sweet
        /// </summary>
        public bool Sweet { get; set; }

        /// <summary>
        /// Public bool holding Lemon
        /// </summary>
        public bool Lemon { get; private set; }
        
        /// <summary>
        /// Public override method that changes Calories and Price based upon size
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
                if (this.Size == Size.Small) { this.Calories = 8; this.Price = 0.99; }
                if (this.Size == Size.Medium) { this.Calories = 16; this.Price = 1.49; }
                if (this.Size == Size.Large) { this.Calories = 32; this.Price = 1.99; }
                if (Sweet)
                {
                    this.Calories = this.Calories * 2;
                    if (!this.Ingredients.Contains("Cane Sugar"))
                    {
                        this.Ingredients.Add("Cane Sugar");
                    }
                }
            }
        }

        /// <summary>
        /// Constructor for Tyrannotea
        /// </summary>
        public Tyrannotea()
        {
            this.Sweet = false;
            this.Lemon = false;
            this.Size = Size.Small;
            this.Ice = true;
            this.Ingredients = new List<string>()
            {
                "Water", "Tea"
            };
        }

        /// <summary>
        /// Void method that changes Lemon to true
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            this.Ingredients.Add("Lemon");
        }
        /// <summary>
        /// Overides ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ($"{Size} Tyrannotea");
        }
    }
}
