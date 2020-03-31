using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Program
 {
    static void Main()
    {
        //1.

        string[] stArray = { "orange", "blue", "green", "purple", "red" };
        Console.WriteLine("Choose a number between 0 and 4");
        int indeX = Convert.ToInt32(Console.ReadLine());

        if (indeX >= 0 && indeX <= 4)
        {
            Console.WriteLine(stArray[indeX]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Index does not exist.");
            Console.ReadLine();
        }


        //2.

        int[] numArray = { 4, 7, 2, 8, 3 };
        Console.WriteLine("Choose a number between 0 and 4");
        int indeY = Convert.ToInt32(Console.ReadLine());

        if (indeY >= 0 && indeY <= 4)
        {
            Console.WriteLine(numArray[indeY]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Index does not exist.");
            Console.ReadLine();
        }

        //4.

        List<string> stList = new List<string>();
        stList.Add("Techno");
        stList.Add("House");
        stList.Add("DnB");
        stList.Add("Electro");
        stList.Add("Bass");

        Console.WriteLine("Choose a number between 0 and 4");
        int indeZ = Convert.ToInt32(Console.ReadLine());

        if (indeZ >= 0 && indeZ <= 4)
        {
            Console.WriteLine(stList[indeZ]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Index does not exist.");
            Console.ReadLine();
        }


        //LIST FUNDAMENTALS//

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //List<string> intList1 = new List<string>();
        //intList1.Add("Hello");
        //intList1.Add("Bianca");
        //intList1.Remove("Bianca");

        //Console.WriteLine(intList1[0]);
        //Console.ReadLine();

        //byte[] byteArray = new    //add large amounts of information to an array, a large arrray

        //ARRAY FUNDAMENTALS//

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 }; //best way to write an array

        //numArray2[5] = 650; //change a value in the array

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

    }
}

