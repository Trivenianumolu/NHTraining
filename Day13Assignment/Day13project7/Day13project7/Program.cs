using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13project7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*******************************************************
              Author:Triveni Anumolu
              Purpose:performing operations on stack
            ********************************************************/
             
            Stack<int> data = new Stack<int>();
            data.Push(6);
            data.Push(1);
            data.Push(7);
            data.Push(76);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Peek());
            Console.WriteLine(data.Pop());
            Console.WriteLine(data.Count());
            Console.ReadLine();
        }
    }
}
