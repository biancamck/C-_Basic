using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errors225
{
    class Program
    {
        static void Main(string[] args)
        {
            int curYear = DateTime.Now.Year;


            try
            {
                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0 || age > 200) throw new ArgumentException();
                int birthYear = curYear - age;
                Console.WriteLine("You were born in {0}", birthYear);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a valid age, positive integer, no decimals.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error with the data you entered.");
                Console.ReadLine();
                return;
            }
                
                
                
        }
    }
}
