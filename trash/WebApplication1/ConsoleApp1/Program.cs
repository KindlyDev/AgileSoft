using System;
using System.Data.SqlClient;
using Dapper;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=KindlyDev;Trusted_Connection=True;MultipleActiveResultSets=True"))
            {
                var result = connection.Query("SELECT * FROM  UserTask");
                //return conn.Query<T>(sql, param);
            }
        }
    }
}
