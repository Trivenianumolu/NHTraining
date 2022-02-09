using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13project4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];
            //Read data from user
            for(int i=0;i<2;i++)
            {
                for (int j = 0; j<2;j++)
                {
                    Console.WriteLine($"Enter a number at ({i},{j})");
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
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
