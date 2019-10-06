/*  PterodactylWings.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class that holds the price, calories and ingredients of PterodactylWings
    /// </summary>
    public class PterodactylWings : Entree
    {
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
        public override string ToString()
        {
            return ("Pterodactyl Wings");
        }
    }
}