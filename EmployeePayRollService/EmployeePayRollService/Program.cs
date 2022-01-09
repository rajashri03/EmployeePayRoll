// See https://aka.ms/new-console-template for more information
using EmployeePayRollService;

Console.WriteLine("****************Employee Payroll Service***********************");
bool options = true;
while(options)
{
    Console.WriteLine("Select Option:\n1)Create Database\n2)Create Table");
    int op = Convert.ToInt16(Console.ReadLine());
    switch(op)
    {
        case 1:
            CreateTable.Create_Database();
            break;
        case 2:
            CreateTable.CreateTables();
            break;
    }
}


