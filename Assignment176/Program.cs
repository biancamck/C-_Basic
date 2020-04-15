using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment176
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName(employee.FirstName, employee.LastName);
                       
        }
        
        IQuittable quitter = new Employee();
        quitter.Quit();

    }
}