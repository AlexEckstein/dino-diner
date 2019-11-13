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
    /// Interaction logic for CustomizePterodatylWings.xaml
    /// </summary>
    public partial class CustomizePterodatylWings : Page
    {
        PterodactylWings wings;
        CretaceousCombo combo;
        public CustomizePterodatylWings(PterodactylWings wings)
        {
            InitializeComponent();
            this.wings = wings;
        }
        public CustomizePterodatylWings(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void HoldWingSauceButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.wings.HoldSauce();
            }
            else
            {
                if (combo.Entree is PterodactylWings w)
                {
                    w.HoldSauce();
                }
            }
        }
    }
}
