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
        //kamil, popraw te funkcje
        //poza usunięcięm błędów spraw by zwracały stringa-gównowiadomość jeśli się uda, wyjaśnienie czemu się nie udało jak nie wydzie
        //w stylu "masz za mało złota by kupić ten towar", "ten towar nie jest dostępny w tym mieście", "za mała pojemność karawany" itd itp


        public static string kup(string IDkarawana, string IDmiasto, string IDtowar, int ile, int cena)
        {
            if (ile > 0 && cena > 0)
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
            return "done";
        }

        public static string sprzedaj(string IDkarawana, string IDmiasto, string IDtowar, int ile, int cena)
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
            return "done";
        }
    }
}
