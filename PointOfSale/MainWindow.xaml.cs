using DinoDiner.Menu;
using System.Windows;
using System.Windows.Navigation;

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
            Order order = new Order();
            DataContext = order;
            UXOrder.Navigate(new MenuCategorySelection());
            OrderControl.NavigationService = UXOrder.NavigationService;
        }

        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {

        }
        
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {

        }

        private void SetFrameDataContext()
        {
            //FrameworkElement content = OrderInterface.Content as FrameworkElement;
        }
    }
}
