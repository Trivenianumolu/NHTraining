using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15project5
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Copy("D:\\DotnetProjects\\Day15Assignment\\File.txt","D:\\DotnetProjects\\NewFile\\File.txt");
            Console.WriteLine("File is copied");
            Console.ReadLine();
        
        }
    }
}
