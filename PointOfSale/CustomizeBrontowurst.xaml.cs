using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        public CustomizeBrontowurst()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Private backing variable.
        /// </summary>
        private Brontowurst bronto;

        /// <summary>
        /// Private backing combo.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor which initializes the private backing variable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public CustomizeBrontowurst(Brontowurst b)
        {
            InitializeComponent();
            this.bronto = b;
        }

        /// <summary>
        /// Constructor which initializes the private backing combo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public CustomizeBrontowurst(CretaceousCombo c)
        {
            InitializeComponent();
            this.combo = c;
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldOnionButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.bronto.HoldOnion();
            }
            else
            {
                if (combo.Entree is Brontowurst brat)
                {
                    brat.HoldOnion();
                }
            }

        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPeppersButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.bronto.HoldPeppers();
            }
            else
            {
                if (combo.Entree is Brontowurst brat)
                {
                    brat.HoldPeppers();
                }
            }
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldBunButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.bronto.HoldBun();
            }
            else
            {
                if (combo.Entree is Brontowurst brat)
                {
                    brat.HoldBun();
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
