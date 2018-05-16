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
using Caravans.matma;

//ten using ma stąd zniknąć!!!
using Caravans.model;

namespace Caravans
{

    public partial class Podroz : Window
    {
        string id;
        public Podroz(string a)
        {
            id = a;
            InitializeComponent();
        }
        private void exitP_Click(object sender, RoutedEventArgs e) => Close();

        private void Btourilguard_Click(object sender, RoutedEventArgs e)
        {
            podroz.podrozdo("MI01",id);
            Close();
            GamesWindow.z1();
        }
        private void BEdgetown_Click(object sender, RoutedEventArgs e)
        {
            podroz.podrozdo("MI02",id);
            Close();
            GamesWindow.z1();
        }
        private void BRivercross_Click(object sender, RoutedEventArgs e)
        {
            podroz.podrozdo("MI03",id);
            Close();
            GamesWindow.z1();
        }
        private void BSinTog_Click(object sender, RoutedEventArgs e)
        {
            podroz.podrozdo("MI04",id);
            Close();
            GamesWindow.z1();
        }
        private void BPortfolk_Click(object sender, RoutedEventArgs e)
        {
            podroz.podrozdo("MI05",id);
            Close();
            GamesWindow.z1();
        }
        private void BMountainroot_Click(object sender, RoutedEventArgs e)
        {
            podroz.podrozdo("MI06",id);
            Close();
            GamesWindow.z1();
        }
        private void BBottomStream_Click(object sender, RoutedEventArgs e)
        {
            podroz.podrozdo("MI07",id);
            Close();
            GamesWindow.z1();
        }
        private void BBlackyardt_Click(object sender, RoutedEventArgs e)
        {
            podroz.podrozdo("MI08",id);
            Close();
            GamesWindow.z1();
        }
        private void BLakeshiret_Click(object sender, RoutedEventArgs e)
        {
            podroz.podrozdo("MI09",id);
            Close();
            GamesWindow.z1();
        }
        private void BLothrant_Click(object sender, RoutedEventArgs e)
        {
            podroz.podrozdo("MI10",id);
            Close();
            GamesWindow.z1();
        }
        private void BWaterclaw_Click(object sender, RoutedEventArgs e)
        {
            podroz.podrozdo("MI11",id);
            Close();
            GamesWindow.z1();
        }
        private void BHightown_Click(object sender, RoutedEventArgs e)
        {
            podroz.podrozdo("MI12",id);
            Close();
            GamesWindow.z1();
        }
    }
}
