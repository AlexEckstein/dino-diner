/*  JurrasicJava.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu.Enums;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public Class holding JurrasicJava
    /// </summary>
    public class JurrasicJava : ColdDrink
    {
        /// <summary>
        /// Public Bool for Leaving Room For Cream
        /// </summary>
        public bool RoomForCream = false;
        public override Size Size
        {
            get
            {
                return this.Size;
            }
            set
            {
                this.Size = value;
                if (this.Size == Size.Small) { this.Calories = 2; this.Price = 0.59; }
                if (this.Size == Size.Medium) { this.Calories = 4; this.Price = 0.99; }
                if (this.Size == Size.Large) { this.Calories = 8; this.Price = 1.49; }
            }
        }

        public bool Decaf { get; private set; }

        /// <summary>
        /// Constructor for JurrasicJava
        /// </summary>
        public JurrasicJava()
        {
            this.Ice = false;
            this.Size = Size.Small;
            this.Ingredients = new List<string>
            {
                "Water", "Coffee"
            };
        }

        /// <summary>
        /// Void method that changes RoomForCream to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// Void method that changes Ice to true
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }
        public void MakeDecaf()
        {
            this.Decaf = true;
        }
        public override string ToString()
        {
            if (!Decaf)
                return (Size.ToString() + " Jurassic Java");
            else
                return (Size.ToString() + " Decaf Jurassic Java");

        }
    }
}
