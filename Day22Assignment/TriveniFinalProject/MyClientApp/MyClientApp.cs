using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;

namespace MyClientApp
{
    //Author : Triveni Anumolu
    /*********************  Purpose: Client Application  *************/ 
    public static  class Program
    {
        /// <summary>
        /// This method is to read user input and Add Employee Details
        /// </summary>
        public static void AddEmployee()
        {
            int id, sal, age;
            string name;
            Console.WriteLine("enter employee id");
            id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            name=Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            sal=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Age");
            age=Convert.ToInt32(Console.ReadLine());
            //Calling BLL
            var result=EmployeeBLL.AddEmployee(id,name,sal,age);
            if(result)
                Console.WriteLine("Employee Details Saved");
            else
                Console.WriteLine("error Occured");
        }
        /// <summary>
        /// This method is used to get employee by Id
        /// </summary>
        public static void SearchById()
        {
            int id;
            Console.WriteLine("Enter id:");
            id= Convert.ToInt32(Console.ReadLine());
            //Calling BLL
            var result=EmployeeBLL.SearchById(id);
            if(result.Count==0)
                Console.WriteLine("No record Found");
            else
                result.ForEach(d => Console.WriteLine(d));
        }
        /// <summary>
        /// this method is used to get employee by name
        /// </summary>
        public static void SearchByName()
        {
            string name;
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            //Calling BLL
            var result = EmployeeBLL.SearchByName(name);
            if (result.Count==0)
                Console.WriteLine("No record Found");
            else
                result.ForEach(d => Console.WriteLine(d));
        }
        /// <summary>
        /// This method is used to Display Employee Details
        /// </summary>
        public static void DisplayAllEmployees()
        {
            var result= EmployeeBLL.DisplayAllEmployees();
            result.ToList().ForEach(d => Console.WriteLine(d));
        }
        static void Main(string[] args)
        {
            int ch;
            string choice;
            do
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("         Employee Management Application               ");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Searching Employee By Id");
                Console.WriteLine("3.Searching Employee By Name");
                Console.WriteLine("4.Display All Employees");
                Console.WriteLine("Enter choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        SearchById();
                        break;
                    case 3:
                        SearchByName();
                        break;
                    case 4:
                        DisplayAllEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine("Still Wanna Continue (T/F)");
                choice = Console.ReadLine();
            } while (choice.Equals("T"));
        }
    }
}
