using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment160
{
    class Program
    {
        static void Main(string[] args)
        {
            Number newnumber = new Number();
            int y;
            int result;

            Console.WriteLine("type a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("optional enter a second number");
            
            if (int.TryParse(Console.ReadLine(), out y))
            {
                result = newnumber.NumberAdd(x, y);
            }
            
            else
            {
                result = newnumber.NumberAdd(x);
            }
           
            Console.WriteLine("the sum of all numbers = " + result);
            Console.ReadLine();
        }
    }
}
