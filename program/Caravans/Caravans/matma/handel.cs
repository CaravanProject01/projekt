using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravans.model;

namespace Caravans.matma
{
    class handel
    {
        public static void kup(string IDkarawana, string IDmiasto, string IDtowar, int ile, int cena)
        {
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
            }
        }

        public static void sprzedaj(string IDkarawana, string IDmiasto, string IDtowar, int ile, int cena)
        {
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
            }
        }
    }
}
