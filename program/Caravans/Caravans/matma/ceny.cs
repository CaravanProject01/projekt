using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravans.model;

namespace Caravans.matma
{
    public class wjazd
    {
        private string[] id = new string[11];
        private int[] cenaKup = new int[11];
        private int[] cenaSp = new int[11];
        private int[] ile = new int[11];

        public string getCenaKup(string idt)
        {
            for (int x = 0; x < 11; x++)
            {
                if (id[x] == idt) { return cenaKup[x].ToString(); }
            }
            return "";
        }
        public string getCenaSp(string idt)
        {
            for (int x = 0; x < 11; x++)
            {
                if (id[x] == idt) { return cenaSp[x].ToString(); }
            }
            return "";
        }
        public string getIle(string idt)
        {
            for (int x = 0; x < 11; x++)
            {
                if (id[x] == idt) { return ile[x].ToString(); }
            }
            return "";
        }

        public wjazd(string a)
        {
            int pop = 0;
            string idm = "a";
            List<towar> towary = new List<towar>();

            foreach (TableTown t in Modele.tableTown)
            {
                string b = t.GetId();
                if (b == a)
                {
                    pop = t.GetPopulation();
                    idm = b;
                }
            }

            string idt;
            int ilosc = 0;
            int cena = 0;
            int prodD = 0;
            int prodM = 0;
            int zapD = 0;
            int zapM = 0;
            foreach (TableArtInTown t in Modele.tableArtInTown)
            {
                string x = t.GetId();
                if (x == idm)
                {
                    idt = t.GetIdArticle();
                    ilosc = t.GetNumber();
                    prodM = t.GetProduction();
                    zapM = t.GetRequisition();

                    foreach (TableArticle z in Modele.tableArticle)
                    {
                        x = z.GetId();
                        if (x == idt)
                        {
                            cena = z.GetPrice();
                            prodD = z.GetProduction();
                            zapD = z.GetRequisition();
                        }
                    }
                    towar tow = new towar(idt, ilosc, cena, prodD, prodM, zapD, zapM);
                    towary.Add(tow);
                }

            }

            int licznik = 0;

            foreach (towar tow in towary)
            {
                int pp = pop / 100;
                if (pp == 0) { pp = 1; }
                tow.policzCena(pp);
                id[licznik] = tow.dajId();
                cenaKup[licznik] = tow.dajCenaKup();
                cenaSp[licznik] = tow.dajCenaSprzed();
                ile[licznik] = tow.dajIlosc();
                licznik++;
            }
        }
    }

    public class towar
    {
        private String id;
        private int ilosc;      //ilość towaru w mieście
        private int cenaDef;        //podstawowa cena towaru
        private int produkcjaDef;       //podstawowa produkcja towaru
        private int produkcjaMod;       //miejski modyfikator produkcji towaru
        private int zapotrzebowanieDef;     //podstawowe zapotrzebowanie na towar
        private int zapotrzebowanieMod;     //miejski modyfikator zapotrzebowania na towar

        private int cenaKup;       //aktualna cena towaru
        private int cenaSprzed;        //aktualne zapotrzebowanie 

        public towar(String x, int a, int b, int c, int d, int e, int f)
        {
            id = x;
            ilosc = a;
            cenaDef = b;
            produkcjaDef = c;
            produkcjaMod = d;
            zapotrzebowanieDef = e;
            zapotrzebowanieMod = f;
            cenaKup = 0;
            cenaSprzed = 0;
        }

        public String dajId() { return id; }
        public int dajIlosc() { return ilosc; }
        public int dajProdukcje() { return produkcjaMod; }
        public int dajZapotrzebowanie() { return zapotrzebowanieMod; }
        public int dajCenaKup() { return cenaKup; }
        public int dajCenaSprzed() { return cenaSprzed; }

        public int policzZapotrzebowanie(int pop)
        {
            double x;
            if (zapotrzebowanieDef == 0)
            {
                if (zapotrzebowanieMod == 0)
                {
                    x = 0;
                }
                else
                {
                    x = zapotrzebowanieMod / 10;
                }
            }
            else
            {
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
            }
            int zap = Convert.ToInt32(x);
            return zap * pop;
        }

        public int policzProdukcje(int pop)
        {
            double x;
            if (produkcjaDef == 0)
            {
                if (produkcjaMod == 0)
                {
                    x = 0;
                }
                else
                {
                    x = produkcjaMod / 10;
                }
            }
            else
            {
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
            }
            int prod = Convert.ToInt32(x);
            return prod * pop;
        }

        public void policzCena(int pop)
        {
            double roznica;
            int zapotrzebowanie = policzZapotrzebowanie(pop);

            if (zapotrzebowanie == 0)
            {
                roznica = 1;
            }
            else
            {
                roznica = ilosc / zapotrzebowanie;
            }



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
                        double odw = 1 / roznica;
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
        }

        public int zmianaIlosci(int pop)
        {
            int zap = policzZapotrzebowanie(pop);
            int prod = policzProdukcje(pop);
            int wynik = 0;
            int x = 0;

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

        public void wyprowadzDane(string idm)
        {
            foreach (TableArtInTown tow in Modele.tableArtInTown)
            {
                string id1 = tow.GetId();
                string id2 = tow.GetIdArticle();
                if (idm == id1 && id == id2)
                {
                    tow.SetNumber(dajIlosc());
                    tow.SetProduction(dajProdukcje());
                    tow.SetRequisition(dajZapotrzebowanie());
                }
            }
        }
    }
}
