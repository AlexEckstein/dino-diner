/*  Brontowurst.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class that holds the price, calories and ingredients of Brontowurst
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// The event handler notified is Price, Description, and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor of the class, adds ingredients to list if not held
        /// </summary>
        public Brontowurst()
        {
            this.Calories = 498;
            this.Price = 5.36;
            this.Ingredients = new List<string>()
            {
                "Brautwurst","Whole Wheat Bun",
                "Peppers","Onion"
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
        /// Void method that removes Bun from ingredients list 
        /// </summary>
        public void HoldBun()
        {
            this.Ingredients.Remove("Whole Wheat Bun");
        }
        /// <summary>
        /// Void method that removes Peppers from ingredients list
        /// </summary>
        public void HoldPeppers()
        {
            this.Ingredients.Remove("Peppers");
        }
        /// <summary>
        /// Void method that removes Onions from ingredients list
        /// </summary>
        public void HoldOnion()
        {
            this.Ingredients.Remove("Onion");
        }
        /// <summary>
        /// Public Method that returns an override of ToString()
        /// </summary>
        /// <returns>"Brontowurst"</returns>
        public override string ToString()
        {
            return ("Brontowurst");
        }
    }
}
