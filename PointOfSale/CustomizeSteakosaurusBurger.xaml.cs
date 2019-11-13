using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
       
        private SteakosaurusBurger burger;

    
        private CretaceousCombo combo;

        
        public CustomizeSteakosaurusBurger(SteakosaurusBurger burger)
        {
            InitializeComponent();
            this.burger = burger;
        }

        
        public CustomizeSteakosaurusBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

       
        private void HoldPickleButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.burger.HoldPickle();
            }
            else
            {
                if (combo.Entree is SteakosaurusBurger s)
                {
                    s.HoldPickle();
                }
            }
        }

       
        private void HoldBunButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.burger.HoldBun();
            }
            else
            {
                if (combo.Entree is SteakosaurusBurger s)
                {
                    s.HoldBun();
                }
            }
        }

        
        private void HoldKetchupButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.burger.HoldKetchup();
            }
            else
            {
                if (combo.Entree is SteakosaurusBurger s)
                {
                    s.HoldKetchup();
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
                if (combo.Entree is SteakosaurusBurger s)
                {
                    s.HoldMustard();
                }
            }
        }

        /// <summary>
        /// Navigates to the previous page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
