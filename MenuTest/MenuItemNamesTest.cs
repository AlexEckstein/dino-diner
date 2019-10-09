using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Enums;

namespace MenuTest
{
    public class MenuItemNamesTest
    {
        #region Entrees

        [Fact]
        public void BrontowurstToStringShouldGiveName()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.ToString());
        }


        [Fact]
        public void DinoNuggetToStringShouldGiveName()
        {

            DinoNuggets dn = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", dn.ToString());
        }


        [Fact]
        public void PrehistoricPBJToStringShouldGiveName()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pbj.ToString());
        }

        [Fact]
        public void PterodactylWingsToStringShouldGiveName()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal("Pterodactyl Wings", pw.ToString());
        }

        [Fact]
        public void SteakosaurusBurgerToStringShouldGiveName()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", sb.ToString());
        }

        [Fact]
        public void TRexKingBurgerToStringShouldGiveName()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", trex.ToString());
        }

        [Fact]
        public void VelociWrapToStringShouldGiveName()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.ToString());
        }

        #endregion

        #region Sides

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void FryceritopsToStringShouldGiveNameForSize(Size size)
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = size;
            Assert.Equal($"{size} Fryceritops", ft.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MeteorMacAndCheeseToStringShouldGiveNameForSize(Size size)
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = size;
            Assert.Equal($"{size} Meteor Mac and Cheese", mmc.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MezzorellaSticksToStringShouldGiveNameForSize(Size size)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = size;
            Assert.Equal($"{size} Mezzorella Sticks", ms.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ToStringShouldGiveNameForSize(Size size)
        {
            Triceritots tt = new Triceritots();
            tt.Size = size;
            Assert.Equal($"{size} Triceritots", tt.ToString());
        }

        #endregion

        #region Drinks

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void JurrasicJavaToStringShouldGiveNameForSizeAndDecaf(Size size, bool decaf)
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = size;
            java.Decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.ToString());
            else Assert.Equal($"{size} Jurassic Java", java.ToString());
        }


        [Theory]
        [InlineData(Size.Small, SodaSaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodaSaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodaSaurusFlavor.Cola)]
        [InlineData(Size.Small, SodaSaurusFlavor.Lime)]
        [InlineData(Size.Small, SodaSaurusFlavor.Orange)]
        [InlineData(Size.Small, SodaSaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodaSaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodaSaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodaSaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodaSaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodaSaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodaSaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodaSaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodaSaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodaSaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodaSaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodaSaurusFlavor.Cola)]
        [InlineData(Size.Large, SodaSaurusFlavor.Lime)]
        [InlineData(Size.Large, SodaSaurusFlavor.Orange)]
        [InlineData(Size.Large, SodaSaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodaSaurusFlavor.Vanilla)]
        public void SodaSaurusToStringShouldGiveNameForSizeAndFlavor(Size size, SodaSaurusFlavor flavor)
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Equal($"{size} {flavor} SodaSaurus", soda.ToString());
        }

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void TyrannoTeaToStringShouldGiveNameForSizeAndSweetness(Size size, bool sweet)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            tea.Sweet = sweet;
            if (sweet) Assert.Equal($"{size} Sweet Tyrannotea", tea.ToString());
            else Assert.Equal($"{size} Tyrannotea", tea.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void WaterToStringShouldGiveNameForSize(Size size)
        {
            Water water = new Water();
            water.Size = size;
            Assert.Equal($"{size} Water", water.ToString());
        }

        #endregion

        #region Combos

        [Theory]
        [InlineData(typeof(Brontowurst), "Brontowurst Combo")]
        [InlineData(typeof(DinoNuggets), "Dino-Nuggets Combo")]
        [InlineData(typeof(PrehistoricPBJ), "Prehistoric PB&J Combo")]
        [InlineData(typeof(PterodactylWings), "Pterodactyl Wings Combo")]
        [InlineData(typeof(SteakosaurusBurger), "Steakosaurus Burger Combo")]
        [InlineData(typeof(TRexKingBurger), "T-Rex King Burger Combo")]
        [InlineData(typeof(VelociWrap), "Veloci-Wrap Combo")]
        public void ToStringShouldGiveName(Type type, string name)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.Equal(name, combo.ToString());
        }

        #endregion
    }
}
