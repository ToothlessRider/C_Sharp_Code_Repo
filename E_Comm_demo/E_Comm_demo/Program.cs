using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Comm_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            GoldCustomer GoldCustomerObj = new GoldCustomer();
            Console.WriteLine("Enter Customer Details");
            GoldCustomerObj.GetCustomerDetails();
            Console.WriteLine("Your Bill (Gold Customer) is: {0}", GoldCustomerObj.GetFinalBill());

            SilverCustomer SilverCustomerObj = new SilverCustomer();
            Console.WriteLine("Enter Customer Details");
            SilverCustomerObj.GetCustomerDetails();
            Console.WriteLine("Your Bill (Silver Customer) is: {0}", SilverCustomerObj.GetFinalBill());

        }
    }
}
