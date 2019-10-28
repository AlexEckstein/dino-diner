
using DinoDiner.Menu;
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
            if (DataContext is Order order)
            {
                order.Add(new Brontowurst());
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        private void DinoNuggetsCombo_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new DinoNuggets());
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        private void SteakosaurusCombo_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new SteakosaurusBurger());
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        private void TRexKingBurgerCombo_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TRexKingBurger());
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        private void PrehistoricPBJCombo_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PrehistoricPBJ());
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        private void PterodactylWingsCombo_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PterodactylWings());
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        private void VelociWrapCombo_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new VelociWrap());
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
    }
}
