using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            if(a.HasValue)
                Console.WriteLine(a/a);
            else
                Console.WriteLine("No Input");
           
            Console.ReadLine();
        }
    }
}
