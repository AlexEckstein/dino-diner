using DinoDiner.Menu;
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
        public DrinkSelection(SodaSaurus soda)
        {
            InitializeComponent();
            DecafButton.IsEnabled = false;
            SweetButton.IsEnabled = false;
            LemonButton.IsEnabled = false;
            drink = soda;
        }

        public DrinkSelection(Entree entree)
        {
            InitializeComponent();
        }

        public DrinkSelection(ColdDrink d)
        {
            InitializeComponent();
            this.drink = d;
        }

        /// <summary>
        /// Constructor used when user is selecting a drink
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();


            //Handles button states
            SmallButton.IsEnabled = false;
            MediumButton.IsEnabled = false;
            LargeButton.IsEnabled = false;
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
                sodaButton.IsEnabled = false;

                //Handles button states
                SmallButton.IsEnabled = false;
                MediumButton.IsEnabled = true;
                LargeButton.IsEnabled = true;
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

                //Handles button states
                SmallButton.IsEnabled = false;
                MediumButton.IsEnabled = true;
                LargeButton.IsEnabled = true;
            }
        }

        private void Jurassicjava_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Add(drink);
                DecafButton.IsEnabled = true;
                JavaButton.IsEnabled = false;

                //Handles button states
                SmallButton.IsEnabled = false;
                MediumButton.IsEnabled = true;
                LargeButton.IsEnabled = true;
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
                WaterButton.IsEnabled = false;
            }
        }

        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {
            drink.Size = DinoDiner.Menu.Size.Small;
            SmallButton.IsEnabled = false;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            drink.Size = DinoDiner.Menu.Size.Medium;
            MediumButton.IsEnabled = false;
            SmallButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
        }

        private void LargeButton_Click(object sender, RoutedEventArgs e)
        {
            drink.Size = DinoDiner.Menu.Size.Large;
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = false;

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
            else if (drink is JurassicJava jurrasicJava)
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
            if (drink is JurassicJava jurrassicJava)
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
