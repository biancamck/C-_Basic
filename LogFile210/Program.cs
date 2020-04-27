using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogFile210
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\repository\C#\log210.txt", number);
            string text = File.ReadAllText(@"C:\repository\C#\log210.txt");
            Console.WriteLine("from the file..." + text);
            Console.ReadLine();
        }
    }
}
