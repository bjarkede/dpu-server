using dpu_server.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dpu_server.Controller
{
    // Dependency injection !!
    public class DatabaseControllerServer : IDisposable
    {
        private readonly FruitFlyContext _context;
        public DatabaseControllerServer()
        {
            _context = new FruitFlyContext();
        }
        public List<Referencepoint> XYQuery()
        {
            List<Referencepoint> XYList = _context.Referencepoints
                                         .Where(r => r.ReferencepointId == 1) // fjern senere
                                         .Select(r =>
                                         new Referencepoint
                                         {
                                             X = r.X,
                                             Y = r.Y
                                         })
                                         .ToList();
            foreach (var Referencepoint in XYList)
            {
                Console.WriteLine($"X: {Referencepoint.X} , Y: {Referencepoint.Y}\n");
            }
            return XYList;
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
        //Automatically closes the database TODO: Make sure it actually disposes
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
