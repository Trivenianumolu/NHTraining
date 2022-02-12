using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15project3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sr = new StreamWriter("D:\\DotnetProjects\\Stream\\sample.txt",true);
            sr.WriteLine("JKL");
            sr.WriteLine("MNO");
            sr.WriteLine("PQR");
            sr.Close();
            Console.WriteLine("Data Appended");
            Console.ReadLine();

        }
    }
}
