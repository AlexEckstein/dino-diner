using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class PrehistoricPBJUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal(6.52, pbj.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal<uint>(483, pbj.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            List<string> ingredients = pbj.Ingredients;
            Assert.Contains<string>("Bread", ingredients);
            Assert.Contains<string>("Peanut Butter", ingredients);
            Assert.Contains<string>("Jelly", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void HoldPeanutButterShouldRemovePeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.DoesNotContain<string>("Peanut Butter", pbj.Ingredients);
        }

        [Fact]
        public void HoldJellyShouldRemoveJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.DoesNotContain<string>("Jelly", pbj.Ingredients);
        }

        [Fact]
        public void HoldPeanutButterShouldNotifySpecialProperty()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged( pbj, "Special", () =>
            {
                pbj.HoldPeanutButter();
            });
        }

        [Fact]
        public void HoldJellyShouldNotifySpecialProperty()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldJelly();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void SpecialShouldHoldPeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.Collection<string>(pbj.Special, item =>
            {
                Assert.Equal("Hold Peanut Butter", item);
            });
        }


        [Fact]
        public void SpecialShouldHoldJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.Collection<string>(pbj.Special, item =>
            {
                Assert.Equal("Hold Jelly", item);
            });
        }
        [Fact]
        public void SpecialShouldHoldPBAndJ()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            pbj.HoldJelly();
            Assert.Contains<string>("Hold Jelly", pbj.Special); 
            //needs an and symbol
            Assert.Contains<string>("Hold Peanut Butter", pbj.Special);
        }

        [Fact]
        public void DescriptionMatchesToString()
        {
            Brontowurst b = new Brontowurst();
            Assert.Equal(b.Description, b.ToString());
        }
    }

}
