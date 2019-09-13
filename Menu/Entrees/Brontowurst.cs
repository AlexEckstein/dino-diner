using System;
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        private List<string> ingredients = new List<string>() { "brautwurst", "whole-wheat bun", "peppers", "onions" };
        private double price;
        private uint calories;
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public List<string> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        public uint Calories
        {
            get { return calories; }
            set { calories = value; }
        }
        /// <summary>
        /// Constructor of the class, adds ingredients to list if not held
        /// </summary>
        public Brontowurst()
        {
            this.Calories = 498;
            this.Price = 5.36;
            
            if (bun) ingredients.Add("whole-wheat bun");
            if (peppers) ingredients.Add("pepers");
            if (onions) ingredients.Add("onions");
            this.Ingredients = ingredients;
        }
        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
