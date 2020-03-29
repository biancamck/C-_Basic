using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a random number?");
            string randomNumber = Console.ReadLine();
            int randNum = Convert.ToInt32(randomNumber);
            int product = randNum * 50;
            Console.WriteLine("Your number * 50 = " + product);
            Console.ReadLine();

            Console.WriteLine("type another random number?");
            string randomNumber2 = Console.ReadLine();
            int randNo2 = Convert.ToInt32(randomNumber2);
            int sum = randNo2 + 25;
            Console.WriteLine("Your number + 25 = " + sum);
            Console.ReadLine();

            Console.WriteLine("type a random number?");
            string randomNumber3 = Console.ReadLine();
            double randNum3 = Convert.ToDouble(randomNumber3);
            double quotient = randNum3 / 12.5;
            Console.WriteLine("Your number / 12.5 = " + quotient);
            Console.ReadLine();

            Console.WriteLine("type a random number?");
            string randomNumber4 = Console.ReadLine();
            int randNum4 = Convert.ToInt32(randomNumber4);
            bool isGreater = randNum4 > 50;
            Console.WriteLine("Your number is greater than 50. " + isGreater.ToString());
            Console.ReadLine();

            Console.WriteLine("type a random number?");
            string randomNumber5 = Console.ReadLine();
            int randNum5 = Convert.ToInt32(randomNumber5);
            int remainder = randNum5 % 7;
            Console.WriteLine("your number devided by 7 gives a remainder of " + remainder);
            Console.ReadLine();
        }
    }
}