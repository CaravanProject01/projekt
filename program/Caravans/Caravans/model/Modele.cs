using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caravans.model
{
    public class Modele
    {

        SQLreq SQLTest = new SQLreq();

        public static List<TableLoc> tableLoc = new List<TableLoc>();
        public static List<TableArticle> tableArticle = new List<TableArticle>();
        public static List<TableState> tableState = new List<TableState>();
        public static List<TableRoad> tableRoad = new List<TableRoad>();
        public static List<TableTown> tableTown = new List<TableTown>();
        public static List<TableTownState> tableTownState = new List<TableTownState>();
        public static List<TableCaravan> tableCaravan = new List<TableCaravan>();
        public static List<TableArtInCaravan> tableArtInCaravan = new List<TableArtInCaravan>();
        public static List<TableArtInTown> tableArtInTown = new List<TableArtInTown>();


        private static int gold;
        public static int time;

        internal Modele()
        {
            gold = 1000;
            time = 0;

            ReadListLocation();
            ReadListArticle();
            ReadListState();
            ReadListRoad();
            ReadListTown();

            ReadListCaravan();
            ReadListTownState();
            ReadListArtInCaravan();
            ReadListArtInTown();
        }


        public static int getGold()
        {
            return gold;
        }
        public static void setGold(int newgold)
        {
            gold = newgold;
        }
        public static int getTime()
        {
            return time;
        }

        public static String Nazwalokacji()
        {
            string nazwa ="";
            foreach (TableCaravan x in tableCaravan)
            {
                foreach (TableTown y in tableTown)
                {
                    if(x.GetIdLoc() == y.GetIdLoc())
                    {
                        nazwa = y.GetName();
                    }
                }
            }
            return nazwa;
        }

        public static void dodajKarawane(string a, string b)
        {
            TableCaravan nowa = new TableCaravan(a, b, 1, 0, 0, 1);
            tableCaravan.Add(nowa);
        }

        public static void KoniecStanu(string ids, string idm)
        {
            foreach (TableTownState stan in tableTownState)
            {
                string ids2 = stan.GetIdState();
                string idm2 = stan.GetId();
                if (ids == ids2 && idm == idm2)
                {
                    tableTownState.Remove(stan);
                    break;
                }
            }
        }

        public static Boolean NowyStan(string ids, string idm, int czas)
        {
            Boolean flaga = false;
            string ids2;
            string idm2;
            foreach (TableTownState stan in tableTownState)
            {
                idm2 = stan.GetId();
                ids2 = stan.GetIdState();
                if(idm2==idm && ids2 == ids)
                {
                    flaga = true;
                    stan.SetDuration(czas);
                }
            }
            if (flaga == false)
            {
                TableTownState nowy = new TableTownState(idm, ids, czas);
                tableTownState.Add(nowy);
            }
            return flaga;
        }       
       

        internal void ReadListLocation()
        {
            SQLTest.ReadLocsToMod(tableLoc);
        }
        internal void ReadListArticle()
        {
            SQLTest.ReadArticleToMod(tableArticle);
        }
        internal void ReadListState()
        {
            SQLTest.ReadStateToMod(tableState);
        }
        internal void ReadListRoad()
        {
            SQLTest.ReadRoadsToMod(tableRoad);
        }
        internal void ReadListTown()
        {
            SQLTest.ReadTownToMod(tableTown);
        }
        internal void ReadListTownState()
        {
            SQLTest.ReadTownStateToMod(tableTownState);
        }
        internal void ReadListCaravan()
        {
            SQLTest.ReadCaravanToMod(tableCaravan);
        }
        internal void ReadListArtInCaravan()
        {
            SQLTest.ReadArtInCaravanToMod(tableArtInCaravan);
        }
        internal void ReadListArtInTown()
        {
            SQLTest.ReadArtInTownToMod(tableArtInTown);
        }


        internal void PrintListLocation()
        {
            foreach (var i in tableLoc)
            {
                Console.Write(i.GetId() + "\n" + i.GetName() + "\n" + "\n\n");
            }
            Console.WriteLine();
        }

        internal void PrintListCaravan()
        {
            foreach (var i in tableCaravan)
            {
                Console.Write(i.GetId() + "\n" + i.GetIdLoc() + "\n" + i.GetWagons() + "\n" + i.GetGuard() + "\n" + i.GetDuration() + "\n" + i.GetMinions() + "\n" + "\n\n");
            }
            Console.WriteLine();
        }
    }
}
