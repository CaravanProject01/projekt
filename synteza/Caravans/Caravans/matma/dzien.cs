﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravans.model;

namespace Caravans.matma
{
    class dzien
    {
        public void nowyDzien()
        {
            string ids;
            string idm;
            string idm2;
            string idt;
            string[] ruiny = new string[12];
            int ileRuin=0;
            int czas;
            int licznik;
            foreach (TableTownState stan in Modele.tableTownState)
            {
                ids = stan.GetIdState();
                idm = stan.GetId();
                czas = stan.GetDuration();
                czas--;
                if (czas == 0)
                {
                    switch (ids)
                    {
                        case "ST01":  //zaraza
                            foreach (TableArtInTown tow in Modele.tableArtInTown)
                            {
                                idt = tow.GetIdArticle();
                                idm2 = tow.GetId();
                                if (idt == "TO11" && idm==idm2)   //medykamenty
                                {
                                    licznik = tow.GetRequisition();
                                    licznik -= 500;
                                    tow.SetRequisition(licznik);
                                }
                            }
                            break;
                        case "ST02": //susza
                            foreach (TableArtInTown tow in Modele.tableArtInTown)
                            {
                                idt = tow.GetIdArticle();
                                idm2 = tow.GetId();
                                if (idt == "TO02" && idm == idm2)   //jabłka
                                {
                                    licznik = tow.GetRequisition();
                                    licznik += 50;
                                    tow.SetRequisition(licznik);
                                }
                                if (idt == "TO05" && idm == idm2)   //chleb
                                {
                                    licznik = tow.GetRequisition();
                                    licznik += 50;
                                    tow.SetRequisition(licznik);
                                }
                            }
                            break;
                        case "ST03": //nieurodzaj
                            foreach (TableArtInTown tow in Modele.tableArtInTown)
                            {
                                idt = tow.GetIdArticle();
                                idm2 = tow.GetId();
                                if (idt == "TO02" && idm == idm2)   //jabłka
                                {
                                    licznik = tow.GetRequisition();
                                    licznik += 20;
                                    tow.SetRequisition(licznik);
                                }
                                if (idt == "TO05" && idm == idm2)   //chleb
                                {
                                    licznik = tow.GetRequisition();
                                    licznik += 20;
                                    tow.SetRequisition(licznik);
                                }
                            }
                            break;
                        case "ST04": //obf. plony
                            foreach (TableArtInTown tow in Modele.tableArtInTown)
                            {
                                idt = tow.GetIdArticle();
                                idm2 = tow.GetId();
                                if (idt == "TO02" && idm == idm2)   //jabłka
                                {
                                    licznik = tow.GetRequisition();
                                    licznik -= 20;
                                    tow.SetRequisition(licznik);
                                }
                                if (idt == "TO05" && idm == idm2)   //chleb
                                {
                                    licznik = tow.GetRequisition();
                                    licznik -= 20;
                                    tow.SetRequisition(licznik);
                                }
                            }
                            break;
                        case "ST05": //w. obf. plony
                            foreach (TableArtInTown tow in Modele.tableArtInTown)
                            {
                                idt = tow.GetIdArticle();
                                idm2 = tow.GetId();
                                if (idt == "TO02" && idm == idm2)   //jabłka
                                {
                                    licznik = tow.GetRequisition();
                                    licznik -= 50;
                                    tow.SetRequisition(licznik);
                                }
                                if (idt == "TO05" && idm == idm2)   //chleb
                                {
                                    licznik = tow.GetRequisition();
                                    licznik -= 50;
                                    tow.SetRequisition(licznik);
                                }
                            }
                            break;
                        case "ST06": //pożar  
                            ruiny[ileRuin] = idm;
                            ileRuin++;
                            break;
                        case "ST07": //odbudowa
                            foreach (TableArtInTown tow in Modele.tableArtInTown)
                            {
                                idt = tow.GetIdArticle();
                                idm2 = tow.GetId();
                                if (idt == "TO01" && idm == idm2)   //materiały budowlane
                                {
                                    licznik = tow.GetRequisition();
                                    licznik -= 50;
                                    tow.SetRequisition(licznik);
                                }

                            }
                            break;
                        case "ST08": //war prep
                            foreach (TableArtInTown tow in Modele.tableArtInTown)
                            {
                                idt = tow.GetIdArticle();
                                idm2 = tow.GetId();
                                if (idt == "TO06" && idm == idm2)   //bron
                                {
                                    licznik = tow.GetRequisition();
                                    licznik -= 100;
                                    tow.SetRequisition(licznik);
                                }                            
                            }
                            break;
                        case "ST09": //war
                            foreach (TableArtInTown tow in Modele.tableArtInTown)
                            {
                                idt = tow.GetIdArticle();
                                idm2 = tow.GetId();
                                if (idt == "TO02" && idm == idm2)   //jabłka
                                {
                                    licznik = tow.GetRequisition();
                                    licznik -= 200;
                                    tow.SetRequisition(licznik);
                                }
                                if (idt == "TO05" && idm == idm2)   //chleb
                                {
                                    licznik = tow.GetRequisition();
                                    licznik -= 200;
                                    tow.SetRequisition(licznik);
                                }
                                if (idt == "TO04" && idm == idm2)   //mieso
                                {
                                    licznik = tow.GetRequisition();
                                    licznik -= 200;
                                    tow.SetRequisition(licznik);
                                }
                                if (idt == "TO01" && idm == idm2)   //surowce
                                {
                                    licznik = tow.GetRequisition();
                                    licznik -= 25;
                                    tow.SetRequisition(licznik);
                                }
                                if (idt == "TO11" && idm == idm2)   //medykamenty
                                {
                                    licznik = tow.GetRequisition();
                                    licznik -= 50;
                                    tow.SetRequisition(licznik);
                                }                               
                            }
                            break;
                        case "ST010": //oblężenie
                            ruiny[ileRuin] = idm;
                            ileRuin++;
                            break;
                        default:
                            break;
                    }
                    Modele.KoniecStanu(ids, idm);
                }
                else
                {
                    //ewentualne działania podczas stanu
                    switch (ids)
                    {
                        case "ST01":  //zaraza
                            foreach(TableTown miasto in Modele.tableTown)
                            {
                                double populacja = miasto.GetPopulation();
                                populacja = populacja *= 0.92;
                                int pop = (int)populacja;
                                miasto.SetPopulation(pop);
                            }
                            break;
                        case "ST02": //susza
                            break;
                        case "ST03": //nieurodzaj
                            break;
                        case "ST04": //obf. plony
                            break;
                        case "ST05": //w. obf. plony
                            break;
                        case "ST06": //pożar  
                            foreach (TableArtInTown tow in Modele.tableArtInTown)
                            {
                                idm2 = tow.GetId();
                                if (idm == idm2)   //dowolny towar w mieście (oberwą wszystkie po kolei)
                                {
                                    licznik = tow.GetProduction();
                                    licznik -= 5;
                                    tow.SetProduction(licznik);

                                    licznik = tow.GetNumber();
                                    licznik -= 10;
                                    tow.SetNumber(licznik);
                                }
                            }
                            break;
                        case "ST07": //odbudowa
                            foreach (TableArtInTown tow in Modele.tableArtInTown)
                            {
                                idm2 = tow.GetId();
                                if (idm == idm2)   //dowolny towar w mieście (oberwą wszystkie po kolei)
                                {
                                    licznik = tow.GetProduction();
                                    licznik += 5;
                                    tow.SetProduction(licznik);
                                }
                            }
                            break;
                        case "ST08": //war prep
                            foreach (TableTown miasto in Modele.tableTown)
                            {
                                int gotowosc = miasto.GetMilitary();
                                gotowosc += 5;
                                miasto.SetMilitary(gotowosc);
                            }
                            break;
                        case "ST09": //war
                            break;
                        case "ST010": //oblężenie
                            foreach (TableArtInTown tow in Modele.tableArtInTown)
                            {
                                idm2 = tow.GetId();
                                if (idm == idm2)   //dowolny towar w mieście (oberwą wszystkie po kolei)
                                {
                                    licznik = tow.GetProduction();
                                    licznik -= 5;
                                    tow.SetProduction(licznik);

                                    licznik = tow.GetNumber();
                                    licznik -= 10;
                                    tow.SetNumber(licznik);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            //losowanie ewentualnych nowych stanów
            foreach (TableTown miasto in Modele.tableTown)
            {
                idm = miasto.GetId();
                int gotowosc = miasto.GetMilitary();
                if (gotowosc < 50)
                {
                    Modele.NowyStan("ST08", idm, 12);
                    foreach (TableArtInTown tow in Modele.tableArtInTown)
                    {
                        idt = tow.GetIdArticle();
                        idm2 = tow.GetId();
                        if (idt == "TO06" && idm == idm2)   //bron
                        {
                            licznik = tow.GetRequisition();
                            licznik += 100;
                            tow.SetRequisition(licznik);
                        }
                    }
                }
                if (gotowosc > 300)
                {
                    Modele.NowyStan("ST09", idm, 20);
                    foreach (TableArtInTown tow in Modele.tableArtInTown)
                    {
                        idt = tow.GetIdArticle();
                        idm2 = tow.GetId();
                        if (idt == "TO02" && idm == idm2)   //jabłka
                        {
                            licznik = tow.GetRequisition();
                            licznik += 200;
                            tow.SetRequisition(licznik);
                        }
                        if (idt == "TO05" && idm == idm2)   //chleb
                        {
                            licznik = tow.GetRequisition();
                            licznik += 200;
                            tow.SetRequisition(licznik);
                        }
                        if (idt == "TO04" && idm == idm2)   //mieso
                        {
                            licznik = tow.GetRequisition();
                            licznik += 200;
                            tow.SetRequisition(licznik);
                        }
                        if (idt == "TO01" && idm == idm2)   //surowce
                        {
                            licznik = tow.GetRequisition();
                            licznik += 25;
                            tow.SetRequisition(licznik);
                        }
                        if (idt == "TO11" && idm == idm2)   //medykamenty
                        {
                            licznik = tow.GetRequisition();
                            licznik += 50;
                            tow.SetRequisition(licznik);
                        }
                    }
                }

            }

            while (ileRuin > 0)
            {
                ileRuin--;
                idm = ruiny[ileRuin];
                foreach (TableTown miasto in Modele.tableTown)
                {
                    idm2 = miasto.GetId();
                    if (idm == idm2)
                    {
                        foreach (TableArtInTown tow in Modele.tableArtInTown)
                        {
                            idt = tow.GetIdArticle();
                            idm2 = tow.GetId();
                            if (idt == "TO01" && idm == idm2)   //materiały budowlane
                            {
                                licznik = tow.GetRequisition();
                                licznik += 50;
                                tow.SetRequisition(licznik);
                            }

                        }
                    }
                }
                Modele.NowyStan("ST07", idm, 10);
            }

            foreach(TableTown miasto in Modele.tableTown)
            {
                idm = miasto.GetId();
                Random rng = new Random();
                int randomek = rng.Next(100);
                int czas2 = rng.Next(5, 16);

                switch (randomek)
                {
                    case 1:
                        Modele.NowyStan("ST01",idm, czas2);  //zaraza
                        foreach (TableArtInTown tow in Modele.tableArtInTown)
                        {
                            idt = tow.GetIdArticle();
                            idm2 = tow.GetId();
                            if (idt == "TO11" && idm == idm2)   //medykamenty
                            {
                                licznik = tow.GetRequisition();
                                licznik += 500;
                                tow.SetRequisition(licznik);
                            }
                        }
                        break;
                    case 2:
                        Modele.NowyStan("ST02", idm, czas2);  //susza
                        foreach (TableArtInTown tow in Modele.tableArtInTown)
                        {
                            idt = tow.GetIdArticle();
                            idm2 = tow.GetId();
                            if (idt == "TO02" && idm == idm2)   //jabłka
                            {
                                licznik = tow.GetRequisition();
                                licznik -= 50;
                                tow.SetRequisition(licznik);
                            }
                            if (idt == "TO05" && idm == idm2)   //chleb
                            {
                                licznik = tow.GetRequisition();
                                licznik -= 50;
                                tow.SetRequisition(licznik);
                            }
                        }
                        break;
                    case 3:
                        Modele.NowyStan("ST03", idm, czas2);  //nieurodzaj
                        foreach (TableArtInTown tow in Modele.tableArtInTown)
                        {
                            idt = tow.GetIdArticle();
                            idm2 = tow.GetId();
                            if (idt == "TO02" && idm == idm2)   //jabłka
                            {
                                licznik = tow.GetRequisition();
                                licznik -= 20;
                                tow.SetRequisition(licznik);
                            }
                            if (idt == "TO05" && idm == idm2)   //chleb
                            {
                                licznik = tow.GetRequisition();
                                licznik -= 20;
                                tow.SetRequisition(licznik);
                            }
                        }
                        break;
                    case 4:
                        Modele.NowyStan("ST04", idm, czas2);  //obfite plony
                        foreach (TableArtInTown tow in Modele.tableArtInTown)
                        {
                            idt = tow.GetIdArticle();
                            idm2 = tow.GetId();
                            if (idt == "TO02" && idm == idm2)   //jabłka
                            {
                                licznik = tow.GetRequisition();
                                licznik += 20;
                                tow.SetRequisition(licznik);
                            }
                            if (idt == "TO05" && idm == idm2)   //chleb
                            {
                                licznik = tow.GetRequisition();
                                licznik += 20;
                                tow.SetRequisition(licznik);
                            }
                        }
                        break;
                    case 5:
                        Modele.NowyStan("ST05", idm, czas2);  //b. obf. plony
                        foreach (TableArtInTown tow in Modele.tableArtInTown)
                        {
                            idt = tow.GetIdArticle();
                            idm2 = tow.GetId();
                            if (idt == "TO02" && idm == idm2)   //jabłka
                            {
                                licznik = tow.GetRequisition();
                                licznik += 50;
                                tow.SetRequisition(licznik);
                            }
                            if (idt == "TO05" && idm == idm2)   //chleb
                            {
                                licznik = tow.GetRequisition();
                                licznik += 50;
                                tow.SetRequisition(licznik);
                            }
                        }
                        break;
                    case 6:
                        czas2 /= 2;
                        Modele.NowyStan("ST06", idm, czas2);  //pożar
                        break;
                    default:
                        break;
                }

            }

        }
    }

}           