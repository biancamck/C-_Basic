using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment156
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, lets do some math operations!");
            Console.WriteLine("Enter a whole number");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            Number newnumber = new Number();
            int result1 = newnumber.NumberAdd(userNumber);
            Console.WriteLine("Your number plus 100 = " + result1);
            Console.ReadLine();

            Number newnumber2 = new Number();
            int result2 = newnumber2.NumberMult(userNumber);
            Console.WriteLine("Your number multiplied byt 5 = " + result2);
            Console.ReadLine();

            Number newnumber3 = new Number();
            int result3 = newnumber3.NumberSub(userNumber);
            Console.WriteLine("Your number minus 3 = " + result3);
            Console.ReadLine();

        }
        
    }
}
