using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Comm_demo
{
    internal class Customer
    {
        public int Customerid;
        public string CustomerName;
        public string CustomerType;
        public double CartPrice;
        public int Discount;
        public int Cashback;

        public virtual void GetCustomerDetails()
        {
            Console.WriteLine("Id");
            Customerid = int.Parse(Console.ReadLine());
            Console.WriteLine("Customer Name");
            CustomerName = Console.ReadLine();
            Console.WriteLine("Customer Type");
            CustomerType = Console.ReadLine();
        }
        public virtual double GetFinalBill()
        {
            return CartPrice*(100-Discount)+Cashback;
        }
    }
}
