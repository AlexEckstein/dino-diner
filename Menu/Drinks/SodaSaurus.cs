using DinoDiner.Menu.Enums;

namespace DinoDiner.Menu.Drinks
{
    public class SodaSaurus : ColdDrink
    {
        public SodaSaurus()
        {
            this.Size = Size.Small;
            this.Ice = true;
            this.Flavor = SodaSaurusFlavor.Cola;
        }
        public SodaSaurusFlavor Flavor { get; set; }

        public override Size Size
        {
            get
            {
                return this.Size;
            }
            set
            {
                this.Size = value;
                if (this.Size == Size.Small) { this.Calories = 222; this.Price = 0.99; }
                if (this.Size == Size.Medium) { this.Calories = 365; this.Price = 1.45; }
                if (this.Size == Size.Large) { this.Calories = 480; this.Price = 1.95; }
            }
        }
    }
}
