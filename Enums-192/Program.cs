using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_192
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a day of the week.");
                string userDay = Console.ReadLine();
                Days myDay = (Days)Enum.Parse(typeof(Days), userDay, ignoreCase:true);
                Console.WriteLine("Your chosen day, " + myDay + " is a day of the week");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week");
                return;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
