using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface Interface1 
    {
        static int x ;
        static void Marry2()
        {
            Console.WriteLine("marry 2");
        }
        static Interface1()
        {
            x = 2000;
            Console.WriteLine("constructor value " + x);
        }

        public abstract void show2();
        void show1();
    }
    interface Interface2 
    {
        static string name="varun";
        static Interface2()
        {
            Console.WriteLine("2 interface");
        }
        public void marry()
        {
            Console.WriteLine("Normal 2");
        }
    }
    interface Interface3
    {
        void M1();
    }
    interface Interface4
    {
        void M1();
    }
}
