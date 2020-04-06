using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateLoopAssignment
{
    class Program
    {
        static void Main()
        {
            ///// 1. 
            ///// 
            string[] names = { "Tom", "John", "Larry", "Joe" };
            Console.WriteLine("Type an adjective of your choice");
            string adjective = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " is " + adjective);    ////this prints all items in array
            }
            Console.ReadLine();

            Console.WriteLine("Press enter to proceed");
            Console.ReadLine();


            ///2. and 3.
            ///

            int a = 0;
            while (true)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
                if (a == 5)                         //added if statement and added a value in which the loop will break
                {
                    Console.WriteLine("stop, a = 5");
                    break;
                }
            }

            Console.WriteLine("Press enter to proceed");
            Console.ReadLine();


            ///4.
            ///
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("J is equal to " + j);
                j++;

            }
            Console.ReadLine();

            Console.WriteLine("Press enter to proceed");
            Console.ReadLine();

            ///5.
            ///
            int l = 0;
            while (l <= 3)
            {
                Console.WriteLine("J is equal to " + l);
                l++;

            }
            Console.ReadLine();

            Console.WriteLine("Press enter to proceed");
            Console.ReadLine();


            ///// 6. 7. 8.
            /////

            List<string> colors = new List<string>() { "blue", "orange", "green", "purple", "red", "yellow" };
            Console.WriteLine("Type a color");
            string usercolor = Console.ReadLine();
            bool matchfound = false;

            for (int h = 0; h < colors.Count; h++)
            {
                if (colors[h] == usercolor)
                {
                    matchfound = true;
                    Console.WriteLine(String.Format("Element {0} found at index {1}", usercolor, h));
                    
                    //IEnumerable<string> duplicates = colors2.GroupBy(x => x).Where(g => g.Count() > 1).Select(x => x.Key);
                    //Console.WriteLine("Duplicate elements are: " + String.Join(",", duplicates));
                }
            }
            if (matchfound == false)
            {
                Console.WriteLine("You have chosen a color not in the list.");
            }
            Console.ReadLine();

            Console.WriteLine("Press enter to proceed");
            Console.ReadLine();


            ///9. 10.  
            ///

            List<string> colors2 = new List<string>() { "blue", "orange", "green", "blue", "red", "yellow", "green" };
            Console.WriteLine("Type a color");
            string usercolor2 = Console.ReadLine();
            bool matchfound2 = false;
            for (int i = 0; i < colors2.Count; i++)
            {
                if (colors2[i] == usercolor2)
                {
                    matchfound2 = true;
                    Console.WriteLine(String.Format("the color you chose, {0} is found at index {1}", usercolor2, i));
                    Console.ReadLine();
                    //IEnumerable<string> duplicates = colors2.GroupBy(x => x).Where(g => g.Count() > 1).Select(x => x.Key);
                    //Console.WriteLine("Duplicate elements are: " + String.Join(",", duplicates));
                }

            }
            if (matchfound2 == false)
            {
                Console.WriteLine("You have chosen a color not in the list.");
            }
            Console.ReadLine();

            Console.WriteLine("Press enter to proceed");
            Console.ReadLine();

            /// 11.
            ///

            List<string> colors3 = new List<string>() { "blue", "orange", "green", "blue", "red", "yellow", "green" };
            List<string> colors3temp = new List<string>();
            foreach (string color3 in colors3)
            {
                foreach (string element in colors3temp)
                {
                    if (color3 == element)
                    {
                        Console.WriteLine("The duplicate color " + color3 + " was already found in index " + colors3temp.IndexOf(element));
                    }
                }
                colors3temp.Add(color3);
                //IEnumerable<string> duplicates = colors3.GroupBy(x => x).Where(g => g.Count() > 1).Select(x => x.Key);
                //Console.WriteLine(String.Join(", ", duplicates) + " are duplicates in this list.");

            }

            Console.ReadLine();

            Console.WriteLine("END");
            Console.ReadLine();



        }
    }
}
