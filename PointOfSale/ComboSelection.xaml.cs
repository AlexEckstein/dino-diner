
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        private void BrontowurstCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Brontowurst"));
        }

        private void DinoNuggetsCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Dino-Nuggets"));
        }

        private void SteakosaurusCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Steakosaurus"));
        }

        private void TRexKingBurgerCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("T-Rex King Burger"));
        }

        private void PrehistoricPBJCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Prehistoric PB&J"));
        }

        private void PterodactylWingsCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Pterodactyl Wings"));
        }

        private void VelociWrapCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Veloci-Wrap"));
        }
    }
}
