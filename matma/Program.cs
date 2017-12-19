using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    public class miasto
    {
        private int populacja;
        private int gotowosc;
        private int zywnosc;
        private int dobrobyt;
        List<towar> towary = new List<towar>();
        List<stan> stany = new List<stan>();

        public miasto (int a, int b, int c, int d)
        {
            populacja = a;
            gotowosc = b;
            zywnosc = c;
            dobrobyt = d;
        }

        public void wjazd()
        {
            //przy wjeździe do miasta wylicza ceny towarów
            foreach (towar x in towary)
            {
                int pop = populacja / 1000;
                if (pop == 0) { pop = 1; }
                x.policzCena(pop);
            }

        }

        public void dzien()
        {
            foreach(stan x in stany)
            {
                x.kolejnyDzien();
                int a = x.dajTrwanie();
                String id = x.dajId();
                if (a == 0){   
                    //stan się skończył-ewentualne zakończenie działania, usunięcie stanu                 
                    switch (id){
                        case "ST01":
                            // cos
                            break;
                        case "ST02":
                            // cos
                            break;
                        default:
                            break;
                    }
                    stany.Remove(x);
                }else{
                    //ewentualne działania podczas stanu
                    switch (id){
                        case "ST01":
                            // cos
                            break;
                        case "ST02":
                            // cos
                            break;
                        default:
                            break;
                    }
                }
            }

            //losowanie ewentualnych nowych stanów
        }

        public void tydzien()
        {
            foreach (towar x in towary)
            {
                int pop = populacja / 1000;
                if (pop == 0) { pop = 1; }
                int zmiana = x.zmianaIlosci(pop);
                dobrobyt = +zmiana;                                        
            }
            zmianaPopulacji();           
        }

        public void miesiac()
        {
            //na zakończenie miesiąca decyduje o ważnych zmianach w mieście, wojnach, intensyfikacji nowych dziedzin gospodarki itp. itd.
        }

        public void zmianaPopulacji()
        {
            int zpop;
            int zyw = zywnosc;
            if (zyw < 0){
                zyw *= -1;
                zyw /= 4;
                zpop = populacja*zyw;
                zpop /= 200;
                populacja -= zpop;
            }
            if (zyw > 0 && zyw <= 100){
                zyw /= 10;
                zpop = populacja * zyw;
                zpop /= 500;
                populacja += zpop;
            }
            if (zyw > 100 && zyw <= 1000)
            {
                zyw -= 100;
                zyw /= 40;
                zyw += 10;
                zpop = populacja * zyw;
                zpop /= 500;
                populacja += zpop;
            }
            if (zyw > 1000)
            {
                zpop = populacja * 33;
                zpop /= 500;
                populacja += zpop;
            }
            Console.WriteLine("populacja wynosi " + populacja);
        }       
            
        

    }

    public class stan
    {
        private String id;
        private int trwanie;

        public stan (String a, int b)
        {
            id = a;
            trwanie = b;
        }

        public void kolejnyDzien() { trwanie--; }
        public String dajId() { return id; }
        public int dajTrwanie() { return trwanie; }

    }

    public class towar
    {
        private int ilosc;      //ilość towaru w mieście
        private int cenaDef;        //podstawowa cena towaru
        private int produkcjaDef;       //podstawowa produkcja towaru
        private int produkcjaMod;       //miejski modyfikator produkcji towaru
        private int zapotrzebowanieDef;     //podstawowe zapotrzebowanie na towar
        private int zapotrzebowanieMod;     //miejski modyfikator zapotrzebowania na towar

        private int cenaKup;       //aktualna cena towaru
        private int cenaSprzed;        //aktualne zapotrzebowanie 

        //konstruktor
        public towar(int a, int b, int c, int d, int e, int f)
        {
            ilosc = a;
            cenaDef = b;
            produkcjaDef = c;
            produkcjaMod = d;
            zapotrzebowanieDef = e;
            zapotrzebowanieMod = f;
            cenaKup = 0;
            cenaSprzed = 0;
        }

        //funkcje pomocnicze, kontrolne
        public int dajIlosc() { return ilosc; }
        public int dajCenaDef() { return cenaDef; }
        public int dajProdukcjaDef() { return produkcjaDef; }
        public int dajProdukcjaMod() { return produkcjaMod; }
        public int dajzapotrzebowanieDef() { return zapotrzebowanieDef; }
        public int dajzapotrzebowanieMod() { return zapotrzebowanieMod; }
        public int dajCenaKup() { return cenaKup; }
        public int dajCenaSprzed() { return cenaSprzed; }



        public int policzZapotrzebowanie(int pop)
        {
            double x;
            if (zapotrzebowanieMod == 0)
            {
                x = zapotrzebowanieDef;
            }
            else
            {
                x = zapotrzebowanieMod + 100;
                x = x / 100;
                x = x * zapotrzebowanieDef;
            }
            int zap = Convert.ToInt32(x);
            return zap*pop;
        }

        public int policzProdukcje(int pop)
        {
            double x;
            if (produkcjaMod == 0)
            {
                x = produkcjaDef;
            }
            else
            {
                x = produkcjaMod + 100;
                x = x / 100;
                x = x * produkcjaDef;
            }
            int prod = Convert.ToInt32(x);
            return prod * pop;
        }


        public void policzCena(int pop)
        {
            double roznica;
            int zapotrzebowanie = policzZapotrzebowanie(pop);
            //Console.WriteLine(zapotrzebowanie);
            roznica = ilosc/zapotrzebowanie;
            //Console.WriteLine(roznica);

            //dla testów
            //roznica = 10;        

            if (roznica < 0.18)
            {
                cenaKup = -1;
                cenaSprzed = 8 * cenaDef;
            }
            else
            {
                if (roznica < 0.25)
                {
                    cenaKup = -1;
                    cenaSprzed = 5 * cenaDef;
                }
                else
                {
                    if (roznica < 0.5)
                    {
                        double odw = 1/roznica;
                        double x;
                        double y;
                        x = (int)cenaDef * odw;
                        y = x + x * 0.2;
                        cenaKup = Convert.ToInt32(y);
                        x = x - x * 0.1;
                        cenaSprzed = Convert.ToInt32(x);
                    }
                    else
                    {
                        if (roznica < 1)
                        {
                            double odw = 1 / roznica;
                            double x;
                            double y;
                            x = (int)cenaDef * odw;
                            y = x + x * 0.1;
                            cenaKup = Convert.ToInt32(y);
                            x = x - x * 0.1;
                            cenaSprzed = Convert.ToInt32(x);
                        }
                        else
                        {
                            if (roznica <= 2)
                            {
                                double x;
                                double y;
                                x = cenaDef + cenaDef * 0.05;
                                cenaKup = Convert.ToInt32(x);
                                y = cenaDef - cenaDef * 0.05;
                                cenaSprzed = Convert.ToInt32(y);
                            }
                            else
                            {
                                if (roznica < 10)
                                {
                                    double x = roznica;
                                    x = 1 / x;
                                    x = x * 2;
                                    double y = x;
                                    x = cenaDef * x;
                                    y = cenaDef * y;
                                    x = x + x * 0.05;
                                    y = y - y * 0.05;
                                    cenaKup = Convert.ToInt32(x);
                                    cenaSprzed = Convert.ToInt32(y);
                                }
                                else
                                {
                                    double x = cenaDef * 0.2;
                                    double y = cenaDef * 0.17;
                                    cenaKup = Convert.ToInt32(x);
                                    cenaSprzed = Convert.ToInt32(y);
                                }
                            }
                        }
                    }
                }
            }
            //Console.WriteLine("Kupuję za " + cenaKup + ", sprzedaję za " + cenaSprzed);
        }


        public int zmianaIlosci(int pop){
            int zap = policzZapotrzebowanie(pop);
            int prod = policzProdukcje(pop);
            int wynik=0;
            int x=0;

            Console.WriteLine("Początek-towaru jest " + ilosc);

            ilosc -= zap;
            if (ilosc < 0)
            {
                wynik--;
                x = ilosc * -1;
                ilosc = 0;
            }
            
            Console.WriteLine("Środek-towaru jest " + ilosc + ", zabrakło " + x);

            if (x == 0)
            {
                ilosc += prod;
            }
            else
            {
                ilosc += prod;
                x /= 2;
                ilosc -= x;
                if (ilosc < 0)
                {
                    ilosc = 0;
                    wynik--;
                }
            }

            Console.WriteLine("Koniec-towaru jest " + ilosc);

            double roznica;
            roznica = ilosc / zap;

            if (roznica >= 5) { wynik++; }

            Console.WriteLine("Koniec-modyfikator wynosi " + wynik);

            return wynik;
        }
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            //ilosc, cenaDef, produkcjaDef/Mod, zapotrzebowanieDef/Mod
            //towar chleb = new towar(1000, 100, 100, 900, 300, 0);

            //chleb.policzCena(1);     
            //chleb.zmianaIlosci(1);     

            //miasto m1 = new miasto(10000, 0, 700, 0);
            //m1.zmianaPopulacji();

            Console.ReadKey();

        }
    }
}
