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
        string cbron = "57.00";
        string ibron = "576";
        string csbron = "48.00";
        string br = "0";

        private void sprz_Click(object sender, RoutedEventArgs e)
        {
            spbro();
        }

        private void spbro()
        {

        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            minuso();
        }
        private void minuso()
        {

        }
        private void kup_Click(object sender, RoutedEventArgs e)
        {
            kupbro();
        }
        private void kupbro()
        {

        }
        private void pl_Click(object sender, RoutedEventArgs e)
        {
            plusbro();
        }
        private void plusbro()
        {

        }

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

        public string cenBRON
        {
            get { return cbron; }
            set { cbron = value; }
        }

        public string IBRM
        {
            get { return ibron; }
            set { ibron = value; }
        }

        public string CSBRON
        {
            get { return csbron; }
            set { csbron = value; }
        }
        public string BR
        {
            get { return br; }
            set { br = value; }
        }

        public Zakupy()
        {
            InitializeComponent();
            bron.DataContext = this;
            spbron.DataContext = this;
            ilbrontour.DataContext = this;
            cenabron.DataContext = this;
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
