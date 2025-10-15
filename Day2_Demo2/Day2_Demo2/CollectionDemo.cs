using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Demo2
{
    internal class CollectionDemo
    {
        public void GetDetails()
        {
            ArrayList listObj = new ArrayList();
            Console.WriteLine("Capacity: {0}", listObj.Capacity);
            listObj.Add("Rocks");
            Console.WriteLine("Capacity: {0}", listObj.Capacity);
            listObj.Add("John");
            listObj.Add(1010);
            listObj.Add(200);
            Console.WriteLine("Capacity: {0}", listObj.Capacity);

            // So we can see that all the values stored in a List are of "Object type", i.e., an implicit type conversion takes place
            // Implicit Conversion

            for (int i = 0; i < listObj.Count; i++)
            {
                Console.WriteLine(listObj[i]);
            }

            Console.WriteLine("\n---------------");
            listObj.Remove(1010);

            for (int i = 0; i < listObj.Count; i++)
            {
                Console.WriteLine(listObj[i]);
            }
            Console.WriteLine("\n---------------");


            Console.WriteLine("Search");
            Console.WriteLine("\n---------------");

            Console.WriteLine(listObj.Contains("David"));

            Console.WriteLine("\n---------------");

            // But once we search and extract a value we need to explicitly convert it
            int result = (int)listObj[2]; // Un-boxing ----> Explicit Type Conversion
            Console.WriteLine(result);

            object[] listArray = listObj.ToArray();
            
            foreach(var item in listArray){
                Console.WriteLine(item);
            }

        }
    }
}
