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
    /// Логика взаимодействия для Zakupy.xaml
    /// </summary>
    public partial class Zakupy : Window
    {
        string iljabwag = "1000" ;
        string iltreew = "1000";
        string ilmeatt = "1000";
        string ilchlebw = "1000";
        string ilbronw = "1000";
        string ilwinow = "1000";
        string iltkaninaw = "1000";
        string ilperlaw = "1000";
        string ilprzypraw = "1000";
        string ilskoraw = "1000";

    
        public string ILSKORAWAG
        {
            get { return ilskoraw; }
            set { ilskoraw = value; }
        }
        public string ILPRZYPRAWAG
        {
            get { return ilprzypraw; }
            set { ilprzypraw = value; }
        }
        public string ILPERLAWAG
        {
            get { return ilperlaw; }
            set { ilperlaw = value; }
        }
        public string ILTKANINAWAG
        {
            get { return iltkaninaw; }
            set { iltkaninaw = value; }
        }
        public string ILWINOWAG
        {
            get { return ilwinow; }
            set { ilwinow = value; }
        }
        public string ILJABWAG
        {
            get { return iljabwag; }
            set { iljabwag = value; }
        }
        public string ILTREE
        {
            get { return iltreew; }
            set { iltreew = value; }
        }
        public string ILMEAT
        {
            get { return ilmeatt; }
            set { ilmeatt = value; }
        }
        public string ILCHLEB
        {
            get { return ilchlebw; }
            set { ilchlebw = value; }
        }
        public string ILBRON
        {
            get { return ilbronw; }
            set { ilbronw = value; }
        }


        public Zakupy()
        {
            InitializeComponent();
            iljabwagt.DataContext = this;
            iltreewag.DataContext = this;
            ilmeatwag.DataContext = this;
            ilchlebwag.DataContext = this;
            ilbronwag.DataContext = this;
            ilwinowag.DataContext = this;
            iltkaninawag.DataContext = this;
            ilperlawag.DataContext = this;
            ilskorawag.DataContext = this;
            ilprzyprawywag.DataContext = this;
            ilskorawag.DataContext = this;

        }

        private void exitZ_Click(object sender, RoutedEventArgs e) => Close();

    

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
     
}
