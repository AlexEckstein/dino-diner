using DinoDiner.Menu;
using System.Windows;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order order = (Order)DataContext;
            
            order.Items.Add(new Tyrannotea());
        }
    }
}
