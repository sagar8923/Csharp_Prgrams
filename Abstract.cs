using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class First_Abstract
    {

        public abstract void Show();
        public void Show1()
        {
            Console.WriteLine("Show1");
        }
        public First_Abstract()
        {
            Console.WriteLine("Hii");
        }
            
        
    }
   class Femo:First_Abstract
    {
        public static int x;
        public override void Show()
        {
            Console.WriteLine("Abstract 1");
        }
        
        public Femo()
        {
            Console.WriteLine("hello");
        }
        
    }
}
