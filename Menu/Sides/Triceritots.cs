/*  Triceritots.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        public Triceritots()
        {
            this.Size = Size.Small;
            if (this.Size == Size.Small) { this.Calories = 352; this.Price = 0.99; }
            if (this.Size == Size.Medium) { this.Calories = 410; this.Price = 1.45; }
            if (this.Size == Size.Large) { this.Calories = 590; this.Price = 1.95; }
        }
    }
}
