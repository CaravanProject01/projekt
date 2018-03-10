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
        static string idk = "KA01";

        string tkanIK = Modele.IleTowaru(idk, "TO03");       
        string winoIK = Modele.IleTowaru(idk, "TO09");
        string bronIK = Modele.IleTowaru(idk, "TO06");      
        string chlebIK = Modele.IleTowaru(idk, "TO05");
        string drewIK = Modele.IleTowaru(idk, "TO01");
        string jablIK = Modele.IleTowaru(idk, "TO02");
        string miesoIK = Modele.IleTowaru(idk, "TO04");
        string perlIK = Modele.IleTowaru(idk, "TO07");
        string skrIK = Modele.IleTowaru(idk, "TO10");
        string alchIK = Modele.IleTowaru(idk, "TO11");
        string przypIK = Modele.IleTowaru(idk, "TO08");

        public string ileTkanKar
        {
            get { return tkanIK; }
            set { tkanIK = value; }
        }

        public string ileWinoKar
        {
            get { return winoIK; }
            set { winoIK = value; }
        }

        public string ileBronKar
        {
            get { return bronIK; }
            set { bronIK = value; }
        }

        public string ileChlebKar
        {
            get { return chlebIK; }
            set { chlebIK = value; }
        }

        public string ileDrewKar
        {
            get { return drewIK; }
            set { drewIK = value; }
        }

        public string ileJablKar
        {
            get { return jablIK; }
            set { jablIK = value; }
        }

        public string ileMiesKar
        {
            get { return miesoIK; }
            set { miesoIK = value; }
        }

        public string ilePelrKar
        {
            get { return perlIK; }
            set { perlIK = value; }
        }

        public string ileSkorKar
        {
            get { return skrIK; }
            set { skrIK = value; }
        }

        public string ileAlchKar
        {
            get { return alchIK; }
            set { alchIK = value; }
        }

        public string ilePrzypKar
        {
            get { return przypIK; }
            set { przypIK = value; }
        }

        string lokal1 = lokalizuj();
        public string LOK
        {
            get { return lokal1; }
            set { lokal1 = value; }
        }

        public WaggonShop()
        {
            InitializeComponent();
            lokal.DataContext = this;
            iljabtour.DataContext = this;
            iltreetour.DataContext = this;
            ilmeattour.DataContext = this;
            ilchlebtour.DataContext = this;
            ilbrontour.DataContext = this;
            ilwinotour.DataContext = this;
            iltkaninatour.DataContext = this;
            ilperlatour.DataContext = this;
            ilskoratour.DataContext = this;
            ilsrodtour.DataContext = this;
            ilprzyprawytour.DataContext = this;

            int jazda = Modele.dajCzas(idk);
            if (jazda == 0)
            {
                shop.IsEnabled = true;
                podroz.IsEnabled = true;
            }
            else
            {
                shop.IsEnabled = false;
                podroz.IsEnabled = false;
            }
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

        private static string lokalizuj()
        {
            string roboczy;
            string nazwa="";
            int czas=0;
            string idl="";
            foreach (TableCaravan kar in Modele.tableCaravan)
            {
                roboczy = kar.GetId();
                if (roboczy == idk)
                {
                    idl = kar.GetIdLoc();
                    czas = kar.GetDuration();
                }
            }
            foreach (TableTown miasto in Modele.tableTown)
            {
                roboczy = miasto.GetIdLoc();
                if (roboczy == idl)
                {
                    nazwa = miasto.GetName();
                }
            }

            if (czas == 0)
            {
                return nazwa;
            }
            else
            {
                string wynik = "W drodze do " + nazwa + " pozostało " + czas + " tur";
                return wynik;

            }
            
        }

        public void odswiez()
        {
            string jablka=Modele.IleTowaru(idk, "TO02");
            string drewno = Modele.IleTowaru(idk, "TO01");
            string mieso = Modele.IleTowaru(idk, "TO04");
            string chleb = Modele.IleTowaru(idk, "TO05");
            string bron = Modele.IleTowaru(idk, "TO06");
            string wino = Modele.IleTowaru(idk, "TO09");
            string tkanina = Modele.IleTowaru(idk, "TO03");
            string perla = Modele.IleTowaru(idk, "TO07");
            string skora = Modele.IleTowaru(idk, "TO10");
            string przyprawy = Modele.IleTowaru(idk, "TO08");
            string alchemia = Modele.IleTowaru(idk, "TO11");

            iljabtour.Text = jablka;
            iltreetour.Text = drewno;
            ilmeattour.Text = mieso;
            ilchlebtour.Text = chleb;
            ilbrontour.Text = bron;
            ilwinotour.Text = wino;
            iltkaninatour.Text = tkanina;
            ilperlatour.Text = perla;
            ilskoratour.Text = skora;
            ilsrodtour.Text = alchemia;
            ilprzyprawytour.Text = przyprawy;

        }
    }
}


