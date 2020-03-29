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
            decimal Rate1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours per week");
            int Hours1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2: <please press enter>");
            Console.ReadLine();
            Console.WriteLine("What is your hourly rate?");
            decimal Rate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours per week");
            int Hours2 = Convert.ToInt32(Console.ReadLine());

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
