using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;

namespace introSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);

            var repo = new DapperDepartmentRepository(conn);

            var departments = repo.GetAllDepartsments();

            foreach (var dept in departments)
            {
                Console.WriteLine($"{dept.DepartmentID} {dept.Name}");

            }
        }
    }
}

