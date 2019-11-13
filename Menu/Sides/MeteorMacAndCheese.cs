/*  MeteorMacAndCheese.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// MeteorMacAndCheese class that inherits from Side
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        private Size size;

        /// <summary>
        /// The event handler notified is Price, Description, and Special properties.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        public MeteorMacAndCheese()
        {
            this.size = Size.Small;
            this.Calories = 420;
            this.Price = 0.99;
            this.Ingredients = new List<string>()
            {
                "Macaroni Noodles",
                "Cheese Product",
                "Pork Sausage"
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
                return this.size;
            }
            set
            {
                this.size = value;
                if (this.size == Size.Small) this.Calories = 420; this.Price = 0.99;
                if (this.size == Size.Medium) this.Calories = 490; this.Price = 1.45;
                if (this.size == Size.Large) this.Calories = 520; this.Price = 1.95;
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
            return (Size.ToString() + " Meteor Mac and Cheese");
        }
    }
}
