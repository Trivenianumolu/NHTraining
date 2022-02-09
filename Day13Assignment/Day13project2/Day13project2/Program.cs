using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13project2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] data = new int[ , ] { { 1, 2 } ,{ 4, 5 }, { 8, 9 } };
          

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
