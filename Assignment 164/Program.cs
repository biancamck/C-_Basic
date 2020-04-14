using System;

namespace Assignment_164
{   
    static class Program        //static class - 6
    {
        static void Main(string[] args)
        {
            Number newnumber = new Number();        //instantiate class - 2
            Console.WriteLine("enter a number");
            int x = Convert.ToInt32(Console.ReadLine());        //user enters number, perform funcrion - 3
            newnumber.Divide(x);
            Console.ReadLine();
        }

       
        
        // out params - 4

        public static void Addition(out int p, out int q)
        {
            p = 30;
            q = 40;
            p += p;
            q += q;
            Console.WriteLine("the solution for p is " + p);
            Console.WriteLine("the solution for q is " + q);
            Console.ReadLine();
        }




        
        /// method overloading - 5
        
     
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main2(string[] args)
        {
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }

}

