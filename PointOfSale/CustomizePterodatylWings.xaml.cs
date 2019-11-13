using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizePterodatylWings.xaml
    /// </summary>
    public partial class CustomizePterodatylWings : Page
    {
        PterodactylWings wings;
        CretaceousCombo combo;
        public CustomizePterodatylWings(PterodactylWings wings)
        {
            InitializeComponent();
            this.wings = wings;
        }
        public CustomizePterodatylWings(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void HoldWingSauceButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.wings.HoldSauce();
            }
            else
            {
                if (combo.Entree is PterodactylWings w)
                {
                    w.HoldSauce();
                }
            }
        }
    }
}
