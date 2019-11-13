using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeVelociwrap.xaml
    /// </summary>
    public partial class CustomizeVelociwrap : Page
    {
        /// <summary>
        /// Private backing variables
        /// </summary>
        private VelociWrap wrap;
        private CretaceousCombo combo;

        public CustomizeVelociwrap(VelociWrap wrap)
        {
            InitializeComponent();
            this.wrap = wrap;
        }
        public CustomizeVelociwrap(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// Holds the specified ingredient from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldTortillaButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.wrap.HoldTortilla();
            }
            else
            {
                if (combo.Entree is VelociWrap v)
                {
                    v.HoldTortilla();
                }
            }
        }

        /// <summary>
        /// Holds the specified ingredient from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldLettuceButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.wrap.HoldLettuce();
            }
            else
            {
                if (combo.Entree is VelociWrap v)
                {
                    v.HoldLettuce();
                }
            }
        }

        /// <summary>
        /// Holds the specified ingredient from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldCheeseButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.wrap.HoldCheese();
            }
            else
            {
                if (combo.Entree is VelociWrap v)
                {
                    v.HoldCheese();
                }
            }
        }

        /// <summary>
        /// Holds the specified ingredient from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldDressingButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.wrap.HoldDressing();
            }
            else
            {
                if (combo.Entree is VelociWrap v)
                {
                    v.HoldDressing();
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
