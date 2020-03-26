using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace dpu_server.UnitTest.Utilities
{

    public class SQLContext
    {
        public static DbContextOptions<FruitFlyContext> TestDbContextOptions()
        {
            //New service provider to create new SQL database for unit tests
            var service = new ServiceCollection()
                .AddEntityFrameworkSqlServer()
                .BuildServiceProvider();

            //New instance is created
            var builder = new DbContextOptionsBuilder<FruitFlyContext>()
                .UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=Unittestdatabase.mdf;Integrated Security=True;") //Properly not right
                .UseInternalServiceProvider(service);

            return builder.Options;
        }
    }
}
