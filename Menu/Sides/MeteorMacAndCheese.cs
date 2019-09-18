﻿/*  MeteorMacAndCheese.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// MeteorMacAndCheese class that inherits from Side
    /// </summary>
    public class MeteorMacAndCheese: Side
    {
        public MeteorMacAndCheese()
        {
            this.Size = Size.Small;
            if (this.Size == Size.Small) this.Calories = 420; this.Price = 0.99;
            if (this.Size == Size.Medium) this.Calories = 490; this.Price = 1.45;
            if (this.Size == Size.Large) this.Calories = 520; this.Price = 1.95;
        }
        
    }
}
