using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Comm_demo
{
    internal interface IDiscount
    {
        double CalculateDiscount(Product p);
    }
}
