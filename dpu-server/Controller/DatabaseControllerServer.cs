using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace dpu_server.Controller
{
    public class DatabaseControllerServer
    {
        private static string _connectionString = "Server=tcp:fruitflyserver.database.windows.net,1433;" +
            "Initial Catalog=FruitFly;Persist Security Info=False;User ID=dalleman;Password=Frugtflue1;" +
            "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private static SqlConnection connection = new SqlConnection(_connectionString);

        public void Connect()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection to the database opened\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot open a connection to the database\n");
            }
        }

        List<(int,int)> XYQuery(string QueryString)
        {
            // hent data i en tuple: X Y

            return null;
        }

        List<(int, int, int, int)> RSSICategoryQuery(string QueryString)
        {
            // hent data i en tuple: Category, RSSI1, RSSI2, RSSI3

            return null;
        }

        public void Insert(string QueryString)
        {
            //(x, y) og(category, rssi1, rss2, rssi3)
            //String.Format("UPDATE reference SET category = {0} WHERE x = {1} AND y = {2}", catagory, x, y)

            // update sql
        }

        public void Disconnect()
        {
            connection.Close();
            Console.WriteLine("Connection to the database closed\n");
        }
    }
}
