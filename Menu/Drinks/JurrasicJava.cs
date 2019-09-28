using DinoDiner.Menu.Enums;
using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : ColdDrink
    {
        public bool RoomForCream = false;
        public override Size Size
        {
            get
            {
                return this.Size;
            }
            set
            {
                this.Size = value;
                if (this.Size == Size.Small) { this.Calories = 2; this.Price = 0.59; }
                if (this.Size == Size.Medium) { this.Calories = 4; this.Price = 0.99; }
                if (this.Size == Size.Large) { this.Calories = 8; this.Price = 1.49; }

            }
        }

        public JurrasicJava()
        {
            this.Ice = false;
            this.Size = Size.Small;
            this.Ingredients = new List<string>
            {
                "Water", "Coffee"
            };
        }

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        public void AddIce()
        {
            this.Ice = true;
        }
    }
}
