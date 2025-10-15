using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_OOPS_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TechnicalConsultant technicalConsultantObj = new TechnicalConsultant();
            //technicalConsultantObj.GetEmployeeDetails();
            //technicalConsultantObj.CreateReport();
            //Console.WriteLine("Your salary Amount: {0}", technicalConsultantObj.CalculateSalary());

            //SalesPerson salesObj = new SalesPerson();
            //salesObj.GetEmployeeDetails();
            //salesObj.CreateReport();
            //Console.WriteLine("Your salary Amount: {0}", salesObj.CalculateSalary());

            Users userObj = new Users(100,"Aaron","aaron123@gmail.com");
            userObj.PrintDetails();

        }
    }
}
