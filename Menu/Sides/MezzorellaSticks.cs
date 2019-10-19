/*  Mezzorellasticks.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// MezzorellaSticks Class that inherits from Side
    /// </summary>
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// The event handler notified is Price, Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public MezzorellaSticks()
        {
            this.Size = Size.Small;
            this.Ingredients = new List<string>()
            {
                "Cheese Product",
                "Breading",
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
                if (this.Size == Size.Small) { this.Calories = 540; this.Price = 0.99; }
                if (this.Size == Size.Medium) { this.Calories = 610; this.Price = 1.45; }
                if (this.Size == Size.Large) { this.Calories = 720; this.Price = 1.95; }
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
            return (Size.ToString() + " Mezzorella Sticks");
        }
    }
}
