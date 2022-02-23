using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    //Author : Triveni Anumolu
    /***********  Purpose : Data Access Layer Library **************/
    public static class EmployeeDAL
    {
        public static string filePath = "C:\\Users\\91832\\Desktop\\C#Projects\\Employee.txt";
        /// <summary>
        /// This method is used to Add Employee details
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="empName"></param>
        /// <param name="eSal"></param>
        /// <param name="empAge"></param>
        /// <returns></returns>
        public static bool AddEmployee(int empId,string empName,int eSal,int empAge)
        {
            try
            {
                string textContent=string.Concat(empId,",",empName,",",eSal,",",empAge);
                File.AppendAllText(filePath, textContent + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// This Method is used to search employee by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<string> SearchById(int id)
        {
            var allEmployees=File.ReadAllLines(filePath);
            bool isFound=false;
            List<string> empFound=new List<string>();
            foreach (string emp in allEmployees)
            {
                var empDetails=emp.Split(',');
                if(empDetails[0] == id.ToString())
                {
                    isFound=true;
                    empFound.Add(emp);
                    break;
                }
            }
            return empFound;
        }
        /// <summary>
        /// This Method is used to search employee by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<string> SearchByName(string name)
        {
            var allEmployees = File.ReadAllLines(filePath);
            List<string> empFound = new List<string>();
            foreach (string emp in allEmployees)
            {
                var empDetails = emp.Split(',');
                if(empDetails[1].Contains(name))
                
                    empFound.Add(emp);
                
            }
            return empFound;
        }
        /// <summary>
        /// This method is used to Display all Employees
        /// </summary>
        /// <returns></returns>
        public static string[] DisplayAllEmployees()
        {
            var allEmployees = File.ReadAllLines(filePath);
            return allEmployees;
        }
    }
}
