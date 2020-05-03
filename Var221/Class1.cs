using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var221
{
    class Class1
     {
        public string str1 { get; set; }
        

        public Class1(): this("hello")
        {
            
        }
        public Class1(string X)
        {
            str1 = X;
        }

        
    }
}
