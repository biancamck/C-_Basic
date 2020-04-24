using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joe_202
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employees> employees = new List<Employees>();
            employees.Add(new Employees() { Fname = "Joe", Lname = "Biden", ID = 1 });
            employees.Add(new Employees() { Fname = "Joe", Lname = "Bullit", ID = 2 });
            employees.Add(new Employees() { Fname = "Jane", Lname = "Doe", ID = 3 });
            employees.Add(new Employees() { Fname = "Sally", Lname = "Fields", ID = 4 });
            employees.Add(new Employees() { Fname = "Fred", Lname = "Simpson", ID = 5 });
            employees.Add(new Employees() { Fname = "Molly", Lname = "Parker", ID = 6 });
            employees.Add(new Employees() { Fname = "Sam", Lname = "Miller", ID = 7 });
            employees.Add(new Employees() { Fname = "Ashley", Lname = "Banks", ID = 8 });
            employees.Add(new Employees() { Fname = "Brittany", Lname = "Murphy", ID = 9 });
            employees.Add(new Employees() { Fname = "Jack", Lname = "Ramsey", ID = 10 });

           foreach (Employees emp in employees)
           {
                Console.WriteLine(emp.Fname + " " + emp.Lname + " " + emp.ID);
           }
            Console.ReadLine();
           
            

            List<Employees> joeList = new List<Employees>();
            foreach (Employees joe in employees)
            {
                if (joe.Fname == "Joe")
                { 
                    joeList.Add(joe);
                    Console.WriteLine(joe.Fname + " " + joe.Lname);
                }
            }
            Console.ReadLine();

            List<Employees> newList = employees.Where(x => x.ID >= 5).ToList();

            foreach (Employees over5 in newList)
            {
                Console.WriteLine(over5.Fname + " " + over5.Lname + " " + over5.ID);
            }
            Console.ReadLine();

        }
    }
}
