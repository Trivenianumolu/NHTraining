using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14project1
{
    sealed class Sample
    {
        public static string s = "Hi";
        public string walk()
        {
            return "Go for a walk";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample s1 = new Sample();
            Console.WriteLine(Sample.s);
            Console.WriteLine(s1.walk());
            
            Console.ReadLine();

        }
    }
}
