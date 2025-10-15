using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_OOPS_demo
{
    internal class SalesPerson:Employee,IEmployeeReport
    {
        double SalesAmount;
        double SalesComission;
        public override void GetEmployeeDetails()
        {
            base.GetEmployeeDetails();
            Console.WriteLine("Sales Amount");
            SalesAmount = int.Parse(Console.ReadLine());
        }
        public override double CalculateSalary()
        {
            SalesComission = 0.10;
            Basic = 10000;
            HRA = 5000;
            PF = 1000;
            return base.CalculateSalary() + (SalesAmount * SalesComission);
        }

        public void CreateReport()
        {
            Console.WriteLine("Sales Report for {0} \nSales Amount: {1} \nSalary: {2}",EmployeeName,SalesAmount,CalculateSalary());
            throw new NotImplementedException();
            // So we create the abstract for CreateReport before
        }
    }
}
