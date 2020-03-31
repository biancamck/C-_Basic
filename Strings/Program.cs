using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bianca ";
            name = name.ToUpper();
            string good = ("Good Afernoon " + name);
            string well = "Hope you are well.";
            Console.WriteLine(good + well);

            StringBuilder sb = new StringBuilder();

            sb.Append("This is cool, Bianca!");
            Console.WriteLine(sb);
            Console.ReadLine();


            //code from string videos
            //string filename = @"C:\users\bmck"; //@ symbol at beginning tells it that everything in quotes is the string, no esc \

            //bool trueOrFalse = name.Contains("s"); //useful for parsing. this looks to see if string contains x
            //trueOrFalse = name.EndsWith("a"); //to see if string ends with a

            //int length = name.Length; //looks for how many characters

            //name = name.ToUpper();

            //Console.WriteLine(name);
            //Console.ReadLine();




        }
    }
}
