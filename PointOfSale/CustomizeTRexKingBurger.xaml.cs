using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {

        private TRexKingBurger burger;


        private CretaceousCombo combo;


        public CustomizeTRexKingBurger(TRexKingBurger b)
        {
            InitializeComponent();
            this.burger = b;
        }


        public CustomizeTRexKingBurger(CretaceousCombo c)
        {
            InitializeComponent();
            this.combo = c;
        }


        private void HoldKetchupButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.burger.HoldKetchup();
            }
            else
            {
                if (combo.Entree is TRexKingBurger t)
                {
                    t.HoldKetchup();
                }
            }
        }


        private void HoldMustardButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.burger.HoldMustard();
            }
            else
            {
                if (combo.Entree is TRexKingBurger t)
                {
                    t.HoldMustard();
                }
            }
        }


        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }


        private void HoldBunButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.burger.HoldBun();
            }
            else
            {
                if (combo.Entree is TRexKingBurger t)
                {
                    t.HoldBun();
                }
            }
        }


        private void HoldPickleButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.burger.HoldPickle();
            }
            else
            {
                if (combo.Entree is TRexKingBurger t)
                {
                    t.HoldPickle();
                }
            }
        }



        private void HoldLettuceButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.burger.HoldLettuce();
            }
            else
            {
                if (combo.Entree is TRexKingBurger t)
                {
                    t.HoldLettuce();
                }
            }
        }


        private void HoldOnionButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.burger.HoldOnion();
            }
            else
            {
                if (combo.Entree is TRexKingBurger t)
                {
                    t.HoldOnion();
                }
            }
        }


        private void HoldMayoButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.burger.HoldMayo();
            }
            else
            {
                if (combo.Entree is TRexKingBurger t)
                {
                    t.HoldMayo();
                }
            }
        }
    }
}
