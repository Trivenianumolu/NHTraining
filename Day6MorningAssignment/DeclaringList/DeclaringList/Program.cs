using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringList
{
    class Program
    {
        static void Main(string[] args)
        {
            int count, sum=0;
            List<int> data = new List<int>();
            data.Add(5);
            data.Add(15);
            data.Add(25);
            data.Add(35);
            data.Add(45);
            data.Add(55);
            foreach (var d in data)
                sum = sum + (int)d;
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
