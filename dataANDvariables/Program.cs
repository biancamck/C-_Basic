using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataANDvariables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("Press Enter to Begin.");
            Console.ReadLine();

            Console.WriteLine("what course are you on?");
            string curCourse = Console.ReadLine();

            Console.WriteLine("What Page number?");
            string curPage = Console.ReadLine();
            int currentPg = Convert.ToInt32(curPage);

            Console.WriteLine("do you need help with anything? true or false");
            string needHelp = Console.ReadLine();
            bool needsHelp = Convert.ToBoolean(needHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share");
            string posExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide?");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today");
            string hoursStudy = Console.ReadLine();
            int studyHours = Convert.ToInt32(hoursStudy);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();




            //Console.WriteLine("your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("whats your fave number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("your fave number is: " + total);
            //Console.ReadLine();

            //char questionMark = '\u2103';

            //int currentAge = 30;
            //string yearsOld = currentAge.ToString();

            //bool isRaining = true;
            //string rainingStatus = Convert.ToString(isRaining);
            //Console.WriteLine(rainingStatus);
            //Console.ReadLine();
        }
    }
}
