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
            MainWindow mi = new MainWindow();
            mi.Show();
            this.Close();
        }

        private void Btourilguard_Click(object sender, RoutedEventArgs e)
        {
            MiastoTour mt = new MiastoTour();
            mt.Show();
        }

        private void BWaggon_Click(object sender, RoutedEventArgs e)
        {
            WaggonShop wa = new WaggonShop();
            wa.Show();
        }


        private void Bend_Click(object sender, RoutedEventArgs e)
        {
            endturn();
            czas = Modele.getTimeS();
            zegarek.Text = czas;
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

        private void endturn()
        {
            Modele.time += 1;
            foreach (TableCaravan x in Modele.tableCaravan)//odejmujemy jedna ture od karawan
            {
                x.ChangeDuration(); // tu juz jest kontrola czy jest zero tur (przynajmniej powinno)

            }
            dzien z = new dzien();
            z.nowyDzien();
            tydzien y = new tydzien();
            if (Modele.time % 7 == 0) y.nowyTydzien();
        }
    }
}

//novoe_okno st = new novoe_okno();
//st.Show();
//this.Close()