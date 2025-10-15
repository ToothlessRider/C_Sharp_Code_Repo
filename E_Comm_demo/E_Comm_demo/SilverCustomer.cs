using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Comm_demo
{
    internal class SilverCustomer:Customer, ICashBack
    {

        public double CalculateCashBack()
        { 
            return 100.00;
            throw new NotImplementedException();
        }

        public override void GetCustomerDetails()
        {
            base.GetCustomerDetails();
            Product productObj = new Product();
            productObj.GetProductDetailsI();
            Console.WriteLine("You have bought {0} for {1}", productObj.ProductPrice, productObj.ProductName);
            CartPrice = productObj.ProductPrice;
        }
        public override double GetFinalBill()
        {
            return CartPrice + Cashback;
        }
    }
}
