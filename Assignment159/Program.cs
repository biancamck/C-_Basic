using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment159
{
    class Program
    {
        static void Main(string[] args)
        {
            Number newnumber = new Number();
            int y = 5;
            int result1 = newnumber.NumberAdd(y);
            Console.WriteLine("5 + 100 = " + result1);
            Console.ReadLine();

            Number newnumber2 = new Number();
            decimal x = 1.5m;
            decimal result2 = newnumber2.NumberMult(x);
            Console.WriteLine("1.5m x 10 = " + result2);
            Console.ReadLine();

            Console.WriteLine("enter a number");
            int z = Convert.ToInt32(Console.ReadLine());
            Number newnumber3 = new Number();
            int result3 = newnumber3.NumberSub(z);
            Console.WriteLine("Your number " + z + " minus 3 = " + result3);
            Console.ReadLine();
        }
    }
}
