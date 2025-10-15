using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
    // One solution can have multiple projects
{
    // Classes go inside the namespace
    internal class Program
    {
        // All the methods and variables go inside the class
        // We can't declare global variables for C#
        static void Main(string[] args)
        {
            //Don't create multiple main methods
            //Use program.cs to create objects, take input and provide output
            
            Console.WriteLine("This is our first live lecture");
            
            Console.WriteLine("C# Programming");

            // If you are asked to create a new class the create a new file entirely
            // Like we create Employee.cs, if asked to create Customer, make a new class file

            Employee employeeObj = new Employee();

            //Console.Write("Enter Employee ID: ");
            //employeeObj.EmployeeID = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Employee Name: ");
            //employeeObj.EmployeeName = Console.ReadLine();

            // employeeObj.GetDetails(employeeObj.EmployeeID, employeeObj.EmployeeName);
            //employeeObj.Print();
            //employeeObj.PrintDetails();
            //employeeObj.CheckDifference();

            Employee employeeObj2 = new Employee();
            //employeeObj2.CheckDifference();
            // This outputs 1 2 because it's

            arrays arrayObj = new arrays();
            arrayObj.SingleArray();
            arrayObj.MultiArray();


            Console.ReadLine(); // Keep console open

        }


    }
}
