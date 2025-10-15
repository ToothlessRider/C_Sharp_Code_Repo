using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Employee
    {
        public int EmployeeID;
        public string EmployeeName;
        bool isExperienced;

        public static int StaticCount;

        public void GetEmployeeDetails()
        {
            EmployeeID = 101;
            EmployeeName = "Aaron";
            //Apart from string if you're taking input using ReadLine() func, then you need to do conversions
            Console.WriteLine("Enter Employee ID: ");
            EmployeeID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            EmployeeName = Console.ReadLine();

            Console.WriteLine(EmployeeID + " " + EmployeeName);
            //Instaed of writing it like this we can do what is given below
            Console.WriteLine("{0} {1}", EmployeeID, EmployeeName);
        }
        public void GetDetails(int id, string name)
        {
            // This can be done in the GetEmployeeeDetails function too, but for keeping the 
            // code readable we've separated it.
            Console.WriteLine("{0} {1}", id, name);
        }
        public void Print()
        {
            Console.WriteLine("employee ID: {0}, Employee Name: {1} and Experience {2}", EmployeeID, EmployeeName,isExperienced);
            
        }
        public void PrintDetails()
        {
            int Id = 101;
            string name = "Jeremiah";
            Console.WriteLine("Id: {0} Name: {1}",Id,name);

            Console.WriteLine("employee ID: {0}, Employee Name: {1} and Experience {2}", EmployeeID, EmployeeName, isExperienced);
        }
        public void CheckDifference()
        {
            EmployeeID++;
            StaticCount++;
            Console.WriteLine("EmployeeID : {0} Static Count: {1}",EmployeeID,StaticCount);
        }
    }
}
