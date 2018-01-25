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
using System.Windows.Shapes;
using Caravans.model;

namespace Caravans
{
    /// <summary>
    /// Логика взаимодействия для WaggonShop.xaml
    /// </summary>
    public partial class WaggonShop : Window
    {

        string lokal1 = Modele.Nazwalokacji();
        public string LOK
        {
            get { return lokal1; }
            set { lokal1 = value; }
        }

        public WaggonShop()
        {
            InitializeComponent();
            lokal.DataContext = this;
        }

        private void ExitW_Click(object sender, RoutedEventArgs e) => Close();

        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            Zakupy za = new Zakupy();
            za.Show();
        }
        private void Podroz_Click(object sender, RoutedEventArgs e)
        {
            Podroz po = new Podroz();
            po.Show();
        }
    }
}


