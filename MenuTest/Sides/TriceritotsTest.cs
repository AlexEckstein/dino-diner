﻿using DinoDiner.Menu;
using DinoDiner.Menu.Enums;
using Xunit;

namespace MenuTest.Sides
{
    public class TriceritotsTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal(0.99, tt.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal<uint>(352, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Triceritots tt = new Triceritots();
            Assert.Contains<string>("Potato", tt.Ingredients);
            Assert.Contains<string>("Salt", tt.Ingredients);
            Assert.Contains<string>("Vegetable Oil", tt.Ingredients);
            Assert.Equal<int>(3, tt.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal<Size>(Size.Small, tt.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal(1.45, tt.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal<uint>(410, tt.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, tt.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal(1.95, tt.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal<uint>(590, tt.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, tt.Size);
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChange()
        {
            Triceritots tt = new Triceritots();
            Assert.PropertyChanged(tt, "Special", () =>
            {
                tt.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifyPriceChange()
        {
            Triceritots tt = new Triceritots();
            Assert.PropertyChanged(tt, "Price", () =>
            {
                tt.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySizeChange()
        {
            Triceritots tt = new Triceritots();
            Assert.PropertyChanged(tt, "Size", () =>
            {
                tt.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifyCaloriesChange()
        {
            Triceritots tt = new Triceritots();
            Assert.PropertyChanged(tt, "Calories", () =>
            {
                tt.Size = Size.Medium;
            });
        }
    }
}
