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


        public static string getGoldS()
        {
            return gold.ToString();
        }
        public static int getGold()
        {
            return gold;
        }
        public static string getTimeS()
        {
            return time.ToString();
        }
        public static int getTime()
        {
            return time;
        }

        public static String Nazwalokacji()
        {
            string nazwa = "";
            foreach (TableCaravan x in tableCaravan)
            {
                foreach (TableTown y in tableTown)
                {
                    if (x.GetIdLoc() == y.GetIdLoc())
                    {
                        nazwa = y.GetName();
                    }
                }
            }
            return nazwa;
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
                }
            }
        }

        public static void NowyStan(string ids, string idm, int czas)
        {
            TableTownState stan = new TableTownState(idm, ids, czas);
            tableTownState.Add(stan);
        }

        public static string IleTowaru(string idk, string idt)
        {
            string wynik = "";
            foreach (TableArtInCaravan xyz in tableArtInCaravan)
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

        //Druk modelu

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

        internal void PrintListState()
        {
            foreach (var i in tableState)
            {
                Console.Write(i.GetId() + "\n" + i.GetName() + "\n" + i.GetDescription() + "\n\n");
            }
            Console.WriteLine();
        }

        internal void PrintListRoad()
        {
            foreach (var i in tableRoad)
            {
                Console.Write(i.GetId() + "\n" + i.GetIdLoc_1() + "\n" + i.GetIdLoc_2() + "\n" + i.GetLength() + "\n" + i.GetQuality() + "\n\n");
            }
            Console.WriteLine();
        }

        internal void PrintListArticle()
        {
            foreach (var i in tableArticle)
            {
                Console.Write(i.GetId() + "\n" + i.GetName() + "\n" + i.GetPrice() + "\n" + i.GetProduction() + "\n" + i.GetRequisition() + "\n\n");
            }
            Console.WriteLine();
        }

        internal void PrintListTown()
        {
            foreach (var i in tableTown)
            {
                Console.Write(i.GetId() + "\n" + i.GetName() + "\n" + i.GetPopulation() + "\n" + i.GetIdLoc() + "\n" + i.GetMilitary() + "\n" + i.GetProsperity() + "\n" + i.GetFood() + "\n\n");
            }
            Console.WriteLine();
        }

        internal void PrintListArtInTown()
        {
            foreach (var i in tableArtInTown)
            {
                Console.Write(i.GetId() + "\n" + i.GetIdArticle() + "\n" + i.GetNumber() + "\n" + i.GetRequisition() + "\n" + i.GetProduction() + "\n\n");
            }
            Console.WriteLine();
        }

        internal void PrintListArtInCaravan()
        {
            foreach (var i in tableArtInCaravan)
            {
                Console.Write(i.GetId() + "\n" + i.GetIdArticle() + "\n" + i.GetNumber() + "\n\n");
            }
            Console.WriteLine();
        }

        internal void PrintListTownState()
        {
            foreach (var i in tableTownState)
            {
                Console.Write(i.GetId() + "\n" + i.GetIdState() + "\n" + i.GetDuration() + "\n\n");
            }
            Console.WriteLine();
        }
    }
}