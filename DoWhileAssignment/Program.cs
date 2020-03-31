using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            ///// USING DO ///////
            

            Console.WriteLine("Who is the BEST trail blazer of all time (last name)?");
            string player = Console.ReadLine().ToLower();
            bool isGuessed = player == "lillard";

            do
            {
                switch (player)
                {
                    case "porter":
                        Console.WriteLine("You guessed Terry Porter. He's good but try again.");
                        Console.WriteLine("Who is the BEST trail blazer of all time (last name)?");
                        player = Console.ReadLine();
                        break;
                    case "drexler":
                        Console.WriteLine("you guessed Clyde Drexler. Arguably one of the best, but try again.");
                        Console.WriteLine("Who is the BEST trail blazer of all time (last name)?");
                        player = Console.ReadLine().ToLower();
                        break;
                    case "roy":
                        Console.WriteLine("you guessed Brandon Roy, could have been if he didn't get injured, try again");
                        Console.WriteLine("Who is the BEST trail blazer of all time (last name)?");
                        player = Console.ReadLine().ToLower();
                        break;
                    case "lillard":
                        Console.WriteLine("You guessed Damian Lillard, you are correct!!! Press <ENTER>  for next game");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Definitely no, try again.");
                        Console.WriteLine("Who is the BEST trail blazer of all time (last name)?");
                        player = Console.ReadLine().ToLower();
                        break;
                }

            }
            while (!isGuessed);
            Console.Read();
           

            //////// NEXT GAME USING WHILE /////////
            

            Console.WriteLine("Who is the WORST trail blazer of all time (last name)?");
            Console.ReadLine();
            string wplayer = Console.ReadLine().ToLower();
            bool isGuess = wplayer == "blake";

            while(!isGuess)
            {
                switch (wplayer)
                {
                    case "oden":
                        Console.WriteLine("You guessed Greg Oden. Sucky he got injured, but he was still good. Try Again.");
                        Console.WriteLine("Who is the WORST trail blazer of all time (last name)?");
                        wplayer = Console.ReadLine();
                        break;
                    case "wallace":
                        Console.WriteLine("he may have gotten in some trouble, but he was legit! Try again.");
                        Console.WriteLine("Who is the WORST trail blazer of all time (last name)?");
                        wplayer = Console.ReadLine().ToLower();
                        break;
                    case "roy":
                        Console.WriteLine("you guessed Brandon Roy, What is wrong with you? try again");
                        Console.WriteLine("Who is the WORST trail blazer of all time (last name)?");
                        wplayer = Console.ReadLine().ToLower();
                        break;
                    case "blake":
                        Console.WriteLine("You guessed Steve Blake, this guy was terrible! You are correct!!!");
                        isGuess = true;
                        break;
                    default:
                        Console.WriteLine("yeah he was pretty bad, but incorrect, try again.");
                        Console.WriteLine("Who is the WORST trail blazer of all time (last name)?");
                        wplayer = Console.ReadLine().ToLower();
                        break;
                }

            }
           
            Console.ReadLine();


        }
        
    }
}
