using System;
using System.Collections.Generic;
// This is the collection we have to use for Generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Demo1
{
    internal class Customer
    {
        int CustomerId;
        string CustomerName;
        long PhoneNum;
        List<Customer> CustomerList;
        // This declares the custom datatype we need

        public void StoreDetails()
        {
            //CustomerList = new List<Customer>();

            //Customer c1 = new Customer() { CustomerId = 101, CustomerName = "Aaron Augustine",PhoneNum=9283772819};
            //instead of 33 separated lines of
            // c1.CustomerId = 101 

            //Customer c2 = new Customer() { CustomerId = 102, CustomerName = "Aum Adhau", PhoneNum = 8299381727};

            CustomerList = new List<Customer>() 
            { 
                new Customer(){ CustomerId = 101, CustomerName = "Aaron Augustine",PhoneNum=9283772819},
              new Customer(){ CustomerId = 102, CustomerName = "Aum Adhau", PhoneNum = 8299381727}
            };

        }

        public void PrintCustomer()
        {
            foreach (var item in CustomerList)
            {
                Console.WriteLine("{0} {1} {2}",item.CustomerName,item.CustomerId,item.PhoneNum);
            }
        }

    }
}
