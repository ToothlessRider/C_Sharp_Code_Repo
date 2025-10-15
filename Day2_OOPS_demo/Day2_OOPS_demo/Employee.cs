using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_OOPS_demo
{
    internal class Employee
    {
        public int EmployeeID;
        public string EmployeeName;
        public double Basic;
        public double HRA;
        public double PF;
        // If these variables are private then we won't be able to access them in the other classes
        public virtual void GetEmployeeDetails()
        {
            // This functio has been created to prevent repetition
            Console.WriteLine("Id");
            EmployeeID = int.Parse(Console.ReadLine());
            Console.WriteLine("Name");
            EmployeeName = Console.ReadLine();
        }
        
        public virtual double CalculateSalary()
        {
            //return 0.00;
            return Basic + HRA - PF;

        }

    }
    
}
