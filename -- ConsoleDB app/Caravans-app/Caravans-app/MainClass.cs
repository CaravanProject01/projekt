using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravans.model
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Modele Test = new Modele();

            //Test.PrintListLocation();
            Test.PrintListCaravan();
            //Test.PrintListState();
            //Test.PrintListRoad();
            //Test.PrintListArticle();
            //Test.PrintListTown();
            //Test.PrintListArtInTown();
            //Test.PrintListArtInCaravan();
            //Test.PrintListTownState();


            /*
            foreach (var i in Article)
            {
                if (i.GetName() == "Wino")
                {
                    i.SetPrice("5");
                    i.SetRequisition("5");
                    i.SetProduction("5");

                    i.UpdateDB();
                }
            }
            Console.WriteLine();
            */

            Console.Read();
        }
    }
}
