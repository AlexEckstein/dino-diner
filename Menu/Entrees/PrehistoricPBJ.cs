using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;

        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
            this.Ingredients = new List<string>()
            {
                "Bread",
                "Peanut Butter",
                "Jelly"
            };
        }

        public void HoldPeanutButter()
        {
            this.Ingredients.Remove("Peanut Butter");
        }

        public void HoldJelly()
        {
            this.Ingredients.Remove("Jelly");
        }
    }
}
