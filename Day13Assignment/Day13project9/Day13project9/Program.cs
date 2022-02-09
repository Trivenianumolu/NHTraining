using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13project9
{
    class Program
    {
        /******************************************************** 
         Author: Triveni Anumolu 
         Purpose: Sum of two matrices
        *********************************************************/
        static void Main(string[] args)
        {
            int[,] data1 = new int[2, 2];
            int[,] data2 = new int[2, 2];
            int[,] sum = new int[2, 2];
            //Read data from user for first matrix

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter a number for first matrix at ({i},{j})");
                    data1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
           
           
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter a number for second matrix at ({i},{j})");
                    data2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Sum of two matrices is");
            
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    sum[i, j] = data1[i, j] + data2[i, j];
                    Console.Write(sum[i,j] +" ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}