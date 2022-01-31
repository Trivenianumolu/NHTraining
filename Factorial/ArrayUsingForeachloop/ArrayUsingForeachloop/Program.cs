using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUsingForeachloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Entered numbers are");
            foreach(int d in array)
                Console.WriteLine(d);
            Console.ReadLine();

        }
    }
}
