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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Caravans
{
   
    /// <summary>
    /// Логика взаимодействия для MiastoTour.xaml
    /// </summary>
    public partial class MiastoTour : Window
    {

        string illud="1000" ;
        
        public string ILLUD
        {
            get { return illud; }
            set { illud = value;}
        }

        public MiastoTour()
        {
            InitializeComponent();
            Ludnosc.DataContext = this;

        }
        private void ExitM_Click(object sender, RoutedEventArgs e) => Close();


    }

}
