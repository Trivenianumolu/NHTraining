using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16project4
{
    class MulTable
    {
        int n;
        public  void ReadData()
        {
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintTable()
        { 
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(n+"*"+i+"="+n*i);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MulTable mt = new MulTable();
            mt.ReadData();
            mt.PrintTable();
            Console.ReadLine();
        }
    }
}
