using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1_Demo2
{
    internal class ArrayDemo
    {
        public void ShowDetails()
        {
            int[][] numbersArray = new int[3][];
            numbersArray[0] = new int[] { 10, 20, 30 };
            numbersArray[0] = new int[] { 10, 20, 30 };
            numbersArray[1] = new int[] { 10, 50 };
            numbersArray[2] = new int[] { 30, 20, 70 };
            for (int i = 0; i < numbersArray.Length; i++)
            {
                for (int j = 0; j < numbersArray[i].Length; j++)
                {
                    Console.Write(numbersArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
