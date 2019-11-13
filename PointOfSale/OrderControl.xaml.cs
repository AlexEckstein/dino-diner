using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public NavigationService Navigation { get; set; }
        public static NavigationService NavigationService { get; internal set; }

        public OrderControl()
        {
            InitializeComponent();
        }

        public void RemoveItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        public void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                Navigation?.Navigate(new SideSelection(side));
            }
            else if (OrderItems.SelectedItem is ColdDrink drink)
            {
                Navigation?.Navigate(new DrinkSelection(drink));
            }
            else if (OrderItems.SelectedItem is Entree entree)
            {
                Navigation?.Navigate(new DrinkSelection(entree));
            }
        }
    }
}
