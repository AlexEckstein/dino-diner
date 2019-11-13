using DinoDiner.Menu;
using DinoDiner.Menu;
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
        public void ShouldHaveCorrectDefaultRoomForCream()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.False(ss.RoomForCream);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.False(ss.Ice);
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
            JurrasicJava ss = new JurrasicJava();
            ss.HoldIce();
            Assert.False(ss.Ice);
        }

        [Fact]
        public void ShouldBeAbleToLeaveSpaceForCream()
        {
            JurrasicJava ss = new JurrasicJava();
            ss.LeaveRoomForCream();
            Assert.True(ss.RoomForCream);
        }
        [Fact]
        public void SpecialShouldBeCorrectAfterAddingIce()
        {
            JurrasicJava ss = new JurrasicJava();
            ss.AddIce();
            Assert.Collection<string>(ss.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void SpecialShouldBeCorrectAfterAddingRoomForCreamAndIce()
        {
            JurrasicJava ss = new JurrasicJava();
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
            JurrasicJava ss = new JurrasicJava();
            ss.LeaveRoomForCream();
            Assert.Collection<string>(ss.Special, item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }

        [Fact]
        public void AddingIceShouldNotifySpecialChange()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.PropertyChanged(ss, "Special", () =>
            {
                ss.AddIce();
            });
        }

        [Fact]
        public void LeavingRoomShouldNotifySpecialChange()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.PropertyChanged(ss, "Special", () =>
            {
                ss.LeaveRoomForCream();
            });
        }

        [Fact]
        public void AddingIceShouldNotifyIngredientsChange()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.PropertyChanged(ss, "Ingredients", () =>
            {
                ss.AddIce();
            });
        }

        [Fact]
        public void LeavingRoomShouldNotifyIngredientsChange()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.PropertyChanged(ss, "Ingredients", () =>
            {
                ss.LeaveRoomForCream();
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChange()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.PropertyChanged(ss, "Special", () =>
            {
                ss.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifyPriceChange()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.PropertyChanged(ss, "Price", () =>
            {
                ss.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySizeChange()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.PropertyChanged(ss, "Size", () =>
            {
                ss.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifyCaloriesChange()
        {
            JurrasicJava ss = new JurrasicJava();
            Assert.PropertyChanged(ss, "Calories", () =>
            {
                ss.Size = Size.Medium;
            });
        }
    }
}
