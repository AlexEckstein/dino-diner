using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Enums;
using Xunit;
namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.Equal(0.59, ss.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.Equal<uint>(2, ss.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.Contains<string>("Water", ss.Ingredients);
            Assert.Contains<string>("Coffee", ss.Ingredients);
            Assert.Equal<int>(2, ss.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, ss.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            JurrasicJava ss = new JurrasicJava();
            ss.Size = Size.Medium;
            Assert.Equal(0.99, ss.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            JurrasicJava ss = new JurrasicJava();
            ss.Size = Size.Medium;
            Assert.Equal<uint>(4, ss.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            JurrasicJava ss = new JurrasicJava();
            ss.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ss.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            JurrasicJava ss = new JurrasicJava();
            ss.Size = Size.Large;
            Assert.Equal(1.49, ss.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            JurrasicJava ss = new JurrasicJava();
            ss.Size = Size.Large;
            Assert.Equal<uint>(8, ss.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            JurrasicJava ss = new JurrasicJava();
            ss.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ss.Size);
        }

        [Fact]
        public void ShouldBeAbleToAddIce()
        {
            JurrasicJava ss = new JurrasicJava();
            ss.AddIce();
            Assert.True(ss.Ice);
        }

        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            SodaSaurus ss = new SodaSaurus();
            ss.HoldIce();
            Assert.False(ss.Ice);
        }
    }
}
