using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caravans.model
{
    public class Modele
    {
        public static List<TableArticle> tableArticle = new List<TableArticle>();
        public static List<TableArtInCaravan> tableArtInCaravan = new List<TableArtInCaravan>();
        public static List<TableArtInTown> tableArtInTown = new List<TableArtInTown>();
        public static List<TableCaravan> tableCaravan = new List<TableCaravan>();
        public static List<TableLoc> tableLoc = new List<TableLoc>();
        public static List<TableRoad> tableRoad = new List<TableRoad>();
        public static List<TableState> tableState = new List<TableState>();
        public static List<TableTown> tableTown = new List<TableTown>();
        public static List<TableTownState> tableTownState = new List<TableTownState>();

        private static int gold;
        public static string getGoldS() { return gold.ToString(); }
        public static int getGold() { return gold; }
        public static int time;
        public static string getTimeS() { return time.ToString(); }
        public static int getTime() { return time; }



    }
}
