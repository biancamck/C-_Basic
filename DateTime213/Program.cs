using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime213
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The time is " + DateTime.Now);
            Console.ReadLine();
            Console.WriteLine("Enter a number");
            int X = Convert.ToInt32(Console.ReadLine());
            DateTime FutureTime = DateTime.Now.AddHours(X);
            Console.WriteLine("In {0} hours, the time will be {1}", X,FutureTime);
            Console.ReadLine();
            
           
        }
    }
}
