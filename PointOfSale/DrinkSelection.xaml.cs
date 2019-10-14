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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();

            FlavorButton.IsEnabled = false;
            IceButton.IsEnabled = false;
            DecafButton.IsEnabled = false;
            SweetButton.IsEnabled = false;
            LemonButton.IsEnabled = false;
        }

        private void Flavor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeFlavor());
        }

        private void Sodasaurus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tyrannotea_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Jurassicjava_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Water_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LargeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LemonButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IceButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Decaf_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sweet_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
