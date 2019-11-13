/*  Tyrannotea.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class that holds Tyrannotea
    /// </summary>
    public class Tyrannotea : ColdDrink
    {
        private Size size;

        /// <summary>
        /// The event handler notified is Price, Description, and Special properties.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor for Tyrannotea
        /// </summary>
        public Tyrannotea()
        {
            this.Sweet = false;
            this.Lemon = false;
            this.size = Size.Small;
            this.Ice = true;
            this.Price = 0.99;
            this.Calories = 8;
            this.Ingredients = new List<string>()
            {
                "Water", "Tea"
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
                if (!Ice) { special.Add("Hold Ice"); }
                if (Lemon) { special.Add("Add Lemon"); }
                return special.ToArray();
            }
        }
        /// <summary>
        /// Public bool holding Lemon
        /// </summary>
        public bool Lemon { get; private set; }

        /// <summary>
        /// Public bool Property holding Sweet
        /// </summary>
        public bool Sweet { get; set; }

        /// <summary>
        /// Public override method that changes Calories and Price based upon size
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
                if (this.size == Size.Small) { this.Calories = 8; this.Price = 0.99; }
                if (this.size == Size.Medium) { this.Calories = 16; this.Price = 1.49; }
                if (this.size == Size.Large) { this.Calories = 32; this.Price = 1.99; }
                if (Sweet)
                {
                    this.Calories = this.Calories * 2;
                    if (!this.Ingredients.Contains("Cane Sugar"))
                    {
                        this.Ingredients.Add("Cane Sugar");
                        NotifyOfPropertyChange("Ingredients");
                    }
                }
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
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
        /// Override public method for holding ice
        /// </summary>
        public override void HoldIce()
        {
            this.Ice = false;
            this.Ingredients.Remove("Ice");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ice");
        }

        /// <summary>
        /// Void method that changes Lemon to true
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            this.Ingredients.Add("Lemon");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Lemon");
        }

        /// <summary>
        /// Public Method that returns an override of ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string name = $"{size}";
            if (Sweet) name += " Sweet";
            return (name + " Tyrannotea");
        }
    }
}
