using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment169
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //Person.SayName(employee);
            Console.WriteLine("Name: " + employee.FirstName + " " + employee.LastName);
            Console.ReadLine();
        }
    }
}