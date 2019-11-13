using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
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
            SetFrameDataContext();
        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            SetFrameDataContext();
        }

        private void SetFrameDataContext()
        {
            if (UXOrder.Content is Page page)
            {
                page.DataContext = UXOrder.DataContext;
            }
        }
    }
}
