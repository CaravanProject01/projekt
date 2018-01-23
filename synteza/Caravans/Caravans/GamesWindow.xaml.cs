using Caravans.Properties;
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

namespace Caravans
{
   
    public partial class GamesWindow : Window
    {
        string kasa="2345";

        public string Kasa
        {
            get { return kasa; }
            set { kasa = value;}
        }

     


        public GamesWindow() => InitializeComponent();
        private void Bmenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mi = new MainWindow();
            mi.Show();
            this.Close();
        }

        private void Btourilguard_Click(object sender, RoutedEventArgs e)
        {
            MiastoTour mt = new MiastoTour();
            mt.Show();
        }

        private void Waggon_Click(object sender, RoutedEventArgs e)
        {
           WaggonShop wa = new WaggonShop();
            wa.Show();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

//novoe_okno st = new novoe_okno();
//st.Show();
//this.Close()