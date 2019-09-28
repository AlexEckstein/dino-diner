

namespace DinoDiner.Menu.Drinks
{
    public abstract class ColdDrink : Drink
    {
        public bool Ice { get; protected set; }

        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
