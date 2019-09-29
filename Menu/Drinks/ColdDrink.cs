/*  ColdDrink.cs
*   Author: Alex Eckstein
*/

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Abstract class that inherits from Drink and includes Ice and HoldIce
    /// </summary>
    public abstract class ColdDrink : Drink
    {
        public bool Ice { get; protected set; }

        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
