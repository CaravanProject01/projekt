using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravans.model;

namespace Caravans.matma
{
    class podroz
    {
        public Boolean czyMozna(string id)
        {
            int wozy=0;
            int ochrona=0;
            int pomoc=0;
            int jest;
            int trzeba;

            foreach(TableCaravan kar in Modele.tableCaravan)
            {
                if (kar.GetId() == id)
                {
                    wozy = kar.GetWagons();
                    pomoc = kar.GetMinions();
                    ochrona = kar.GetGuard();
                }
            }

            jest = ochrona + pomoc + 1;
            trzeba = wozy * 2;
            if (jest >= trzeba)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //wklej tu funckje podróży i ogarnij je do finalnej wersji
    }
}
