using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1_Demo2;
class Program
{
    static void Main(string [] args)
    {
        ArrayDemo arrayObj = new ArrayDemo();
        arrayObj.ShowDetails();

        Customer customerObj = new Customer();
        customerObj.GetCustomerDetails();
        customerObj.PrintCustomerDetails();
        customerObj.PrintCustomerPaymentDetails();
    }
}