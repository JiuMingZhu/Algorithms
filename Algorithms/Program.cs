using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array0 = new int[2][];
            array0[0] = new int[30];
            array0[1] = new int[25];
            Console.WriteLine($"array0[0].GetType() is {array0[0].GetType()}");
            Console.WriteLine($"array0[0,1].GetType() is {array0[0][1].GetType()}");
            int[,] array1 = new int[2, 3] { { 1,2,3},{3,2,1 } };
            Console.WriteLine($"array1[0][1].GetType() is {array1[0,1].GetType()}");
            Console.Read();
        }
    }
}
