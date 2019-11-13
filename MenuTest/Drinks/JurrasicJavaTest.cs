using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava ss = new JurassicJava();
            Assert.Equal(0.59, ss.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava ss = new JurassicJava();
            Assert.Equal<uint>(2, ss.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurassicJava ss = new JurassicJava();
            Assert.Contains<string>("Water", ss.Ingredients);
            Assert.Contains<string>("Coffee", ss.Ingredients);
            Assert.Equal<int>(2, ss.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava ss = new JurassicJava();
            Assert.Equal<Size>(Size.Small, ss.Size);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream()
        {
            JurassicJava ss = new JurassicJava();
            Assert.False(ss.RoomForCream);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava ss = new JurassicJava();
            Assert.False(ss.Ice);
        }
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            JurassicJava ss = new JurassicJava();
            ss.Size = Size.Medium;
            Assert.Equal(0.99, ss.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            JurassicJava ss = new JurassicJava();
            ss.Size = Size.Medium;
            Assert.Equal<uint>(4, ss.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            JurassicJava ss = new JurassicJava();
            ss.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ss.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            JurassicJava ss = new JurassicJava();
            ss.Size = Size.Large;
            Assert.Equal(1.49, ss.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            JurassicJava ss = new JurassicJava();
            ss.Size = Size.Large;
            Assert.Equal<uint>(8, ss.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            JurassicJava ss = new JurassicJava();
            ss.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ss.Size);
        }

        [Fact]
        public void ShouldBeAbleToAddIce()
        {
            JurassicJava ss = new JurassicJava();
            ss.AddIce();
            Assert.True(ss.Ice);
        }

        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            JurassicJava ss = new JurassicJava();
            ss.HoldIce();
            Assert.False(ss.Ice);
        }

        [Fact]
        public void ShouldBeAbleToLeaveSpaceForCream()
        {
            JurassicJava ss = new JurassicJava();
            ss.LeaveRoomForCream();
            Assert.True(ss.RoomForCream);
        }
        [Fact]
        public void SpecialShouldBeCorrectAfterAddingIce()
        {
            JurassicJava ss = new JurassicJava();
            ss.AddIce();
            Assert.Collection<string>(ss.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void SpecialShouldBeCorrectAfterAddingRoomForCreamAndIce()
        {
            JurassicJava ss = new JurassicJava();
            ss.LeaveRoomForCream();
            ss.AddIce();
            Assert.Collection<string>(ss.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            },
            item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }

        [Fact]
        public void SpecialShouldBeCorrectAfterAddingRoomForCream()
        {
            JurassicJava ss = new JurassicJava();
            ss.LeaveRoomForCream();
            Assert.Collection<string>(ss.Special, item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }

        [Fact]
        public void AddingIceShouldNotifySpecialChange()
        {
            JurassicJava ss = new JurassicJava();
            Assert.PropertyChanged(ss, "Special", () =>
            {
                ss.AddIce();
            });
        }

        [Fact]
        public void LeavingRoomShouldNotifySpecialChange()
        {
            JurassicJava ss = new JurassicJava();
            Assert.PropertyChanged(ss, "Special", () =>
            {
                ss.LeaveRoomForCream();
            });
        }

        [Fact]
        public void AddingIceShouldNotifyIngredientsChange()
        {
            JurassicJava ss = new JurassicJava();
            Assert.PropertyChanged(ss, "Ingredients", () =>
            {
                ss.AddIce();
            });
        }

        [Fact]
        public void LeavingRoomShouldNotifyIngredientsChange()
        {
            JurassicJava ss = new JurassicJava();
            Assert.PropertyChanged(ss, "Ingredients", () =>
            {
                ss.LeaveRoomForCream();
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChange()
        {
            JurassicJava ss = new JurassicJava();
            Assert.PropertyChanged(ss, "Special", () =>
            {
                ss.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifyPriceChange()
        {
            JurassicJava ss = new JurassicJava();
            Assert.PropertyChanged(ss, "Price", () =>
            {
                ss.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySizeChange()
        {
            JurassicJava ss = new JurassicJava();
            Assert.PropertyChanged(ss, "Size", () =>
            {
                ss.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifyCaloriesChange()
        {
            JurassicJava ss = new JurassicJava();
            Assert.PropertyChanged(ss, "Calories", () =>
            {
                ss.Size = Size.Medium;
            });
        }
    }
}
