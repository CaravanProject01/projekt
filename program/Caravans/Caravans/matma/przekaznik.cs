using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravans.model;

namespace Caravans.matma
{
    public class przekaznik
    {
        public static string DajCzasS()
        {
            int x = Modele.getTime();
            string y = x.ToString();
            return y;
        }

        public static int DajCzas()
        {
            int x = Modele.getTime();
            return x;
        }

        public static string DajKaseS()
        {
            int x = Modele.getGold();
            string y = x.ToString();
            return y;
        }

        public static int DajKase()
        {
            int x = Modele.getGold();
            return x;
        }

        public static string IleTowaru(string idk, string idt)
        {
            string wynik = "";
            foreach (TableArtInCaravan xyz in Modele.tableArtInCaravan)
            {
                string id1 = xyz.GetId();
                string id2 = xyz.GetIdArticle();
                if (id1 == idk && id2 == idt)
                {
                    int zmienna = xyz.GetNumber();
                    if (zmienna == 0)
                    {
                        wynik = "0";
                    }
                    else
                    {
                        wynik = zmienna.ToString();
                    }
                }
            }
            return wynik;
        }

        public static string lokalizuj(string idk)
        {
            string roboczy;
            string nazwa = "";
            int czas = 0;
            string idl = "";
            foreach (TableCaravan kar in Modele.tableCaravan)
            {
                roboczy = kar.GetId();
                if (roboczy == idk)
                {
                    idl = kar.GetIdLoc();
                    czas = kar.GetDuration();
                }
            }
            foreach (TableTown miasto in Modele.tableTown)
            {
                roboczy = miasto.GetIdLoc();
                if (roboczy == idl)
                {
                    nazwa = miasto.GetName();
                }
            }

            if (czas == 0)
            {
                return nazwa;
            }
            else
            {
                string wynik = "W drodze do " + nazwa + " pozostało " + czas + " tur";
                return wynik;

            }

        }
        public static int CzasPodrozy(string karID)
        {
            int wynik = 0;
            foreach (TableCaravan kar in Modele.tableCaravan)
            {
                string id = kar.GetId();
                if (id == karID)
                {
                    wynik = kar.GetDuration();
                }
            }

            return wynik;
        }

        public static string GdzieJestem(string idk)
        {
            string idm = "";
            string idl = "";
            string roboczy;
            foreach (TableCaravan kar in Modele.tableCaravan)
            {
                roboczy = kar.GetId();
                if (roboczy == idk)
                {
                    idl = kar.GetIdLoc();
                }
            }
            foreach (TableTown miasto in Modele.tableTown)
            {
                roboczy = miasto.GetIdLoc();
                if (roboczy == idl)
                {
                    idm = miasto.GetId();
                }
            }
            return idm;
        }

        public static int PoliczObciozenie(string id)
        {
            int wynik=0;
            foreach(TableArtInCaravan towar in Modele.tableArtInCaravan)
            {
                if (towar.GetId() == id)
                {
                    wynik += towar.GetNumber();
                }
            }
            return wynik;
        }

        public static int PoliczPojemnosc(string id)
        {
            int wynik=200;
            foreach (TableCaravan karawana in Modele.tableCaravan)
            {
                if (karawana.GetId() == id)
                {
                    wynik = 200 * karawana.GetWagons();
                }
            }
            return wynik;
        }
    }
}
