using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{        //public void show(int a, int b)
        //{
        //    int result = a + b;
        //    Console.WriteLine(result);
        //}
    public delegate void Calculation(int a, int b);
    class Delegates
    {
        public  void Sum(int a , int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        public void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }
        public void Mul(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }
        
    }
}
