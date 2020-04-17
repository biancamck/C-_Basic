using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment176
{
    public class Employee<T> : Person, IQuittable
    {
        public int ID { get; set; }
        public List<T> Things { get; set; }     //assignment 187

        public void Quit()          //assignment 179
        {
            Console.WriteLine("This employee has quit");
            Console.ReadLine();
        }

        public void CheckID(int ID1, int ID2)       //assignment 184
        {
            bool sameID = ID1 == ID2;
            Console.WriteLine(sameID);
            Console.ReadLine();
        }
        
    }

    
}
