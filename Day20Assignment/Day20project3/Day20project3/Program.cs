using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20project3
{
    class Program
    {
        //Author: Triveni Anumolu
        //Purpose:code using out parameter
          public static void Add(out int p, out int q)
          {
                p = 4;
                q = 5;   
          }
        static void Main(string[] args)
        {

            int i, j;
            Add(out i, out j);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}