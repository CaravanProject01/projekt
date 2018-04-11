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
using Caravans.model;
using Caravans.matma;

namespace Caravans
{

    public partial class GamesWindow : Window
    {
        public static WaggonShop wa;
        public static MainWindow mi;
        public static MiastoTour mt;
        
        string kasa = Modele.getGoldS();
        string czas = Modele.getTimeS();

        public string KASA
        {
            get { return kasa; }
            set { kasa = value; }
        }
        public string CZAS
        {
            get { return czas; }
            set { czas = value; }
        }

        public GamesWindow()
        {
            InitializeComponent();
            textBlock.DataContext=this;
            zegarek.DataContext = this;
        }

        private void Bmenu_Click(object sender, RoutedEventArgs e)
        {
            mi = new MainWindow();
            mi.Show();
            this.Close();
        }

        private void Btourilguard_Click(object sender, RoutedEventArgs e)
        {
            mt = new MiastoTour();
            mt.Show();
        }

        private void BWaggon_Click(object sender, RoutedEventArgs e)
        {
            wa = new WaggonShop();
            wa.Show();
        }


        private void Bend_Click(object sender, RoutedEventArgs e)
        {
            czas cz = new czas();
            cz.tura();
            odswiez();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {

        }

        public static void z1()
        {
            wa.Close();
        }

        public static void odswiezKarawane()
        {
            wa.odswiez();
        }

        public void odswiez()
        {
            czas = Modele.getTimeS();
            zegarek.Text = czas;
            kasa = Modele.getGoldS();
            textBlock.Text = kasa;
        }
       
    }
}

//novoe_okno st = new novoe_okno();
//st.Show();
//this.Close()