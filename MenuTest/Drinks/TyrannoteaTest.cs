using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Enums;
using System;
using Xunit;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea ss = new Tyrannotea();
            Assert.Equal(0.99, ss.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea ss = new Tyrannotea();
            Assert.Equal<uint>(8, ss.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Tyrannotea ss = new Tyrannotea();
            Assert.Contains<string>("Water", ss.Ingredients);
            Assert.Contains<string>("Tea", ss.Ingredients);
            Assert.Equal<int>(2, ss.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea ss = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, ss.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Tyrannotea ss = new Tyrannotea();
            ss.Size = Size.Medium;
            Assert.Equal(1.49, ss.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Tyrannotea ss = new Tyrannotea();
            ss.Size = Size.Medium;
            Assert.Equal<uint>(16, ss.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Tyrannotea ss = new Tyrannotea();
            ss.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ss.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Tyrannotea ss = new Tyrannotea();
            ss.Size = Size.Large;
            Assert.Equal(1.99, ss.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Tyrannotea ss = new Tyrannotea();
            ss.Size = Size.Large;
            Assert.Equal<uint>(32, ss.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Tyrannotea ss = new Tyrannotea();
            ss.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ss.Size);
        }


        public void ShouldBeAbleToAddLemon()
        {
            Tyrannotea ss = new Tyrannotea();
            ss.AddLemon();
            Assert.True(ss.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            Tyrannotea ss = new Tyrannotea();
            ss.HoldIce();
            Assert.False(ss.Ice);
        }
        [Fact]
        public void ShouldBeAbleToAd0dSugar()
        {
            Tyrannotea ss = new Tyrannotea();
            ss.Sweet = true;
            Assert.True(ss.Sweet);
        }
    }
}
