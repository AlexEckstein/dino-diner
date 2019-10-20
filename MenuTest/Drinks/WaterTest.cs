using DinoDiner.Menu;
using DinoDiner.Menu.Enums;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Water ss = new Water();
            Assert.Contains<string>("Water", ss.Ingredients);
            Assert.Single(ss.Ingredients);
        }
        [Fact]
        public void ShouldAddLemonToWater()
        {
            Water ss = new Water();
            ss.AddLemon();
            Assert.True(ss.Lemon);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water ss = new Water();
            Assert.Equal<double>(0.10, ss.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water ss = new Water();
            Assert.Equal<uint>(0, ss.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Water ss = new Water();
            Assert.Equal<Size>(Size.Small, ss.Size);

        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water ss = new Water();
            Assert.True(ss.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water ss = new Water();
            Assert.False(ss.Lemon);
        }

        [Fact]
        public void ShouldUseCorrectPriceAfterSettingSmall()
        {
            Water ss = new Water();
            ss.Size = Size.Small;//change to small from meduim
            ss.Size = Size.Small;
            Assert.Equal<double>(0.10, ss.Price);
        }

        [Fact]
        public void ShouldUseCorrectPriceAfterSettingMedium()
        {
            Water ss = new Water();
            ss.Size = Size.Medium;
            Assert.Equal<double>(0.10, ss.Price);
        }

        [Fact]
        public void ShouldUseCorrectPriceAfterSettingLarge()
        {
            Water ss = new Water();
            ss.Size = Size.Large;
            Assert.Equal<double>(0.10, ss.Price);
        }

        [Fact]
        public void ShouldHaveInvokingHoldIce()
        {
            Water ss = new Water();
            Assert.True(ss.Ice);
        }
        [Fact]
        public void ShouldHaveInvokingAddLemon()
        {
            Water ss = new Water();
            Assert.False(ss.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToRemoveIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }
    }
}
