using DinoDiner.Menu;
using DinoDiner.Menu.Enums;
using Xunit;

namespace MenuTest.Drinks
{
    public class SodaSaurusTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.Equal(1.50, ss.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.Equal<uint>(112, ss.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.Contains<string>("Water", ss.Ingredients);
            Assert.Contains<string>("Natural Flavors", ss.Ingredients);
            Assert.Contains<string>("Cane Sugar", ss.Ingredients);
            Assert.Equal<int>(3, ss.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.Equal<Size>(Size.Small, ss.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            SodaSaurus ss = new SodaSaurus();
            ss.Size = Size.Medium;
            Assert.Equal(2.0, ss.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            SodaSaurus ss = new SodaSaurus();
            ss.Size = Size.Medium;
            Assert.Equal<uint>(156, ss.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            SodaSaurus ss = new SodaSaurus();
            ss.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ss.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            SodaSaurus ss = new SodaSaurus();
            ss.Size = Size.Large;
            Assert.Equal(2.5, ss.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            SodaSaurus ss = new SodaSaurus();
            ss.Size = Size.Large;
            Assert.Equal<uint>(208, ss.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            SodaSaurus ss = new SodaSaurus();
            ss.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ss.Size);
        }
        /*
          [Fact]
        public void ShouldBeAbleToSelectAnyFlavor()
        {
            SodaSaurus ss = new SodaSaurus();
            foreach (SodaSaurusFlavor f in (SodaSaurusFlavor[]))
            {
                ss.Flavor = f;
                Assert.Equal<SodaSaurusFlavor>(f, ss.Flavor);
            }
        }
        */
        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            SodaSaurus ss = new SodaSaurus();
            ss.HoldIce();
            Assert.False(ss.Ice);
        }

        [Fact]
        public void ChangingToSmallShouldNotifyOfPricePropertyChange()
        {
            SodaSaurus ss = new SodaSaurus();
            ss.Size = Size.Medium;
            Assert.PropertyChanged(ss, "Price", () =>
            {
                ss.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingToSmallShouldNotifyOfDescriptionPropertyChange()
        {
            SodaSaurus ss = new SodaSaurus();
            ss.Size = Size.Medium;
            Assert.PropertyChanged(ss, "Description", () =>
            {
                ss.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingToMediumShouldNotifyOfPricePropertyChange()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.PropertyChanged(ss, "Price", () =>
            {
                ss.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingToMediumShouldNotifyOfDescriptionPropertyChange()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.PropertyChanged(ss, "Description", () =>
            {
                ss.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingToLargeShouldNotifyOfPricePropertyChange()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.PropertyChanged(ss, "Price", () =>
            {
                ss.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingToLargeShouldNotifyOfDescriptionPropertyChange()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.PropertyChanged(ss, "Description", () =>
            {
                ss.Size = Size.Large;
            });
        }

        [Fact]
        public void SettingFlavorToColaShouldNotifyOfDescriptionPropertyChange()
        {
            SodaSaurus ss = new SodaSaurus();
            ss.Flavor = SodaSaurusFlavor.Lime;
            Assert.PropertyChanged(ss, "Description", () =>
            {
                ss.Flavor = SodaSaurusFlavor.Cola;
            });
        }

        [Fact]
        public void SettingFlavorToRootBeerShouldNotifyOfDescriptionPropertyChange()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.PropertyChanged(ss, "Description", () =>
            {
                ss.Flavor = SodaSaurusFlavor.RootBeer;
            });
        }
        [Fact]
        public void SettingFlavorToCherryShouldNotifyOfDescriptionPropertyChange()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.PropertyChanged(ss, "Description", () =>
            {
                ss.Flavor = SodaSaurusFlavor.Cherry;
            });
        }
        [Fact]
        public void SettingFlavorToVanillaShouldNotifyOfDescriptionPropertyChange()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.PropertyChanged(ss, "Description", () =>
            {
                ss.Flavor = SodaSaurusFlavor.Vanilla;
            });
        }
        [Fact]
        public void SettingFlavorToChocolateShouldNotifyOfDescriptionPropertyChange()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.PropertyChanged(ss, "Description", () =>
            {
                ss.Flavor = SodaSaurusFlavor.Chocolate;
            });
        }
        [Fact]
        public void SettingFlavorToOrangeShouldNotifyOfDescriptionPropertyChange()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.PropertyChanged(ss, "Description", () =>
            {
                ss.Flavor = SodaSaurusFlavor.Orange;
            });
        }
        [Fact]
        public void SettingFlavorToLimeShouldNotifyOfDescriptionPropertyChange()
        {
            SodaSaurus ss = new SodaSaurus();
            Assert.PropertyChanged(ss, "Description", () =>
            {
                ss.Flavor = SodaSaurusFlavor.Lime;
            });
        }
        [Fact]
        public void SpecialShouldRemoveIce()
        {
            SodaSaurus ss = new SodaSaurus();
            ss.HoldIce();
            Assert.Collection<string>(ss.Special,
                item => { Assert.Equal("Hold Ice", item); });
        }
    }
}
