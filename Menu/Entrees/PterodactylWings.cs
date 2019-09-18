/*  PterodactylWings.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

    namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class that holds the price, calories and ingredients of PterodactylWings
    /// </summary>
    public class PterodactylWings : Entree
    {
        
        /// <summary>
        /// Public list holding ingredients
        /// </summary>
        public List<string> Ingredients { get; set; }
        /// <summary>
        /// Constructor for PterodactylWings 
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
            this.Ingredients = new List<string>()
            {
                "Chicken", "Wing Sauce"
            };

        }
    }
}