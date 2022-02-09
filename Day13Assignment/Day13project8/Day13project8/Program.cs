using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13project8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*******************************************************
              Author:Triveni Anumolu
              Purpose:performing operations on queue
            ********************************************************/

            Queue<int> data = new Queue<int>();
            data.Enqueue(6);
            data.Enqueue(1);
            data.Enqueue(7);
            data.Enqueue(76);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Peek());
            Console.WriteLine(data.Dequeue());
            Console.WriteLine(data.Count());
            Console.ReadLine();
        }
    }
}
