﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment176
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }
    }

    
}
