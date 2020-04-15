using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment176
{
    interface IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("this employee has quit");
        }
    }
}
