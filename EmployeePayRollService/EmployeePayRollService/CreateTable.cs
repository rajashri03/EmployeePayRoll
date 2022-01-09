using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollService
{
    public class CreateTable
    {
        /// <summary>
        /// Create Database-PayrollService
        /// </summary>
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
                Console.WriteLine("exception occured while creating database:" + e.Message + "\t");
            }
        }
        /// <summary>
        /// Created table using sqlcommand in payrollservice database
        /// </summary>
        public static void CreateTables()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AD-PC\SQLEXPRESS; Initial Catalog =payroll_service; Integrated Security = True;");
                con.Open();
                SqlCommand cmd = new SqlCommand("Create table Employee_Payroll(id int identity(1,1) primary key,Name varchar(200),Salary varchar(200),Start_date DATE);", con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Payroll table has been  created successfully!");
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating table:" + e.Message + "\t");
            }
        }
    }
}
