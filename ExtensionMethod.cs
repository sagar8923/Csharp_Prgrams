using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Demo1
    {
        public void Z1()
        {

        }
        public void Z2()
        {

        }
        public void Z3()
        {

        }
    }
     static class ExtensionMethod
    {
        public static void Z4(this Demo1 d)
        {
            Console.WriteLine("z4");
        }
    }
}
