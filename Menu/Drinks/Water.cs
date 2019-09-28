using DinoDiner.Menu.Enums;

namespace DinoDiner.Menu.Drinks
{
    class Water : ColdDrink
    {
        public override Size Size { get; set; }

        public Water()
        {
            this.Price = 0.10;
            this.Ingredients.Add("Water");
            this.Calories = 0;
        }
        public void AddLemon()
        {
            this.Ingredients.Add("Lemon");
        }
    }
}
