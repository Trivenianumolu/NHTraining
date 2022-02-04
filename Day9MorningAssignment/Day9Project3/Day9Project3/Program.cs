using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project3
{
    class Employee
    {    
        /***********************************************************************
        Author: Triveni Anumolu
        Program: Creating employee class and printing variables
        ***********************************************************************/
        private int id;
        private string name;
        private int salary;
        public static string company;
        public void Readdata()
        {
            Console.WriteLine("Enter ID number");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter salary");
            salary = Convert.ToInt32(Console.ReadLine());
            company = "Amazon";
        }
        public void Printdata()
        {
            Console.WriteLine($"Id={id}, Name={name}, Salary={salary}, Company={company}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Readdata();
            e1.Printdata();
            Employee e2 = new Employee();
            e2.Readdata();
            e2.Printdata();
            Console.ReadLine();
        }
        
    }
}
