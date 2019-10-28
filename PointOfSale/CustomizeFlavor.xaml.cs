using System.Windows;
using System.Windows.Controls;
using DinoDiner.Menu;
using DinoDiner.Menu.Enums;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeFlavor.xaml
    /// </summary>
    public partial class CustomizeFlavor : Page
    {
        public CustomizeFlavor()
        {
            InitializeComponent();
        }

        private void Lime_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is SodaSaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodaSaurusFlavor.Lime;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }

        private void Orange_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is SodaSaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodaSaurusFlavor.Orange;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }

        private void Cola_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is SodaSaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodaSaurusFlavor.Cola;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }

        private void Root_Beer_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is SodaSaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodaSaurusFlavor.RootBeer;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }

        private void Cherry_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is SodaSaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodaSaurusFlavor.Cherry;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }

        private void Vanilla_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is SodaSaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodaSaurusFlavor.Vanilla;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }

        private void Chocolate_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is SodaSaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodaSaurusFlavor.Chocolate;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }
    }
}
