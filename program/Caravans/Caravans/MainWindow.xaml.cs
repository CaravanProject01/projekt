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

namespace Caravans
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        public static GamesWindow wi;

        private void Bauthors_Click(object sender, RoutedEventArgs e)
        {
            authors au = new authors();
            au.Show();
        }

        private void Bexit_Click(object sender, RoutedEventArgs e) => Close();

        private void Bplay_Click(object sender, RoutedEventArgs e)
        {
            Modele x = new Modele();
            wi = new GamesWindow();
            wi.Show();
            this.Close();
        }

        public static void odzwierzGlowne()
        {
            wi.odswiez();
        }

    }
}
