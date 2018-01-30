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
    /// Логика взаимодействия для Podroz.xaml
    /// </summary>
    public partial class Podroz : Window
    {
        public Podroz()
        {
            InitializeComponent();
        }
        private void exitP_Click(object sender, RoutedEventArgs e) => Close();

        private void Btourilguard_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI01","KA01");
            Close();
        }
        private void BEdgetown_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI02","KA01");
            Close();
        }
        private void BRivercross_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI03","KA01");
            Close();
        }
        private void BSinTog_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI04","KA01");
            Close();
        }
        private void BPortfolk_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI05","KA01");
            Close();
        }
        private void BMountainroot_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI06","KA01");
            Close();
        }
        private void BBottomStream_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI07","KA01");
            Close();
        }
        private void BBlackyardt_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI08","KA01");
            Close();
        }
        private void BLakeshiret_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI09","KA01");
            Close();
        }
        private void BLothrant_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI10","KA01");
            Close();
        }
        private void BWaterclaw_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI11","KA01");
            Close();
        }
        private void BHightown_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI12","KA01");
            Close();
        }

        private void podrozdo(string miastoid, string karawanaid)
        {
            foreach (TableCaravan x in Modele.tableCaravan)//tu trz bd zmienic na liste 
            {
                if (x.GetId() == karawanaid)
                {
                    foreach (TableTown y in Modele.tableTown)
                    {
                        if (y.GetId() == miastoid)
                        {
                            foreach (TableRoad z in Modele.tableRoad)
                            {
                                if (y.GetIdLoc() == z.GetIdLoc_1() && x.GetIdLoc() == z.GetIdLoc_2() && x.GetDuration() == 0)
                                {
                                    x.SetDuration(z.GetLength());
                                    x.SetIdLoc(z.GetIdLoc_1());
                                }
                                else if (y.GetIdLoc() == z.GetIdLoc_2() && x.GetIdLoc() == z.GetIdLoc_1() && x.GetDuration() == 0)
                                {
                                    x.SetDuration(z.GetLength());
                                    x.SetIdLoc(z.GetIdLoc_2());
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
