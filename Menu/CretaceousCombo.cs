/*  CretaceousCombo.cs
*   Author: Alex Eckstein
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem, IOrderItem
    {
        private ColdDrink drink;
        private Side side;
        private Entree entree;

        public Entree Entree
        {
            get { return entree; }
            set
            {
                this.entree = value;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Drink");
            }
        }

        public ColdDrink Drink
        {
            get { return drink; }
            set
            {
                this.drink = value;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Drink");
            }
        }

        public Side Side
        {
            get { return side; }
            set
            {
                this.side = value;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Drink");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor for Combo Class
        /// </summary>
        /// <param name="e">Entree to pass in</param>
        /// <param name="d">Drink to pass in</param>
        /// <param name="s">Side to pass in</param>
        public CretaceousCombo(Entree e, ColdDrink d, Side s)
        {
            this.Entree = e;
            this.Drink = d;
            this.Side = s;
            this.Size = Size.Small;
            this.Ingredients.AddRange(Entree.Ingredients);
            this.Ingredients.AddRange(Drink.Ingredients);
            this.Ingredients.AddRange(Side.Ingredients);
        }

        public CretaceousCombo(Entree e)
        {
            Entree = e;
            Side = new Fryceritops();
            Drink = new SodaSaurus();
        }

        public void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.Add(Entree.Description);
                special.Add(Side.Description);
                special.Add(Drink.Description);
                special.AddRange(Entree.Special);
                special.AddRange(Side.Special);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients { get; private set; }

        /// <summary>
        /// Public Size that changes the size of drink and side
        /// </summary>
        public Size Size
        {
            get
            {
                return this.Size;
            }
            set
            {
                this.Size = value;
                Drink.Size = value;
                Side.Size = value;
                this.Calories = Entree.Calories + Drink.Calories + Side.Calories;
                this.Price = Entree.Price + Drink.Price + Side.Price - 0.25;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }
        /// <summary>
        /// Override method that prints the items in the Combo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.entree.ToString() + " Combo";
           
        }
    }
}
