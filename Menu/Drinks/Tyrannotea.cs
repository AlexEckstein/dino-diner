using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Enums;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : ColdDrink
    {
        public bool Sweet{ get; set; }
        public bool Lemon { get; private set; }

        public Tyrannotea()
        {
            this.Sweet = false;
            this.Lemon = false;
            this.Size = Size.Small;
            this.Ingredients.Add("Water");
            this.Ingredients.Add("Tea");
        }
        public void AddLemon()
        {
            Lemon = true;
            this.Ingredients.Add("Lemon");
        }
        public override Size Size
        {
            get
            {
                return this.Size;
            }
            set
            {
                this.Size = value;
                if (this.Size == Size.Small) { this.Calories = 8; this.Price = 0.99; }
                if (this.Size == Size.Medium) { this.Calories = 16; this.Price = 1.49; }
                if (this.Size == Size.Large) { this.Calories = 32; this.Price = 1.99; }
                if (Sweet)
                {
                    this.Calories = this.Calories * 2;
                    if (!this.Ingredients.Contains("Cane Sugar")){
                        this.Ingredients.Add("Cane Sugar");
                    }
                }
            }
        }

    }
}
