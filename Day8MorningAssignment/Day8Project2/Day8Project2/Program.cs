using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project2
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
               new Employee(){id=1,name="abc" ,salary=30000},
               new Employee(){id=2,name="bcd" ,salary=12000},
               new Employee(){id=3,name="cde" ,salary=31200},
               new Employee(){id=4,name="def" ,salary=45330},
               new Employee(){id=5,name="efg" ,salary=20000}

            };
            //for loop
            for(int i=0;i<employees.Count;i++)
            {
                Console.WriteLine($"id={employees[i].id}, name={employees[i].name}, salary={employees[i].salary}");
            }
            
            //foreach loop
            foreach(var e in employees)
                Console.WriteLine($"id={e.id}, name={e.name}, salary={e.salary}");
            Console.ReadLine();
            //lambda expression
            employees.ToList().ForEach(e => Console.WriteLine($"id={e.id}, name={e.name}, salary={e.salary}"));
            //LINQ 
            var result = from e in employees
                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"id={e.id}, name={e.name}, salary={e.salary}"));        }
    }
}
