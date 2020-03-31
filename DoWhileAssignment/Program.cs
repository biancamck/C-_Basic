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
            

            Console.WriteLine("Who is the best trail blazer of all time (last name)?");
            string player = Console.ReadLine().ToLower();
            bool isGuessed = player == "lillard";

            do
            {
                switch (player)
                {
                    case "porter":
                        Console.WriteLine("You guessed Terry Porter. He's good but try again.");
                        Console.WriteLine("Who is the best trail blazer of all time (last name)?");
                        player = Console.ReadLine();
                        break;
                    case "drexler":
                        Console.WriteLine("you guessed Clyde Drexler. Arguably one of the best, but try again.");
                        Console.WriteLine("Who is the best trail blazer of all time (last name)?");
                        player = Console.ReadLine().ToLower();
                        break;
                    case "roy":
                        Console.WriteLine("you guessed Brandon Roy, could have been if he didn't get injured, try again");
                        Console.WriteLine("Who is the best trail blazer of all time (last name)?");
                        player = Console.ReadLine().ToLower();
                        break;
                    case "lillard":
                        Console.WriteLine("You guessed Damian Lillard, you are correct!!! Press <ENTER>  for next game");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Definitely no, try again.");
                        Console.WriteLine("Who is the best trail blazer of all time (last name)?");
                        player = Console.ReadLine().ToLower();
                        break;
                }

            }
            while (!isGuessed);
            Console.Read();
           

            //////// NEXT GAME USING WHILE /////////
            

            Console.WriteLine("Who is the best trail blazer of all time (last name)?");
            Console.ReadLine();
            string bplayer = Console.ReadLine().ToLower();
            bool isGuess = bplayer == "lillard";

            while(!isGuess)
            {
                switch (bplayer)
                {
                    case "porter":
                        Console.WriteLine("You guessed Terry Porter. He's good but try again.");
                        Console.WriteLine("Who is the best trail blazer of all time (last name)?");
                        bplayer = Console.ReadLine();
                        break;
                    case "drexler":
                        Console.WriteLine("you guessed Clyde Drexler. Arguably one of the best, but try again.");
                        Console.WriteLine("Who is the best trail blazer of all time (last name)?");
                        bplayer = Console.ReadLine().ToLower();
                        break;
                    case "roy":
                        Console.WriteLine("you guessed Brandon Roy, could have been if he didn't get injured, try again");
                        Console.WriteLine("Who is the best trail blazer of all time (last name)?");
                        bplayer = Console.ReadLine().ToLower();
                        break;
                    case "lillard":
                        Console.WriteLine("You guessed Damian Lillard, you are correct!!!");
                        isGuess = true;
                        break;
                    default:
                        Console.WriteLine("Definitely no, try again.");
                        Console.WriteLine("Who is the best trail blazer of all time (last name)?");
                        bplayer = Console.ReadLine().ToLower();
                        break;
                }

            }
           
            Console.ReadLine();


        }
        
    }
}
