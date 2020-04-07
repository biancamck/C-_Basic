using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DivideAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> newlist = new List<int>() { 12, 66, 90, 45, 10 };
                Console.WriteLine("choose a number");
                int usernumber = Convert.ToInt32(Console.ReadLine());

                foreach (int number in newlist)
                {
                    Console.WriteLine("Dvividing " + number + " by " + usernumber);
                    int finalnumber = number / usernumber;
                    Console.WriteLine(number + " divided by " + usernumber + " = " + finalnumber);
                    
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("the program has emerged from the try/catch block and continued on with program execution");
            Console.ReadLine();
        }
       
    }
}
