using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollService
{
    public class CreateDatabase
    {
        public static void Create_Database()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AD-PC\SQLEXPRESS; Initial Catalog =master; Integrated Security = True;");
                con.Open();
                SqlCommand cmd = new SqlCommand("Create database payroll_service;", con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database created successfully!");
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating table:" + e.Message + "\t");
            }
        }
    }
}
