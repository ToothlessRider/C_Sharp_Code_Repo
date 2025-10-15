using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_OOPS_demo
{
    // here when you add interface then hover over the redlinea and hit "Implement interface"
    internal class TechnicalConsultant:Employee,IEmployeeReport
    {
        // We will calculate salary for the number of hours worked
        int NoOfHourseWorked;
        double AmounPerHours;

        public override void GetEmployeeDetails()
        { 
            // base keyword --- It isused to access base class method or constructor code from derived class
            base.GetEmployeeDetails();
            Console.WriteLine("Hours Worked");
            NoOfHourseWorked = int.Parse(Console.ReadLine());
        }
        public override double CalculateSalary()
        {
            AmounPerHours = 1000;
            Basic = 10000;
            HRA = 6000;
            PF = 1500;
            return base.CalculateSalary() + (NoOfHourseWorked * AmounPerHours);
            // Create a technicalConsultant object and then allocate these properties to it
        }
        public void CreateReport()
        {
            Console.WriteLine("Sales Report for {0} \nHours Worked: {1} \nSalary: {2}", EmployeeName, NoOfHourseWorked, CalculateSalary());
            throw new NotImplementedException();
        }
    }
}
