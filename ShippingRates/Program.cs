using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingRates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please Follow the Instructions below");
            Console.WriteLine("What is the weight of the package?");
            double weight = Convert.ToDouble(Console.ReadLine());
                        
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Great, What is the package width?");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Great, What is the package height?");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                double length = Convert.ToDouble(Console.ReadLine());
                
                double dimensions = (height + length + width);
                
                if (dimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    double quote = ((width * height * length * weight) / 100);
                    decimal totQuote = Convert.ToDecimal(Math.Round(quote, 2));
                    Console.WriteLine("Your quote for shipping this package is: $" + totQuote);
                    Console.ReadLine();
                }
            }
        }
    }
}
