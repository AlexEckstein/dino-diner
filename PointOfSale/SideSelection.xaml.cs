using System.Windows;
using System.Windows.Controls;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public SideSelection()
        {
            InitializeComponent();
        }

        private void Fryceritops_Click(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new Fryceritops());
            BtnFryceritops.IsEnabled = false;
            BtnMezzSticks.IsEnabled = false;
            BtnTriceritots.IsEnabled = false;
            BtnMac.IsEnabled = false;

        }

        private void Mac_Click(object sender, RoutedEventArgs e)
        {

            Order order = (Order)DataContext;
            order.Items.Add(new MeteorMacAndCheese());
            BtnFryceritops.IsEnabled = false;
            BtnMezzSticks.IsEnabled = false;
            BtnTriceritots.IsEnabled = false;
            BtnMac.IsEnabled = false;
        }

        private void Mezzorella_Click(object sender, RoutedEventArgs e)
        {

            Order order = (Order)DataContext;
            order.Items.Add(new MezzorellaSticks());
            BtnFryceritops.IsEnabled = false;
            BtnMezzSticks.IsEnabled = false;
            BtnTriceritots.IsEnabled = false;
            BtnMac.IsEnabled = false;
        }

        private void Triceritots_Click(object sender, RoutedEventArgs e)
        {

            Order order = (Order)DataContext;
            order.Items.Add(new Triceritots());
            BtnFryceritops.IsEnabled = false;
            BtnMezzSticks.IsEnabled = false;
            BtnTriceritots.IsEnabled = false;
            BtnMac.IsEnabled = false;
        }

        private void Small_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Large_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
