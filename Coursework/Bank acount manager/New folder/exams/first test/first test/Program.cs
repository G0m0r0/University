﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_test
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FooBar");
                else if (i % 3 == 0) Console.WriteLine("Foo");
                else if (i % 5 == 0) Console.WriteLine("Bar");
                else Console.WriteLine(i) ;
            }
        }
    }
}
