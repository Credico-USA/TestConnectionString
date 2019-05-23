/*
 * tariq.ahmed@crediocusa.com
 * */
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Use this tool to test out a db connection string
/// </summary>
namespace TestConnectingString
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbTest"].ConnectionString))
                {
                    Console.WriteLine("Trying to connect....");
                    conn.Open();
                    Console.WriteLine("connection string works...");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Invalid Connection String");
                Console.ReadLine();
            }
        }
    }
}
