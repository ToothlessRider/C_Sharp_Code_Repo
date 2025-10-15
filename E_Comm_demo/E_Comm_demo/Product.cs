using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Comm_demo
{
    internal class Product
    {
        public string ProductName;
        public int ProductPrice;

        public virtual void GetProductDetailsI()
        {
            Console.WriteLine("Enter name of product: ");
            ProductName = Console.ReadLine();
            Console.WriteLine("Enter Price of product: ");
            ProductPrice = int.Parse(Console.ReadLine());

        }

    }
}
