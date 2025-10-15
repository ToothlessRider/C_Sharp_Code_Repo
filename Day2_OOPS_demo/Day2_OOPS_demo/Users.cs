using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_OOPS_demo
{
    internal class Users
    {
        int UserId;
        string UserName;
        string EmailId;

        static int UserCount;

        public Users()
        {
            
        }
        public Users(int id, string name, string email) // Parameterized Constructor
        {
            UserId = id;
            UserName = name;
            EmailId = email;
        }
        static Users() // Static Constructor
        {
            UserCount = 20;
            Console.WriteLine("Users Count: {0}",UserCount);
        }
        //private Users()
        //{
        //    // This will prevent us froma accessing it in the main function
        //}
        public void PrintDetails()
        {
            Console.WriteLine("{0} {1} {2} ", UserId, UserName, EmailId);
        }
    }
}
