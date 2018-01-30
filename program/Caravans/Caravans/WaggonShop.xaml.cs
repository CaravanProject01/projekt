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
            iljabtour.DataContext = this;
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


