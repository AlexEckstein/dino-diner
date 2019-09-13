using System;
using System.Collections.Generic;

namespace MenuTest.Entrees
{
    public class DinoNuggets
    {
        private double price = ;
        private uint calories;
        private List<string> ingredients = new List<string>()
        {
            "Chicken Nugget", "Chicken Nugget",
            "Chicken Nugget", "Chicken Nugget",
            "Chicken Nugget"
        };
        public DinoNuggets()
        {

        }

        public uint Calories { get; set; }
        public List<string> Ingredients { get; internal set; }
        internal void AddNugget()
        {
            throw new NotImplementedException();
        }
    }
}