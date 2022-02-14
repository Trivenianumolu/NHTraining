using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriveniALibrary;
using PublicLibrary;

namespace ClientApp
{
    class program
    {
        static void Main(string[] args)
        {
            //Mathematics m = new Mathematics();
            Console.WriteLine(Mathematics.Fact(5));
            Physics p = new Physics();
            Console.WriteLine(p.Force(7, 8));
            Console.ReadLine();
        }
    }
}
