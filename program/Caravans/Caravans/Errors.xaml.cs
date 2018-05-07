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
    /// Логика взаимодействия для Errors.xaml
    /// </summary>
    public partial class Errors : Window
    {
        string mes;
        public Errors(string a)
        {
            mes = a;
            InitializeComponent();
            wiadomosc.DataContext = this;
        }

        public string MES
        {
            get { return mes; }
            set { mes = value; }
        }

        private void Exiterror_Click(object sender, RoutedEventArgs e) => Close();


    }
}
