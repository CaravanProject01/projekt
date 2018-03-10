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
        //ID karawany i miasta-puki co przypisane odgórnie, potem się zrobi by jakoś szukało tych danych
        static string idk = "KA01";
        static string idm = Modele.GdzieJestem(idk);
                
        //wsadza dane do powyższych zmiennych (włącznie z wywowałem funckji policzenia cen)
        private static wjazd dane = new wjazd(idm);

        //lista cen i ilości: IK-ilość w karawanie, IM-ilość w mieście, CK-cena kupna, CS-cena sprzedarzy
        //zmienienie tego co jest po znaku równości na "coś" zmienia wartość danej na "coś"-użyteczne przy testach

        //zmienić by wyciągało kasę z modelu czy łotewa
        string kasa = Modele.getGoldS();

        string tkanIK = Modele.IleTowaru(idk, "TO03");
        string tkanIM = dane.getIle("TO03");
        string tkanCK = dane.getCenaKup("TO03");
        string tkanCS = dane.getCenaSp("TO03");

        string winoIK = Modele.IleTowaru(idk, "TO09");
        string winoIM = dane.getIle("TO09");
        string winoCK = dane.getCenaKup("TO09");
        string winoCS = dane.getCenaSp("TO09");

        string bronIK = Modele.IleTowaru(idk, "TO06");
        string bronIM = dane.getIle("TO06");
        string bronCK = dane.getCenaKup("TO06");
        string bronCS = dane.getCenaSp("TO06");

        string chlebIK = Modele.IleTowaru(idk, "TO05");
        string chlebIM = dane.getIle("TO05");
        string chlebCK = dane.getCenaKup("TO05");
        string chlebCS = dane.getCenaSp("TO05");

        string drewIK = Modele.IleTowaru(idk, "TO01");
        string drewIM = dane.getIle("TO01");
        string drewCK = dane.getCenaKup("TO01");
        string drewCS = dane.getCenaSp("TO01");

        string jablIK = Modele.IleTowaru(idk, "TO02");
        string jablIM = dane.getIle("TO02");
        string jablCK = dane.getCenaKup("TO02");
        string jablCS = dane.getCenaSp("TO02");

        string miesoIK = Modele.IleTowaru(idk, "TO04");
        string miesoIM = dane.getIle("TO04");
        string miesoCK = dane.getCenaKup("TO04");
        string miesoCS = dane.getCenaSp("TO04");

        string perlIK = Modele.IleTowaru(idk, "TO07");
        string perlIM = dane.getIle("TO07");
        string perlCK = dane.getCenaKup("TO07");
        string perlCS = dane.getCenaSp("TO07");

        string skrIK = Modele.IleTowaru(idk, "TO10");
        string skrIM = dane.getIle("TO10");
        string skrCK = dane.getCenaKup("TO10");
        string skrCS = dane.getCenaSp("TO10");

        string alchIK = Modele.IleTowaru(idk, "TO11");
        string alchIM = dane.getIle("TO11");
        string alchCK = dane.getCenaKup("TO11");
        string alchCS = dane.getCenaSp("TO11");

        string przypIK = Modele.IleTowaru(idk, "TO08");
        string przypIM = dane.getIle("TO08");
        string przypCK = dane.getCenaKup("TO08");
        string przypCS = dane.getCenaSp("TO08");

        //tworzenie dodatkowych zmiennych-obiektów odpowiedzialnych za wyświelanie danych
        public string KASA
        {
            get { return kasa; }
            set { kasa = value; }
        }

        public string ileTkanKar
        {
            get { return tkanIK; }
            set { tkanIK = value; }
        }

        public string ileWinoKar
        {
            get { return winoIK; }
            set { winoIK = value; }
        }

        public string ileBronKar
        {
            get { return bronIK; }
            set { bronIK = value; }
        }

        public string ileChlebKar
        {
            get { return chlebIK; }
            set { chlebIK = value; }
        }

        public string ileDrewKar
        {
            get { return drewIK; }
            set { drewIK = value; }
        }

        public string ileJablKar
        {
            get { return jablIK; }
            set { jablIK = value; }
        }

        public string ileMiesKar
        {
            get { return miesoIK; }
            set { miesoIK = value; }
        }

        public string ilePelrKar
        {
            get { return perlIK; }
            set { perlIK = value; }
        }

        public string ileSkorKar
        {
            get { return skrIK; }
            set { skrIK = value; }
        }

        public string ileAlchKar
        {
            get { return alchIK; }
            set { alchIK = value; }
        }

        public string ilePrzypKar
        {
            get { return przypIK; }
            set { przypIK = value; }
        }

        public string ileTkanMi
        {
            get { return tkanIM; }
            set { tkanIM = value; }
        }

        public string ileWinoMi
        {
            get { return winoIM; }
            set { winoIM = value; }
        }

        public string ileBronMi
        {
            get { return bronIM; }
            set { bronIM = value; }
        }

        public string ileChlebMi
        {
            get { return chlebIM; }
            set { chlebIM = value; }
        }

        public string ileDrewMi
        {
            get { return drewIM; }
            set { drewIM = value; }
        }

        public string ileJablMi
        {
            get { return jablIM; }
            set { jablIM = value; }
        }

        public string ileMiesMi
        {
            get { return miesoIM; }
            set { miesoIM = value; }
        }

        public string ilePerlMi
        {
            get { return perlIM; }
            set { perlIM = value; }
        }

        public string ileSkorMi
        {
            get { return skrIM; }
            set { skrIM = value; }
        }

        public string ileAlchMi
        {
            get { return alchIM; }
            set { alchIM = value; }
        }

        public string ilePrzypMi
        {
            get { return przypIM; }
            set { przypIM = value; }
        }

        public string cenaTkanSp
        {
            get { return tkanCS; }
            set { tkanCS = value; }
        }

        public string cenaWinoSp
        {
            get { return winoCS; }
            set { winoCS = value; }
        }

        public string cenaBronSp
        {
            get { return bronCS; }
            set { bronCS = value; }
        }

        public string cenaChlebSp
        {
            get { return chlebCS; }
            set { chlebCS = value; }
        }

        public string cenaDrewSp
        {
            get { return drewCS; }
            set { drewCS = value; }
        }

        public string cenaJablSp
        {
            get { return jablCS; }
            set { jablCS = value; }
        }

        public string cenaMiesSp
        {
            get { return miesoCS; }
            set { miesoCS = value; }
        }

        public string cenaPerlSp
        {
            get { return perlCS; }
            set { perlCS = value; }
        }

        public string cenaSkorSp
        {
            get { return skrCS; }
            set { skrCS = value; }
        }

        public string cenaAlchSp
        {
            get { return alchCS; }
            set { alchCS = value; }
        }

        public string cenaPrzypSp
        {
            get { return przypCS; }
            set { przypCS = value; }
        }

        public string cenaTkanKup
        {
            get { return tkanCK; }
            set { tkanCK = value; }
        }

        public string cenaWinoKup
        {
            get { return winoCK; }
            set { winoCK = value; }
        }

        public string cenaBronKup
        {
            get { return bronCK; }
            set { bronCK = value; }
        }

        public string cenaChlebKup
        {
            get { return chlebCK; }
            set { chlebCK = value; }
        }

        public string cenaDrewKup
        {
            get { return drewCK; }
            set { drewCK = value; }
        }

        public string cenaJablKup
        {
            get { return jablCK; }
            set { jablCK = value; }
        }

        public string cenaMiesKup
        {
            get { return miesoCK; }
            set { miesoCK = value; }
        }

        public string cenaPerlKup
        {
            get { return perlCK; }
            set { perlCK = value; }
        }

        public string cenaSkorKup
        {
            get { return skrCK; }
            set { skrCK = value; }
        }

        public string cenaAlchKup
        {
            get { return alchCK; }
            set { alchCK = value; }
        }

        public string cenaPrzypKup
        {
            get { return przypCK; }
            set { przypCK = value; }
        }
        

        //ważne-inicjalizacja jeśli texbox ma wyświetlać coś co nie jest z góry przypisane, trzeba go tu zainicjalizować
        public Zakupy()
        {
            InitializeComponent();
            bron.DataContext = this;
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

            cenatkanina.DataContext = this;
            sptkanina.DataContext = this;
            iltkaninatour.DataContext = this;
            cenawino.DataContext = this;
            spWino.DataContext = this;
            ilwinotour.DataContext = this;
            cenabron.DataContext = this;
            spbron.DataContext = this;
            ilbrontour.DataContext = this;
            cenachleb.DataContext = this;
            spchleb.DataContext = this;
            ilchlebtour.DataContext = this;
            cenatree.DataContext = this;
            spdrzewo.DataContext = this;
            iltreetour.DataContext = this;
            cenahleb.DataContext = this;
            spjab.DataContext = this;
            iljabtour.DataContext = this;
            cenameate.DataContext = this;
            sptmieso.DataContext = this;
            ilmeattour.DataContext = this;
            cenaperla1.DataContext = this;
            spperla1.DataContext = this;
            ilperlatour1.DataContext = this;
            cenaskora.DataContext = this;
            spskora.DataContext = this;
            ilskoratour.DataContext = this;
            cenanafta.DataContext = this;
            spnafta.DataContext = this;
            ilnaftatour.DataContext = this;
            cenaprzyprawy.DataContext = this;
            spprzyprawy.DataContext = this;
            ilprzyprawytour.DataContext = this;

            GOLD.DataContext = this;
            nowy1.DataContext = this;

            zassaj();


        }

        //w te funkcje należy wkleić kod od kamila
        //WAŻNE-przed faktyczną wymianą należy sprawdzić czy ilość towaru i kasa sie zgadzają-by nie było ujemnych towarów w mieście
        //Muszą także zmieniać wyświetlana ilość towaru (nie wiem czy zmiana w bazie danych starczy-być może trzeba dodatkowo tu zmienić wartości w liście cen i ilości)
        private void sprzedarz(string IDkarawana, string IDmiasto, string IDtowar, int ile, int cena) {
            if (ile > 0)
            {
                foreach (TableArtInCaravan y in Modele.tableArtInCaravan)
                {
                    if (y.GetIdArticle() == IDtowar && ile <= y.GetNumber() && y.GetId() == IDkarawana)
                    {
                        foreach (TableArtInTown z in Modele.tableArtInTown)
                        {
                            if (z.GetId() == IDmiasto && z.GetIdArticle() == IDtowar)
                            {
                                Modele.setGold(Modele.getGold() + cena * ile);
                                y.SetNumber(y.GetNumber() - ile);
                                z.SetNumber(z.GetNumber() + ile);
                            }
                        }
                    }
                }
                zassaj();
                MainWindow.odzwierzGlowne();
            }
        }
        private void kupowanie(string IDkarawana, string IDmiasto, string IDtowar, int ile, int cena) {
            if (ile > 0)
            {
                foreach (TableArtInCaravan y in Modele.tableArtInCaravan)
                {
                    if (y.GetIdArticle() == IDtowar && y.GetId() == IDkarawana && cena <= Modele.getGold())
                    {
                        foreach (TableArtInTown z in Modele.tableArtInTown)
                        {
                            if (z.GetId() == IDmiasto && z.GetIdArticle() == IDtowar && ile <= z.GetNumber())
                            {
                                Modele.setGold(Modele.getGold() - cena * ile);
                                y.SetNumber(y.GetNumber() + ile);
                                z.SetNumber(z.GetNumber() - ile);
                            }
                        }
                    }
                }
                zassaj();
                MainWindow.odzwierzGlowne();
            }
            
        }
        private void exitZ_Click(object sender, RoutedEventArgs e) {
            Close();
            GamesWindow.odswiezKarawane();           
        }


        //funkcje obsługujące przyciski
        private void buttonT1_Click(object sender, RoutedEventArgs e)//tkanina sprzedaj
        {
            int x = Convert.ToInt32(tkan.Text);
            string zmienna = sptkanina.Text.ToString();
            int y = Convert.ToInt32(zmienna);
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = cenatkanina.Text.ToString();
            int y = 0;
            if (zmienna == "niemożliwe")
            {
                y = -1;
            }
            else
            {
                y = Convert.ToInt32(tkanCK);
            }
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = spWino.Text.ToString();
            int y = Convert.ToInt32(zmienna);
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = cenawino.Text.ToString();
            int y = 0;
            if (zmienna == "niemożliwe")
            {
                y = -1;
            }
            else
            {
                y = Convert.ToInt32(zmienna);
            }
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = spbron.Text.ToString();
            int y = Convert.ToInt32(zmienna);
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = cenabron.Text.ToString();
            int y = 0;
            if (zmienna == "niemożliwe")
            {
                y = -1;
            }
            else
            {
                y = Convert.ToInt32(zmienna);
            }
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = spchleb.Text.ToString();
            int y = Convert.ToInt32(zmienna);
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = cenachleb.Text.ToString();
            int y = 0;
            if (zmienna == "niemożliwe")
            {
                y = -1;
            }
            else
            {
                y = Convert.ToInt32(zmienna);
            }
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = spdrzewo.Text.ToString();
            int y = Convert.ToInt32(zmienna);
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = cenatree.Text.ToString();
            int y = 0;
            if (zmienna == "niemożliwe")
            {
                y = -1;
            }
            else
            {
                y = Convert.ToInt32(zmienna);
            }
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = spjab.Text.ToString();
            int y = Convert.ToInt32(zmienna);
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = cenahleb.Text.ToString();
            int y = 0;
            if (zmienna == "niemożliwe")
            {
                y = -1;
            }
            else
            {
                y = Convert.ToInt32(zmienna);
            }
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = sptmieso.Text.ToString();
            int y = Convert.ToInt32(zmienna);
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = cenameate.Text.ToString();
            int y = 0;
            if (zmienna == "niemożliwe")
            {
                y = -1;
            }
            else
            {
                y = Convert.ToInt32(zmienna);
            }
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = spperla1.Text.ToString();
            int y = Convert.ToInt32(zmienna);
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = cenaperla1.Text.ToString();
            int y = 0;
            if (zmienna == "niemożliwe")
            {
                y = -1;
            }
            else
            {
                y = Convert.ToInt32(zmienna);
            }
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = spskora.Text.ToString();
            int y = Convert.ToInt32(zmienna);
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = cenaskora.Text.ToString();
            int y = 0;
            if (zmienna == "niemożliwe")
            {
                y = -1;
            }
            else
            {
                y = Convert.ToInt32(zmienna);
            }
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = spnafta.Text.ToString();
            int y = Convert.ToInt32(zmienna);
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = cenanafta.Text.ToString();
            int y = 0;
            if (zmienna == "niemożliwe")
            {
                y = -1;
            }
            else
            {
                y = Convert.ToInt32(zmienna);
            }
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = spprzyprawy.Text.ToString();
            int y = Convert.ToInt32(zmienna);
            idm = Modele.GdzieJestem(idk);
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
            string zmienna = cenaprzyprawy.Text.ToString();
            int y = 0;
            if (zmienna == "niemożliwe")
            {
                y = -1;
            }
            else
            {
                y = Convert.ToInt32(zmienna);
            }
            idm = Modele.GdzieJestem(idk);
            kupowanie(idk, idm, "TO08", x, y);
        }

        private void buttonX4_Click(object sender, RoutedEventArgs e)//przyprawy +
        {
            int x;
            x = Convert.ToInt32(przyp.Text);
            x++;
            przyp.Text = x.ToString();
        }

        public void zassaj()
        {
            string idm2 = Modele.GdzieJestem(idk);
            wjazd dane2 = new wjazd(idm2);
            string kasa2 = Modele.getGoldS();

            string tkanIK2;
            string tkanIM2;
            string tkanCK2;
            string tkanCS2;

            string winoIK2;
            string winoIM2;
            string winoCK2;
            string winoCS2;

            string bronIK2;
            string bronIM2;
            string bronCK2;
            string bronCS2;

            string chlebIK2;
            string chlebIM2;
            string chlebCK2;
            string chlebCS2;

            string drewIK2;
            string drewIM2;
            string drewCK2;
            string drewCS2;

            string jablIK2;
            string jablIM2;
            string jablCK2;
            string jablCS2;

            string miesoIK2;
            string miesoIM2;
            string miesoCK2;
            string miesoCS2;

            string perlIK2;
            string perlIM2;
            string perlCK2;
            string perlCS2;

            string skrIK2;
            string skrIM2;
            string skrCK2;
            string skrCS2;

            string alchIK2;
            string alchIM2;
            string alchCK2;
            string alchCS2;

            string przypIK2;
            string przypIM2;
            string przypCK2;
            string przypCS2;

            tkanIK2 = Modele.IleTowaru(idk, "TO03");
            tkanIM2 = dane2.getIle("TO03");
            tkanCK2 = dane2.getCenaKup("TO03");
            if (tkanCK2 == "-1") { tkanCK2 = "niemożliwe"; }
            tkanCS2 = dane2.getCenaSp("TO03");

            winoIK2 = Modele.IleTowaru(idk, "TO09");
            winoIM2 = dane.getIle("TO09");
            winoCK2 = dane.getCenaKup("TO09");
            if (winoCK2 == "-1") { winoCK2 = "niemożliwe"; }
            winoCS2 = dane.getCenaSp("TO09");

            bronIK2 = Modele.IleTowaru(idk, "TO06");
            bronIM2 = dane2.getIle("TO06");
            bronCK2 = dane2.getCenaKup("TO06");
            if (bronCK2 == "-1") { bronCK2 = "niemożliwe"; }
            bronCS2 = dane2.getCenaSp("TO06");

            chlebIK2 = Modele.IleTowaru(idk, "TO05");
            chlebIM2 = dane2.getIle("TO05");
            chlebCK2 = dane2.getCenaKup("TO05");
            if (chlebCK2 == "-1") { chlebCK2 = "niemożliwe"; }
            chlebCS2 = dane2.getCenaSp("TO05");

            drewIK2 = Modele.IleTowaru(idk, "TO01");
            drewIM2 = dane2.getIle("TO01");
            drewCK2 = dane2.getCenaKup("TO01");
            if (drewCK2 == "-1") { drewCK2 = "niemożliwe"; }
            drewCS2 = dane2.getCenaSp("TO01");

            jablIK2 = Modele.IleTowaru(idk, "TO02");
            jablIM2 = dane2.getIle("TO02");
            jablCK2 = dane2.getCenaKup("TO02");
            if (jablCK2 == "-1") { jablCK2 = "niemożliwe"; }
            jablCS2 = dane2.getCenaSp("TO02");

            miesoIK2 = Modele.IleTowaru(idk, "TO04");
            miesoIM2 = dane2.getIle("TO04");
            miesoCK2 = dane2.getCenaKup("TO04");
            if (miesoCK2 == "-1") { miesoCK2 = "niemożliwe"; }
            miesoCS2 = dane2.getCenaSp("TO04");

            perlIK2 = Modele.IleTowaru(idk, "TO07");
            perlIM2 = dane2.getIle("TO07");
            perlCK2 = dane2.getCenaKup("TO07");
            if (perlCK2 == "-1") { perlCK2 = "niemożliwe"; }
            perlCS2 = dane2.getCenaSp("TO07");

            skrIK2 = Modele.IleTowaru(idk, "TO10");
            skrIM2 = dane2.getIle("TO10");
            skrCK2 = dane2.getCenaKup("TO10");
            if (skrCK2 == "-1") { skrCK2 = "niemożliwe"; }
            skrCS2 = dane2.getCenaSp("TO10");

            alchIK2 = Modele.IleTowaru(idk, "TO11");
            alchIM2 = dane2.getIle("TO11");
            alchCK2 = dane2.getCenaKup("TO11");
            if (alchCK2 == "-1") { alchCK2 = "niemożliwe"; }
            alchCS2 = dane2.getCenaSp("TO11");

            przypIK2 = Modele.IleTowaru(idk, "TO08");
            przypIM2 = dane2.getIle("TO08");
            przypCK2 = dane2.getCenaKup("TO08");
            if (przypCK2 == "-1") { przypCK2 = "niemożliwe"; }
            przypCS2 = dane2.getCenaSp("TO08");


            iltkaninatour.Text = tkanIM2;
            iltkaninawag.Text = tkanIK2;
            cenatkanina.Text = tkanCK2;
            sptkanina.Text = tkanCS2;
            ilwinowag.Text = winoIK2;
            cenawino.Text = winoCK2;
            spWino.Text = winoCS2;
            ilwinotour.Text = winoIM2;
            ilbronwag.Text = bronIK2;
            cenabron.Text = bronCK2;
            spbron.Text = bronCS2;
            ilbrontour.Text = bronIM2;
            ilchlebwag.Text = chlebIK2;
            cenachleb.Text = chlebCK2;
            spchleb.Text = chlebCS2;
            ilchlebtour.Text = chlebIM2;
            iltreewag.Text = drewIK2;
            cenatree.Text = drewCK2;
            spdrzewo.Text = drewCS2;
            iltreetour.Text = drewIM2;
            iljabwagt.Text = jablIK2;
            cenahleb.Text = jablCK2;
            spjab.Text = jablCS2;
            iljabtour.Text = jablIM2;
            ilmeatwag.Text = miesoIK2;
            cenameate.Text = miesoCK2;
            sptmieso.Text = miesoCS2;
            ilmeattour.Text = miesoIM2;
            ilperlawag.Text = perlIK2;
            cenaperla1.Text = perlCK2;
            spperla1.Text = perlCS2;
            ilperlatour1.Text = perlIM2;
            ilskorawag.Text = skrIK2;
            cenaskora.Text = skrCK2;
            spskora.Text = skrCS2;
            ilskoratour.Text = skrIM2;
            nowy1.Text = alchIK2;
            cenanafta.Text = alchCK2;
            spnafta.Text = alchCS2;
            ilnaftatour.Text = alchIM2;
            ilprzyprawywag.Text = przypIK2;
            cenaprzyprawy.Text = przypCK2;
            spprzyprawy.Text = przypCS2;
            ilprzyprawytour.Text = przypIM2;

            GOLD.Text = kasa2;
         

        }
    }

}
