using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14project2
{
    class Program
    {
        /*****************************************************************
         Author: Triveni Anumolu
         Purpose:Finding whether a number is prime or not by using break
        ******************************************************************/
        static void Main(string[] args)
        {
            int i, n = 99;
            for( i=2;i<n;i++)
            {
                if (n % i == 0)
                    break;
            }
            if(i==n)
                Console.WriteLine("{0} is a prime number",n);
            else
                Console.WriteLine("{0} is not a prime number",n);
            Console.ReadLine();

        }
    }
}
