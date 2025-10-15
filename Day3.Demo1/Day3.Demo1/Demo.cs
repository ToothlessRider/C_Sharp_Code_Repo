using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Demo1
{
    internal class Demo
    {
        public void StoreDetails()
        {
            SortedList cityTable = new SortedList();
            // If we use the sorted list we get an alphabetically sorted list
            //Hashtable cityTable = new Hashtable();
            cityTable.Add("BLR", "Bangalore");
            cityTable.Add("DEL", "Delhi");
            cityTable.Add("IDR", "Indore");
            cityTable.Add("CHN", "Chennai");
            cityTable.Add("MUM", "Mumbai");

            foreach (var cityKey in cityTable.Keys)
            {
                Console.WriteLine(cityKey);

            }

            Console.WriteLine("\n--------------------");

            foreach (var cityValue in cityTable.Values) 
            { 
                Console.WriteLine(cityValue); 
            }

            Console.WriteLine("\n--------------------");

            foreach (var item in cityTable.Keys)
            {
                Console.WriteLine("Key: {0} \tValue: {1}", item, cityTable[item]);
            }
        }
    }
}
