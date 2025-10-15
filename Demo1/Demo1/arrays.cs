using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class arrays
    {
        public int[] arr1d = new int[2];
        public string[] namearr = new string[2];
        public string[,] arr2d = new string[2,2];
        public int[][] jadArr = new int[2][]; 
        public void SingleArray()
        {
            Console.WriteLine("Input 2 numbers for this array");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("enter number {0}", i+1);
                arr1d[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("\nYou entered:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Array value {0}: {1}", i, arr1d[i]);
            }


        }
        public void MultiArray()
        {
            Console.WriteLine("Enter Names of 2 people and their subjects");
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Enter Name of Person {i + 1}: ");
                arr2d[i, 0] = Console.ReadLine(); 

                Console.Write($"Enter Subject for {arr2d[i, 0]}: ");
                arr2d[i, 1] = Console.ReadLine();
            }

            Console.WriteLine("\nYou Entered:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Name: {arr2d[i, 0]}, Subject: {arr2d[i, 1]}");
            }
        }

        public void JaggedArray()
        {
            Console.WriteLine("Enter Names of 2 peopel and their subjects");
            for(int i = 0;i < 2; i++)
            {
                
            }
        }
    }
}
