using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
//using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Caravans.model
{
    class SQLreq
    {

        //App.config - connectionstring

        //static string connectionString = ConfigurationManager.ConnectionStrings["Caravans_app.Properties.Settings.CaravansDBConnectionString"].ConnectionString;
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CaravansDB.mdf;Integrated Security=True";
        //static SqlConnection connection = new SqlConnection(connectionString);

        internal void Status()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("\n-- Opened --\n");
                
                Console.WriteLine("Свойства подключения:");
                Console.WriteLine("\tConnection String: {0}", connection.ConnectionString);
                Console.WriteLine("\tDatabase: {0}", connection.Database);
                Console.WriteLine("\tServer: {0}", connection.DataSource);
                Console.WriteLine("\tServer Version: {0}", connection.ServerVersion);
                Console.WriteLine("\tState: {0}", connection.State);
                Console.WriteLine("\tWorkstation ld: {0}", connection.WorkstationId);
                
            }
            Console.WriteLine("\n-- Closed --\n");
        }

        /*
        internal void ReadLocs()
        {
            string Comm = "Delete * FROM Locs WHERE Name=NULL";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Comm, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    //Col names
                    Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));

                    while (reader.Read()) //Read by lines
                    {
                        object id = reader.GetValue(0);
                        object Name = reader.GetValue(1);

                        Console.WriteLine("{0} \t{1}", id, Name);
                    }
                }
            }
        }*/

        /*
        internal int CountLocs()
        {
            int i = 0;
            string Comm = "SELECT COUNT(*) FROM Locs";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Comm, connection);
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        object Count = reader.GetValue(0);
                        Int32.TryParse(Count.ToString(), out i);
                    }
                }
            }
            return i;
        }
        internal void ReadRoadsMap()
        {
            string Comm = "SELECT L.Name, R.Length, R.Name FROM Locs L RIGHT JOIN Roads R ON L.IdLoc=R.IdLoc_1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();SqlCommand command = new SqlCommand(Comm, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                    while (reader.Read())
                    {
                        object City1 = reader.GetValue(0);
                        object Length = reader.GetValue(1);
                        object Name = reader.GetValue(2);

                        Console.WriteLine("{0} \t{1}  \t{2}", City1, Length, Name);
                    }
                }
            }
        }*/

        
        //Czytanie dadych z tabeli Locs do Modelu TableLoc
        internal void ReadLocsToMod(List<TableLoc> Location)
        {
            string Comm = "SELECT * FROM Locs";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Comm, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) //Read by lines
                    {
                        object id = reader.GetValue(0).ToString();
                        object Name = reader.GetValue(1).ToString();

                        Location.Add(new TableLoc(id.ToString(), Name.ToString()));
                    }
                }
            }
        }


        //Czytanie dadych z tabeli Article do Modelu TableArticle
        internal void ReadArticleToMod(List<TableArticle> Article)
        {
            string Comm = "SELECT * FROM Article";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Comm, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) //Read by lines
                    {
                        object id = reader.GetValue(0).ToString();
                        object Name = reader.GetValue(1).ToString();
                        object Price = reader.GetValue(2).ToString();
                        object Prod = reader.GetValue(3).ToString();
                        object Req = reader.GetValue(4).ToString();

                        Article.Add(new TableArticle(id.ToString(), Name.ToString(), Convert.ToInt32(Price), Convert.ToInt32(Prod), Convert.ToInt32(Req)));
                    }
                }
            }
        }


        //Czytanie dadych z tabeli State do Modelu TableState
        internal void ReadStateToMod(List<TableState> State)
        {
            string Comm = "SELECT * FROM State";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Comm, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) //Read by lines
                    {
                        object id = reader.GetValue(0).ToString();
                        object Name = reader.GetValue(1).ToString();
                        object Description = reader.GetValue(2).ToString();

                        State.Add(new TableState(id.ToString(), Name.ToString(), Description.ToString()));
                    }
                }
            }
        }


        //Czytanie dadych z tabeli Road do Modelu TableRoad
        internal void ReadRoadsToMod(List<TableRoad> Road)
        {
            string sqlSelect = "SELECT * FROM Roads";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlSelect, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) //Read by lines
                    {
                        object id = reader.GetValue(0);
                        object idLoc1 = reader.GetValue(1);
                        object idLoc2 = reader.GetValue(2);
                        object Length = reader.GetValue(3);
                        object Name = reader.GetValue(4);

                        Road.Add(new TableRoad(id.ToString(), idLoc1.ToString(), idLoc2.ToString(), Convert.ToInt32(Length), Convert.ToInt32(Name)));
                    }
                }
            }
        }


        //Czytanie dadych z tabeli Town do Modelu TableTown
        internal void ReadTownToMod(List<TableTown> Town)
        {
            string sqlSelect = "SELECT * FROM Town";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlSelect, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) //Read by lines
                    {
                        object id = reader.GetValue(0);
                        object Name = reader.GetValue(1);
                        object Population = reader.GetValue(2);
                        object IdLoc = reader.GetValue(3);
                        object Military = reader.GetValue(4);
                        object Prosperity = reader.GetValue(5);
                        object Food = reader.GetValue(6);

                        Town.Add(new TableTown(id.ToString(), Name.ToString(), Convert.ToInt32(Population), IdLoc.ToString(), Convert.ToInt32(Military), Convert.ToInt32(Prosperity), Convert.ToInt32(Food)));
                    }
                }
            }
        }


        //Czytanie dadych z tabeli Town do Modelu TableCaravan
        internal void ReadCaravanToMod(List<TableCaravan> Caravan)
        {
            string sqlSelect = "SELECT * FROM Caravan";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlSelect, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) //Read by lines
                    {
                        object id = reader.GetValue(0);
                        object IdLoc = reader.GetValue(1);
                        object Wagons = reader.GetValue(2);
                        object Guard = reader.GetValue(3);
                        object Duration = reader.GetValue(4);
                        object Minions = reader.GetValue(5);

                        Caravan.Add(new TableCaravan(id.ToString(), IdLoc.ToString(), Convert.ToInt32(Wagons), Convert.ToInt32(Guard), Convert.ToInt32(Duration), Convert.ToInt32(Minions)));
                    }
                }
            }
        }


        //Czytanie dadych z tabeli Town do Modelu TableTownState
        internal void ReadTownStateToMod(List<TableTownState> TownState)
        {
            string sqlSelect = "SELECT * FROM Town_State";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlSelect, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) //Read by lines
                    {
                        object id = reader.GetValue(0);
                        object IdState = reader.GetValue(1);
                        object Duration = reader.GetValue(2);

                        TownState.Add(new TableTownState(id.ToString(), IdState.ToString(), Convert.ToInt32(Duration)));
                    }
                }
            }
        }


        //Czytanie dadych z tabeli Town do Modelu tableArtInCaravan
        internal void ReadArtInCaravanToMod(List<TableArtInCaravan> ArtInCaravan)
        {
            string sqlSelect = "SELECT * FROM Art_in_Caravan";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlSelect, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) //Read by lines
                    {
                        object id = reader.GetValue(0);
                        object IdArticle = reader.GetValue(1);
                        object Number = reader.GetValue(2);

                        ArtInCaravan.Add(new TableArtInCaravan(id.ToString(), IdArticle.ToString(), Convert.ToInt32(Number)));
                    }
                }
            }
        }


        //Czytanie dadych z tabeli Town do Modelu tableArtInCaravan
        internal void ReadArtInTownToMod(List<TableArtInTown> ArtInTown)
        {
            string sqlSelect = "SELECT * FROM Art_in_Town";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlSelect, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) //Read by lines
                    {
                        object id = reader.GetValue(0);
                        object IdArticle = reader.GetValue(1);
                        object Number = reader.GetValue(2);
                        object Requisition = reader.GetValue(3);
                        object Production = reader.GetValue(4);

                        ArtInTown.Add(new TableArtInTown(id.ToString(), IdArticle.ToString(), Convert.ToInt32(Number), Convert.ToInt32(Requisition), Convert.ToInt32(Production)));
                    }
                }
            }
        }

        /*
            //Update DB tables

            //Update dadych tabeli Article do Modelu TableArticle
            //internal void UpdateArticle(string Id, string Name, string Price, string Production, string Requisition)
            //internal void UpdateArticle(TableArticle Article)
        void UpdateArticle(string Comm)
        {
            //string Comm = "UPDATE Article SET Name='" + Article.GetName() + "' Price='" + Article.GetPrice() + "' Production='" + Article.GetProduction() + "' Requisition='" + Article.GetRequisition() + "' WHERE IdArticle=" + Article.GetId();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("\n-- Opened --\n");
                connection.Open();
                SqlCommand command = new SqlCommand(Comm, connection);
                int i = command.ExecuteNonQuery();
                Console.WriteLine("Обновлено объектов: {0}", i);
                SqlDataAdapter dd = new SqlDataAdapter();
                
                //connection
            }
            
            Console.WriteLine("\n-- Closed --\n");
        }*/
    }
}
