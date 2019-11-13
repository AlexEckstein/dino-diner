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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        DinoNuggets nugs;
        CretaceousCombo combo;
        public CustomizeDinoNuggets(DinoNuggets nuggets)
        {
            InitializeComponent();
            this.nugs = nuggets;
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void AddNuggetButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.nugs.AddNugget();
            }
            else
            {
                if (combo.Entree is DinoNuggets nugs)
                {
                    nugs.AddNugget();
                }
            }
        }
    }
}
