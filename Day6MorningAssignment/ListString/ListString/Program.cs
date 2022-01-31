using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> data = new List<string>();
            data.Add("a1");
            data.Add("a2");
            data.Add("a3");
            data.Add("a4");
            data.Add("a5");
            //printing values using for loop
            for(int i=0;i<data.Count;i++)
                Console.WriteLine(data[i]);



            //printing values using foreach loop
            foreach(var d in data)
                Console.WriteLine(d);



            //printing values using lambda expression
            data.ForEach(p => Console.WriteLine(p));
            Console.ReadLine();

        }
    }
}
