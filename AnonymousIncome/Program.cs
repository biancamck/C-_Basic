using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: <please press enter>");
            Console.ReadLine();
            Console.WriteLine("What is your hourly rate?");
            string personRate1 = Console.ReadLine();
            decimal Rate1 = Convert.ToDecimal(personRate1);
            Console.WriteLine("How many hours per week");
            string personHours1 = Console.ReadLine();
            int Hours1 = Convert.ToInt32(personHours1);

            Console.WriteLine("Person 2: <please press enter>");
            Console.ReadLine();
            Console.WriteLine("What is your hourly rate?");
            string personRate2 = Console.ReadLine();
            int Rate2 = Convert.ToInt32(personRate2);
            Console.WriteLine("How many hours per week");
            string personHours2 = Console.ReadLine();
            int Hours2 = Convert.ToInt32(personHours2);

            decimal weekSalary1 = Rate1 * Hours1;
            decimal annSalary1 = weekSalary1 * 52;
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine("$" + annSalary1);

            decimal weekSalary2 = Rate2 * Hours2;
            decimal annSalary2 = weekSalary2 * 52;
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine("$" + annSalary2);

            bool moMoney = annSalary1 > annSalary2;
            Console.WriteLine("Does person 1 make more money than person 2? " + moMoney.ToString());
            Console.ReadLine();
        }
    }
}
