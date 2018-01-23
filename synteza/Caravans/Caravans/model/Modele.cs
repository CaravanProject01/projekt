using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caravans.model
{
    public class Modele
    {
        static List<TableArticle> tableArticle = new List<TableArticle>();
        static List<TableArtInCaravan> tableArtInCaravan = new List<TableArtInCaravan>();
        static List<TableArtInTown> tableArtInTown = new List<TableArtInTown>();
        static List<TableCaravan> tableCaravan = new List<TableCaravan>();
        static List<TableLoc> tableLoc = new List<TableLoc>();
        static List<TableRoad> tableRoad = new List<TableRoad>();
        static List<TableState> tableState = new List<TableState>();
        static List<TableTown> tableTown = new List<TableTown>();
        static List<TableTownState> tableTownState = new List<TableTownState>();

        private static int gold;
        public static string getGoldS() { return gold.ToString(); }
        public static int getGold() { return gold; }
        public static int time;
        public static string getTimeS() { return time.ToString(); }
        public static int getTime() { return time; }
    }
}
