using System;

namespace DinoDiner.Menu.Entree
{
    public class Brontowurst
    {
        public Brontowurst()
        {
            private List<string> ingredients;
            private double price;
            private unit calories;
            public double Price
            {
                get { return price; }
                set { price = 5.36; }
            }

            public List<string> Ingredients
            {
                get { return ingredients; }
                set { ingredients =  ["brautwurst", "whole-wheat bun", "peppers", "onions"]; }
            }
            public unit Calories
            {
                get { return calories; }
                set { calories = 498; }
            }
        }

    public void Bun();
    public void Pepper();
    public void onions();

    }
}