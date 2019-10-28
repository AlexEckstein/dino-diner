using DinoDiner.Menu;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private ColdDrink drink;
        public DrinkSelection(SodaSaurus sodasaurus)
        {
            InitializeComponent();

            FlavorButton.IsEnabled = false;
            IceButton.IsEnabled = false;
            DecafButton.IsEnabled = false;
            SweetButton.IsEnabled = false;
            LemonButton.IsEnabled = false;
        }

        public DrinkSelection(Entree entree)
        {
        }

        public DrinkSelection(Drink drink1)
        {
        }

        public DrinkSelection()
        {
        }

        private void Flavor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeFlavor());
        }

        private void Sodasaurus_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                drink = new SodaSaurus();
                order.Add(drink);
                FlavorButton.IsEnabled = true;
            }
        }

        private void Tyrannotea_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(drink);
                SweetButton.IsEnabled = true;
                LemonButton.IsEnabled = true;
                IceButton.IsEnabled = true;
            }
        }

        private void Jurassicjava_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                drink = new JurrasicJava();
                order.Add(drink);
                DecafButton.IsEnabled = true;
            }
        }

        private void Water_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
                SweetButton.IsEnabled = true;
                LemonButton.IsEnabled = true;
                IceButton.IsEnabled = true;
            }
        }

        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {
            drink.Size = DinoDiner.Menu.Enums.Size.Small;
        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            drink.Size = DinoDiner.Menu.Enums.Size.Medium;
        }

        private void LargeButton_Click(object sender, RoutedEventArgs e)
        {
            drink.Size = DinoDiner.Menu.Enums.Size.Large;
        }

        private void LemonButton_Click(object sender, RoutedEventArgs e)
        {
            if (drink is Water water)
            {
                water.AddLemon();
            }
            else if (drink is Tyrannotea tyrannotea)
            {
                tyrannotea.AddLemon();
            }
        }

        private void IceButton_Click(object sender, RoutedEventArgs e)
        {
            if (drink is Tyrannotea tyrannotea)
            {
                tyrannotea.HoldIce();
            }
            else if (drink is Water water)
            {
                water.HoldIce();
            }
            else if (drink is JurrasicJava jurrasicJava)
            {
                jurrasicJava.HoldIce();
            }
            else if (drink is SodaSaurus sodaSaurus)
            {
                sodaSaurus.HoldIce();
            }
        }

        private void Decaf_Click(object sender, RoutedEventArgs e)
        {
            if (drink is JurrasicJava jurrassicJava)
            {
                jurrassicJava.MakeDecaf();
            }
        }

        private void Sweet_Click(object sender, RoutedEventArgs e)
        {
            if (drink is Tyrannotea tyrannotea)
            {
                tyrannotea.Sweet = true;
            }
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
