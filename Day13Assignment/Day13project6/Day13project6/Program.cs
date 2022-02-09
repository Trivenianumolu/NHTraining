using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13project6
{
    
    class Program
    {
        /******************************************************
         Author: Triveni Anumolu
         Purpose: Finding factorial of a number using recursion
        ******************************************************/
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        public static void Print(int n)
        {
            Console.WriteLine("Factorial of {0} is {1}", n, Factorial(n));
        }
        static void Main(string[] args)
        {
            int n = 9;
            Print(n);
            Console.ReadLine();
            
        
            
        }
    }
}
