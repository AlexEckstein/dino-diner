using DinoDiner.Menu;
using DinoDiner.Menu.Enums;
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

        [Fact]
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
        public void ShouldBeAbleToAddSugar()
        {
            Tyrannotea ss = new Tyrannotea();
            ss.Sweet = true;
            Assert.True(ss.Sweet);
        }

        [Fact]
        public void ChangingToSmallShouldNotifyOfPricePropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.PropertyChanged(tea, "Price", () => 
            {
                tea.Size = Size.Small; 
            });
        }

        [Fact]
        public void ChangingToSmallShouldNotifyOfDescriptionPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.PropertyChanged(tea, "Description", () => 
            {
                tea.Size = Size.Small; 
            });
        }

        [Fact]
        public void ChangingToMediumShouldNotifyOfPricePropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Price", () => 
            {
                tea.Size = Size.Medium; 
            });
        }

        [Fact]
        public void ChangingToMediumShouldNotifyOfDescriptionPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () => 
            {
                tea.Size = Size.Medium; 
            });
        }

        [Fact]
        public void ChangingToLargeShouldNotifyOfPricePropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Price", () => 
            {
                tea.Size = Size.Large; 
            });
        }

        [Fact]
        public void ChangingToLargeShouldNotifyOfDescriptionPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () => 
            {
                tea.Size = Size.Large; 
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Empty(tea.Special);
        }

        [Fact]
        public void DescriptionMatchesToString()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(tea.Description, tea.ToString());
        }

        [Fact]
        public void HoldingIceShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.HoldIce();
            });
        }

        [Fact]
        public void AddingSweetnerShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void AddingLemonShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () => 
            {
                tea.AddLemon(); 
            });
        }

        [Fact]
        public void SpecialShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special, item => 
            {
                Assert.Equal("Hold Ice", item); 
            });
        }

        [Fact]
        public void SpecialShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special, item => 
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void SpecialShouldAddAllItems()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.HoldIce();
            Assert.Contains<string>("Add Lemon", tea.Special);
            Assert.Contains<string>("Hold Ice", tea.Special);
            Assert.Equal<int>(2, tea.Special.Length);
        }
    }
}
