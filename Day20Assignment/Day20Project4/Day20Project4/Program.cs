using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project4
{
    class Program
    {
        //Author:Triveni Anumolu
        //Purpose:code using ref parameter
        public static void Add(ref int a)
        {
            a += a;
            Console.WriteLine("Inside method:" + a);
        }
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("Before:" + a);
            Add(ref a);
            Console.WriteLine("After:" + a);
            Console.ReadLine();
        }
    }
}
