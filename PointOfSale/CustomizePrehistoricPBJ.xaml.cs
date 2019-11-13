using DinoDiner.Menu;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        private PrehistoricPBJ pbj = new PrehistoricPBJ();

        public CustomizePrehistoricPBJ()
        {
            InitializeComponent();
        }

        public CustomizePrehistoricPBJ(PrehistoricPBJ sandwich)
        {
            InitializeComponent();
            this.pbj = sandwich;
        }

        private void HoldPeanutButterButton_Click(object sender, RoutedEventArgs e)
        {
            this.pbj.HoldPeanutButter();
        }

        private void HoldJellyButton_Click(object sender, RoutedEventArgs e)
        {
            this.pbj.HoldJelly();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NavigationService.GoBack();
            }
            catch (Exception)
            {
                cantGoBack.IsOpen = true;
            }
        }
    }
}
