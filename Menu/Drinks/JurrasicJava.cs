/*  JurassicJava.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public Class holding JurassicJava
    /// </summary>
    public class JurassicJava : ColdDrink
    {
        private Size size;

        /// <summary>
        /// The event handler notified is Price, Description, and Special properties.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor for JurassicJava
        /// </summary>
        public JurassicJava()
        {
            this.Ice = false;
            this.size = Size.Small;
            this.Decaf = false;
            this.Ingredients = new List<string>
            {
                "Water", "Coffee"
            };
        }

        /// <summary>
        /// Override method that holds the Size Property
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
                if (this.size == Size.Small) { this.Calories = 2; this.Price = 0.59; }
                if (this.size == Size.Medium) { this.Calories = 4; this.Price = 0.99; }
                if (this.size == Size.Large) { this.Calories = 8; this.Price = 1.49; }
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Price");
            }
        }

        /// <summary>
        /// Public Property that holds the bool RoomForCream
        /// </summary>
        public bool RoomForCream { get; private set; }

        /// <summary>
        ///  Public Property that holds the bool Decaf
        /// </summary>
        public bool Decaf { get; private set; }

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
                if (this.Ice) special.Add("Add Ice");
                if (this.RoomForCream) special.Add("");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Void method that changes RoomForCream to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Void method that changes Ice to true
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ice");
        }

        /// <summary>
        /// Void method that sets private Property Decaf to true
        /// </summary>
        public void MakeDecaf()
        {
            this.Decaf = true;
            NotifyOfPropertyChange("Decaf");
        }

        /// <summary>
        /// Public Method that returns an override of ToString()
        /// </summary>
        /// <returns>Regular Jurassic Java or Decaf</returns>
        public override string ToString()
        {
            if (Decaf)
                return (Size.ToString() + " Decaf Jurassic Java");
            else
                return (Size.ToString() + " Jurassic Java");
        }
    }
}
