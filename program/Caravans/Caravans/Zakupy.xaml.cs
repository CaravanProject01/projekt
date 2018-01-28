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
using Caravans.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;


namespace Caravans
{
    /// <summary>
    /// Логика взаимодействия для Zakupy.xaml
    /// </summary>
    public partial class Zakupy : Window
    {
        //te zmienne prawdopodobnie pójdą do śmieci
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
        static string idm = "MI10";
        static string idk = "KA01";

        //wsadza dane do powyższych zmiennych (włącznie z wywowałem funckji policzenia cen)
        private static wjazd dane = new wjazd(idm);

        //lista cen i ilości: IK-ilość w karawanie, IM-ilość w mieście, CK-cena kupna, CS-cena sprzedarzy
        string tkanIK;
        string tkanIM = dane.getIle("TO03");
        string tkanCK = dane.getCenaKup("TO03");
        string tkanCS = dane.getCenaSp("TO03");

        string winoIK;
        string winoIM = dane.getIle("TO09");
        string winoCK = dane.getCenaKup("TO09");
        string winoCS = dane.getCenaSp("TO09");

        string bronIK;
        string bronIM = dane.getIle("TO06");
        string bronCK = dane.getCenaKup("TO06");
        string bronCS = dane.getCenaSp("TO06");

        string chlebIK;
        string chlebIM = dane.getIle("TO05");
        string chlebCK = dane.getCenaKup("TO05");
        string chlebCS = dane.getCenaSp("TO05");

        string drewIK;
        string drewIM = dane.getIle("TO01");
        string drewCK = dane.getCenaKup("TO01");
        string drewCS = dane.getCenaSp("TO01");

        string jablIK;
        string jablIM = dane.getIle("TO02");
        string jablCK = dane.getCenaKup("TO02");
        string jablCS = dane.getCenaSp("TO02");

        string miesoIK;
        string miesoIM = dane.getIle("TO04");
        string miesoCK = dane.getCenaKup("TO04");
        string miesoCS = dane.getCenaSp("TO04");

        string perlIK;
        string perlIM = dane.getIle("TO07");
        string perlCK = dane.getCenaKup("TO07");
        string perlCS = dane.getCenaSp("TO07");

        string skrIK;
        string skrIM = dane.getIle("TO10");
        string skrCK = dane.getCenaKup("TO10");
        string skrCS = dane.getCenaSp("TO10");

        string alchIK;
        string alchIM = dane.getIle("TO11");
        string alchCK = dane.getCenaKup("TO11");
        string alchCS = dane.getCenaSp("TO11");

        string przypIK;
        string przypIM = dane.getIle("TO08");
        string przypCK = dane.getCenaKup("TO08");
        string przypCS = dane.getCenaSp("TO08");







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
        //Muszą także zmieniać wyświetlana ilość towaru
        private void sprzedarz(string IDkarawana, string IDmiasto, string IDtowar, int ile, int cena) { }
        private void kupowanie(string IDkarawana, string IDmiasto, string IDtowar, int ile, int cena) { }

        private void exitZ_Click(object sender, RoutedEventArgs e) => Close();



        private void buttonT1_Click(object sender, RoutedEventArgs e)//tkanina sprzedaj
        {
            int x = Convert.ToInt32(tkan.Text);
            int y = Convert.ToInt32(tkanCS);
            sprzedarz(idk, idm, "TO03", x, y);
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
            int y = Convert.ToInt32(tkanCK);
            kupowanie(idk, idm, "TO03", x, y);
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
            int y = Convert.ToInt32(winoCS);
            sprzedarz(idk, idm, "TO09", x, y);
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
            int y = Convert.ToInt32(winoCK);
            kupowanie(idk, idm, "TO09", x, y);
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
            int y = Convert.ToInt32(bronCS);
            sprzedarz(idk, idm, "TO06", x, y);
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
            int y = Convert.ToInt32(bronCK);
            kupowanie(idk, idm, "TO06", x, y);
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
            int y = Convert.ToInt32(chlebCS);
            sprzedarz(idk, idm, "TO05", x, y);
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
            int y = Convert.ToInt32(chlebCK);
            kupowanie(idk, idm, "TO05", x, y);
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
            int y = Convert.ToInt32(drewCS);
            sprzedarz(idk, idm, "TO01", x, y);
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
            int y = Convert.ToInt32(drewCK);
            kupowanie(idk, idm, "TO01", x, y);
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
            int y = Convert.ToInt32(jablCS);
            sprzedarz(idk, idm, "TO02", x, y);
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
            int y = Convert.ToInt32(jablCK);
            kupowanie(idk, idm, "TO02", x, y);
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
            int y = Convert.ToInt32(miesoCS);
            sprzedarz(idk, idm, "TO04", x, y);
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
            int y = Convert.ToInt32(miesoCK);
            kupowanie(idk, idm, "TO04", x, y);
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
            int y = Convert.ToInt32(perlCS);
            sprzedarz(idk, idm, "TO07", x, y);
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
            int y = Convert.ToInt32(perlCK);
            kupowanie(idk, idm, "TO07", x, y);
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
            int y = Convert.ToInt32(skrCS);
            sprzedarz(idk, idm, "TO10", x, y);
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
            int y = Convert.ToInt32(skrCK);
            kupowanie(idk, idm, "TO10", x, y);
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
            int y = Convert.ToInt32(alchCS);
            sprzedarz(idk, idm, "TO11", x, y);
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
            int y = Convert.ToInt32(alchCK);
            kupowanie(idk, idm, "TO11", x, y);
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
            int y = Convert.ToInt32(przypCS);
            sprzedarz(idk, idm, "TO08", x, y);
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
            int y = Convert.ToInt32(przypCK);
            kupowanie(idk, idm, "TO08", x, y);
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
