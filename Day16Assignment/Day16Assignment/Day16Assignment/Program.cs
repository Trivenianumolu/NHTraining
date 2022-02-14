using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriveniLibrary;

namespace Day16Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.ReadInput();
            Console.WriteLine(m.Factorial());
            Chemistry c = new Chemistry();
            Console.WriteLine(c.GetBenzene());
            Console.WriteLine(c.GetWater( ));
            Console.WriteLine(c.GetMethane()); 
            Physics p = new Physics();
            Console.WriteLine(p.GetForce(3,5)); 
            Console.ReadLine();

        }
    }
}
