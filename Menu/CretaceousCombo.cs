/*  CretaceousCombo.cs
*   Author: Alex Eckstein
*/
using DinoDiner.Menu.Enums;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem
    {
        public Entree Entree;
        public ColdDrink Drink;
        public Side Side;


        /// <summary>
        /// Constructor for Combo Class
        /// </summary>
        /// <param name="e">Entree to pass in</param>
        /// <param name="d">Drink to pass in</param>
        /// <param name="s">Side to pass in</param>
        public CretaceousCombo(Entree e, ColdDrink d, Side s)
        {
            this.Entree = e;
            this.Drink = d;
            this.Side = s;
            this.Size = Size.Small;
            this.Ingredients.AddRange(Entree.Ingredients);
            this.Ingredients.AddRange(Drink.Ingredients);
            this.Ingredients.AddRange(Side.Ingredients);
        }

        public CretaceousCombo(Entree e)
        {
            Entree = e;
            Side = new Fryceritops();
            Drink = new SodaSaurus();
        }
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients { get; private set; }

        /// <summary>
        /// Public Size that changes the size of drink and side
        /// </summary>
        public Size Size
        {
            get
            {
                return this.Size;
            }
            set
            {
                this.Size = value;
                Drink.Size = value;
                Side.Size = value;
                this.Calories = Entree.Calories + Drink.Calories + Side.Calories;
                this.Price = Entree.Price + Drink.Price + Side.Price - 0.25;
            }
        }
        /// <summary>
        /// Override method that prints the items in the Combo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Hello World";
        }
    }
}
