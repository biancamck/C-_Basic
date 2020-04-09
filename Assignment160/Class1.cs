using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment160
{
    public class Number
    {
        public int NumberAdd(int x, int y = 1)
        {
            int sum = x + y + 100;
            return sum;

        }

        public int x { get; set; }       
        public int y { get; set; }
    }
}
