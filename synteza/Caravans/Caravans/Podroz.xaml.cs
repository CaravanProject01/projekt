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
        }
        private void BEdgetown_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI02","KA01");
        }
        private void BRivercross_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI03","KA01");
        }
        private void BSinTog_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI04","KA01");
        }
        private void BPortfolk_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI05","KA01");
        }
        private void BMountainroot_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI06","KA01");
        }
        private void BBottomStream_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI07","KA01");
        }
        private void BBlackyardt_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI08","KA01");
        }
        private void BLakeshiret_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI09","KA01");
        }
        private void BLothrant_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI10","KA01");
        }
        private void BWaterclaw_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI11","KA01");
        }
        private void BHightown_Click(object sender, RoutedEventArgs e)
        {
            podrozdo("MI1q","KA01");
        }

        private void podrozdo(string a,string b ){
            
        }
    }
}
