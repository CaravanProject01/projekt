﻿using Caravans.Properties;
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
using Caravans.matma;

namespace Caravans
{

    public partial class GamesWindow : Window
    {
        public static WaggonShop wa;
        public static MainWindow mi;
        public static MiastoTour mt;

        public Boolean kar = false;

        public static string kasa = przekaznik.DajKaseS();
        public static string czas = przekaznik.DajCzasS();

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

            kasa = przekaznik.DajKaseS();
            czas = przekaznik.DajCzasS();
            zegarek.Text = czas;
            textBlock.Text = kasa;
        }


        private void Bmenu_Click(object sender, RoutedEventArgs e)
        {
            mi = new MainWindow();
            mi.Show();
            this.Close();
        }

        private void BWaggon_Click(object sender, RoutedEventArgs e)
        {
            kar = true;
            wa = new WaggonShop();
            wa.Show();
        }


        private void Bend_Click(object sender, RoutedEventArgs e)
        {
            czas cz = new czas();
            cz.tura();
            odswiez();
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
            kasa = przekaznik.DajKaseS();
            czas = przekaznik.DajCzasS();

            if(kar==true) odswiezKarawane();
            zegarek.Text = czas;
            textBlock.Text = kasa;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            gra.zapisz();
        }

        public static void napadliNas(string a)
        {
            Errors er = new Errors("Napad!!!", a);
            er.Show();
        }

        public void zbankrutowales()
        {
            mi = new MainWindow();
            mi.Show();
            Errors er = new Errors("Przegrana", "Złoto się skończyło, zbankrutowałeś");
            er.Show();
            this.Close();
        }
    }
}
