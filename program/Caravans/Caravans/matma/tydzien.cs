using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravans.model;

namespace Caravans.matma
{
    public class tydzien
    {
        public void nowyTydzien()
        {
            foreach (TableTown wiocha in Modele.tableTown)
            {
                string idm = wiocha.GetId();
                int popu = wiocha.GetPopulation();
                int got = wiocha.GetMilitary();
                int dobr = wiocha.GetProsperity();
                int zyw = wiocha.GetFood();
                miasto wies = new miasto(idm, popu, got, zyw, dobr);
                wies.wypelnij(idm);

                wies.policzTowary();
                wies.zmianaPopulacji();

                wiocha.SetPopulation(wies.getPopulacje());
                wiocha.SetMilitary(wies.getGotowosc());
                wiocha.SetProsperity(wies.getDobrobyt());
                wiocha.SetFood(wies.getZywnosc());

                wies.dajDane();

            }
        }


    }

    public class miasto
    {
        private string id;
        private int populacja;
        private int gotowosc;    //100 to standard, powyzej 300 wypowiada wojnę
        private int zywnosc;    //-100 to kompletny brak, 0 standard, 100-2x tyle, 200-3x tyle...
        private int dobrobyt;   //uj wie
        List<towar> towary = new List<towar>();

        public miasto(string s, int a, int b, int c, int d)
        {
            id = s;
            populacja = a;
            gotowosc = b;
            zywnosc = c;
            dobrobyt = d;
        }

        public int getPopulacje() { return populacja; }
        public int getZywnosc() { return zywnosc; }
        public int getGotowosc() { return gotowosc; }
        public int getDobrobyt() { return dobrobyt; }

        public void wypelnij(string id)
        {
            foreach (TableArtInTown t in Modele.tableArtInTown)
            {
                string x = t.GetId();
                if (x == id)
                {
                    string idt = t.GetIdArticle();
                    int ilosc = t.GetNumber();
                    int prodM = t.GetProduction();
                    int zapM = t.GetRequisition();

                    foreach (TableArticle z in Modele.tableArticle)
                    {
                        x = z.GetId();
                        if (x == idt)
                        {
                            int cena = z.GetPrice();
                            int prodD = z.GetProduction();
                            int zapD = z.GetRequisition();
                            towar tow = new towar(idt, ilosc, cena, prodD, prodM, zapD, zapM);
                            towary.Add(tow);
                        }
                    }


                }

            }
        }

        public void zmianaPopulacji()
        {
            int zpop;
            int zyw = zywnosc;
            if (zyw < 0)
            {
                zyw *= -1;
                zyw /= 4;
                zpop = populacja * zyw;
                zpop /= 200;
                populacja -= zpop;
            }
            if (zyw > 0 && zyw <= 100)
            {
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
        }

        public void policzTowary()
        {
            foreach (towar x in towary)
            {
                int pop = populacja / 100;
                if (pop == 0) { pop = 1; }
                int zmiana = x.zmianaIlosci(pop);
                dobrobyt = +zmiana;
            }
        }

        public void dajDane()
        {
            foreach (towar x in towary)
            {
                x.wyprowadzDane(id);
            }
        }
    }


}