using System.Windows;
using System.Windows.Controls;
using DinoDiner.Menu;
using DinoDiner.Menu.Enums;
using System.Collections.Generic;
using System;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        Side side;
        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            this.side = side;
        }

        private void Fryceritops_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                order.Add(side);
            }
            BtnFryceritops.IsEnabled = false;
            BtnMezzSticks.IsEnabled = false;
            BtnTriceritots.IsEnabled = false;
            BtnMac.IsEnabled = false;

        }

        private void Mac_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                order.Add(side);
                BtnFryceritops.IsEnabled = false;
                BtnMezzSticks.IsEnabled = false;
                BtnTriceritots.IsEnabled = false;
                BtnMac.IsEnabled = false;
            }
        }

        private void Mezzorella_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                order.Add(side);
                BtnFryceritops.IsEnabled = false;
                BtnMezzSticks.IsEnabled = false;
                BtnTriceritots.IsEnabled = false;
                BtnMac.IsEnabled = false;
            }
        }

        private void Triceritots_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order order)
            {
                side = new Triceritots();
                order.Add(side);
                BtnFryceritops.IsEnabled = false;
                BtnMezzSticks.IsEnabled = false;
                BtnTriceritots.IsEnabled = false;
                BtnMac.IsEnabled = false;
            }
        }

        protected void SelectSize(DinoDiner.Menu.Enums.Size size)
        {
            
        }

        private void Small_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                side.Size = DinoDiner.Menu.Enums.Size.Small;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                side.Size = DinoDiner.Menu.Enums.Size.Medium;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        private void Large_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                side.Size = DinoDiner.Menu.Enums.Size.Large;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
