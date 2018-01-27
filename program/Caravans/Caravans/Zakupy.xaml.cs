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
        string iljabwag = "1000";
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

        //ID karawany i miasta-puki co przypisane odgórnie, potem się zrobi by jakoś szukało tych danych
        string idm = "MI10";
        string idk = "KA01";

        /*
         nie wiem co to za funkcje, potencjalnie niepotrzebne-jesli miały obsługiwać przyciski przy chandlu bronią, to na pewno nie potrzebne         
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
        */

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

        //w te funkcje należy wkleić kod od kamila
        //WAŻNE-przed faktyczną wymianą należy sprawdzić czy ilość towaru i kasa sie zgadzają-by nie było ujemnych towarów w mieście
        private void sprzedarz(string IDkarawana, string IDmiasto, string IDtowar, int ile) { }
        private void kupowanie(string IDkarawana, string IDmiasto, string IDtowar, int ile) { }

        private void exitZ_Click(object sender, RoutedEventArgs e) => Close();



        private void buttonT1_Click(object sender, RoutedEventArgs e)//tkanina sprzedaj
        {
            int x = Convert.ToInt32(tkan.Text);
            sprzedarz(idk, idm, "TO03", x);
        }

        private void buttonT2_Click(object sender, RoutedEventArgs e)//tkanina -
        {
            int x;
            x = Convert.ToInt32(tkan.Text);
            if (x > 0) { x--; }
            tkan.Text = x.ToString();
        }

        private void buttonT3_Click(object sender, RoutedEventArgs e)//tkanina kup
        {
            int x = Convert.ToInt32(tkan.Text);
            kupowanie(idk, idm, "TO03", x);
        }

        private void buttonT4_Click(object sender, RoutedEventArgs e)//tkanina +
        {
            int x;
            x = Convert.ToInt32(tkan.Text);
            x++;
            tkan.Text = x.ToString();
        }

        private void buttonW1_Click(object sender, RoutedEventArgs e)//wino sprzedaj
        {
            int x = Convert.ToInt32(wino.Text);
            sprzedarz(idk, idm, "TO09", x);
        }

        private void buttonW2_Click(object sender, RoutedEventArgs e)//wino -
        {
            int x;
            x = Convert.ToInt32(wino.Text);
            if (x > 0) { x--; }
            wino.Text = x.ToString();
        }

        private void buttonW3_Click(object sender, RoutedEventArgs e)//wino kup
        {
            int x = Convert.ToInt32(wino.Text);
            kupowanie(idk, idm, "TO09", x);
        }

        private void buttonW4_Click(object sender, RoutedEventArgs e)//wino +
        {
            int x;
            x = Convert.ToInt32(wino.Text);
            x++;
            wino.Text = x.ToString();
        }

        private void buttonB1_Click(object sender, RoutedEventArgs e)//bron sprzedaj
        {
            int x = Convert.ToInt32(bron.Text);
            sprzedarz(idk, idm, "TO06", x);
        }

        private void buttonB2_Click(object sender, RoutedEventArgs e)//bron -
        {
            int x;
            x = Convert.ToInt32(bron.Text);
            if (x > 0) { x--; }
            bron.Text = x.ToString();
        }

        private void buttonB3_Click(object sender, RoutedEventArgs e)//bron kup
        {
            int x = Convert.ToInt32(bron.Text);
            kupowanie(idk, idm, "TO06", x);
        }

        private void buttonB4_Click(object sender, RoutedEventArgs e)//bron +
        {
            int x;
            x = Convert.ToInt32(bron.Text);
            x++;
            bron.Text = x.ToString();
        }

        private void buttonC1_Click(object sender, RoutedEventArgs e)//chleb sprzedaj
        {
            int x = Convert.ToInt32(hleb.Text);
            sprzedarz(idk, idm, "TO05", x);
        }

        private void buttonC2_Click(object sender, RoutedEventArgs e)//chleb -
        {
            int x;
            x = Convert.ToInt32(hleb.Text);
            if (x > 0) { x--; }
            hleb.Text = x.ToString();
        }

        private void buttonC3_Click(object sender, RoutedEventArgs e)//chleb kup
        {
            int x = Convert.ToInt32(hleb.Text);
            kupowanie(idk, idm, "TO05", x);
        }

        private void buttonC4_Click(object sender, RoutedEventArgs e)//chleb +
        {
            int x;
            x = Convert.ToInt32(hleb.Text);
            x++;
            hleb.Text = x.ToString();
        }

        private void buttonD1_Click(object sender, RoutedEventArgs e)//drewno sprzedaj
        {
            int x = Convert.ToInt32(brondrz.Text);
            sprzedarz(idk, idm, "TO01", x);
        }

        private void buttonD2_Click(object sender, RoutedEventArgs e)//drewno -
        {
            int x;
            x = Convert.ToInt32(brondrz.Text);
            if (x > 0) { x--; }
            brondrz.Text = x.ToString();
        }

        private void buttonD3_Click(object sender, RoutedEventArgs e)//drewno kup
        {
            int x = Convert.ToInt32(brondrz.Text);
            kupowanie(idk, idm, "TO01", x);
        }

        private void buttonD4_Click(object sender, RoutedEventArgs e)//drewno +
        {
            int x;
            x = Convert.ToInt32(brondrz.Text);
            x++;
            brondrz.Text = x.ToString();
        }

        private void buttonJ1_Click(object sender, RoutedEventArgs e)//jabłko sprzedaj
        {
            int x = Convert.ToInt32(jabl.Text);
            sprzedarz(idk, idm, "TO02", x);
        }

        private void buttonJ2_Click(object sender, RoutedEventArgs e)//jabłko -
        {
            int x;
            x = Convert.ToInt32(jabl.Text);
            if (x > 0) { x--; }
            jabl.Text = x.ToString();
        }

        private void buttonJ3_Click(object sender, RoutedEventArgs e)//jabłko kup
        {
            int x = Convert.ToInt32(jabl.Text);
            kupowanie(idk, idm, "TO02", x);
        }

        private void buttonJ4_Click(object sender, RoutedEventArgs e)//jabłko +
        {
            int x;
            x = Convert.ToInt32(jabl.Text);
            x++;
            jabl.Text = x.ToString();
        }

        private void buttonM1_Click(object sender, RoutedEventArgs e)//mięso sprzedaj
        {
            int x = Convert.ToInt32(mies.Text);
            sprzedarz(idk, idm, "TO04", x);
        }

        private void buttonM2_Click(object sender, RoutedEventArgs e)//mięso -
        {
            int x;
            x = Convert.ToInt32(mies.Text);
            if (x > 0) { x--; }
            mies.Text = x.ToString();
        }

        private void buttonM3_Click(object sender, RoutedEventArgs e)//mięso kup
        {
            int x = Convert.ToInt32(mies.Text);
            kupowanie(idk, idm, "TO04", x);
        }

        private void buttonM4_Click(object sender, RoutedEventArgs e)//mięso +
        {
            int x;
            x = Convert.ToInt32(mies.Text);
            x++;
            mies.Text = x.ToString();
        }

        private void buttonP1_Click(object sender, RoutedEventArgs e)//perła sprzedaj
        {
            int x = Convert.ToInt32(perl.Text);
            sprzedarz(idk, idm, "TO07", x);
        }

        private void buttonP2_Click(object sender, RoutedEventArgs e)//perła -
        {
            int x;
            x = Convert.ToInt32(perl.Text);
            if (x > 0) { x--; }
            perl.Text = x.ToString();
        }

        private void buttonP3_Click(object sender, RoutedEventArgs e)//perła kup
        {
            int x = Convert.ToInt32(perl.Text);
            kupowanie(idk, idm, "TO07", x);
        }

        private void buttonP4_Click(object sender, RoutedEventArgs e)//perła +
        {
            int x;
            x = Convert.ToInt32(perl.Text);
            x++;
            perl.Text = x.ToString();
        }

        private void buttonS1_Click(object sender, RoutedEventArgs e)//skóra sprzedaj
        {
            int x = Convert.ToInt32(skur.Text);
            sprzedarz(idk, idm, "TO10", x);
        }

        private void buttonS2_Click(object sender, RoutedEventArgs e)//skóra -
        {
            int x;
            x = Convert.ToInt32(skur.Text);
            if (x > 0) { x--; }
            skur.Text = x.ToString();
        }

        private void buttonS3_Click(object sender, RoutedEventArgs e)//skóra kup
        {
            int x = Convert.ToInt32(skur.Text);
            kupowanie(idk, idm, "TO10", x);
        }

        private void buttonS4_Click(object sender, RoutedEventArgs e)//skóra +
        {
            int x;
            x = Convert.ToInt32(skur.Text);
            x++;
            skur.Text = x.ToString();
        }

        private void buttonA1_Click(object sender, RoutedEventArgs e)//alchemia sprzedaj
        {
            int x = Convert.ToInt32(srodki.Text);
            sprzedarz(idk, idm, "TO11", x);
        }

        private void buttonA2_Click(object sender, RoutedEventArgs e)//alchemia -
        {
            int x;
            x = Convert.ToInt32(srodki.Text);
            if (x > 0) { x--; }
            srodki.Text = x.ToString();
        }

        private void buttonA3_Click(object sender, RoutedEventArgs e)//alchemia kup
        {
            int x = Convert.ToInt32(srodki.Text);
            kupowanie(idk, idm, "TO11", x);
        }

        private void buttonA4_Click(object sender, RoutedEventArgs e)//alchemia +
        {
            int x;
            x = Convert.ToInt32(srodki.Text);
            x++;
            srodki.Text = x.ToString();
        }

        private void buttonX1_Click(object sender, RoutedEventArgs e)//przyprawy sprzedaj
        {
            int x = Convert.ToInt32(przyp.Text);
            sprzedarz(idk, idm, "TO08", x);
        }

        private void buttonX2_Click(object sender, RoutedEventArgs e)//przyprawy -
        {
            int x;
            x = Convert.ToInt32(przyp.Text);
            if (x > 0) { x--; }
            przyp.Text = x.ToString();
        }

        private void buttonX3_Click(object sender, RoutedEventArgs e)//przyprawy kup
        {
            int x = Convert.ToInt32(przyp.Text);
            kupowanie(idk, idm, "TO08", x);
        }

        private void buttonX4_Click(object sender, RoutedEventArgs e)//przyprawy +
        {
            int x;
            x = Convert.ToInt32(przyp.Text);
            x++;
            przyp.Text = x.ToString();
        }
    }

}
