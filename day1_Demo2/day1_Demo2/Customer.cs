using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1_Demo2
{
    internal class Customer
    {
        int CustomerId;
        string Customername;
        double Payment;
        long ContactNumber;

        Customer[] CustomerArray; // Customer Array Declaration
        public void GetCustomerDetails()
        {
            Console.WriteLine("Enter the Customer Count");
            int customerCounter = int.Parse(Console.ReadLine());

            CustomerArray = new Customer[customerCounter]; // Initializing Customer Array
            for (int i = 0; i < customerCounter; i++)
            {
                // Store customer Object
                CustomerArray[i] = new Customer();
                Console.WriteLine("Id");
                CustomerArray[i].CustomerId = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Name");
                CustomerArray[i].Customername = Console.ReadLine();

                Console.WriteLine("Payment");
                CustomerArray[i].Payment = double.Parse(Console.ReadLine()); 

                Console.WriteLine("Contact");
                CustomerArray[i].ContactNumber = long.Parse(Console.ReadLine());
            }

        }
        public void PrintCustomerDetails()
        {
            for (int i = 0;i < CustomerArray.Length; i++)
            {
                Console.WriteLine("Customer ID: {0} \tCustomer Name: {1} \tCustomer payment: {2} \tCustomer Contact Num: {3}", CustomerArray[i].CustomerId, CustomerArray[i].Customername, CustomerArray[i].Payment, CustomerArray[i].ContactNumber);
            }
        }
        public void PrintCustomerPaymentDetails()
        {
            for(int i = 0;i < CustomerArray.Length ; i++)
            {
                Console.WriteLine("Customer ID: {0} \tCustomers Payment: {1}", CustomerArray[i].CustomerId, CustomerArray[i].Payment);
            }
        }
    }
}
