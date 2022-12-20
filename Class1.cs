using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class1 : First_Abstract, Interface1 , Interface2
    {
        public void show1()
        {
            Console.WriteLine("Interface 1");
        }
        public override void Show()
        {
            Console.WriteLine("old abstract");
        }
        public void show2()
        {
            Console.WriteLine("Interface 1");
        }
        //static void Main()
        //{
        //    Class1 c = new Class1();
        //    //c.show1();
        //    //c.Show();
        //    //c.show2();
        //    // Console.WriteLine(Interface1.x) ;
        //    // Console.WriteLine(Interface2.name);
        //    Interface3 I1 = new class4();
        //    Interface4 I2 = new class4();
        //    I2.M1();
        //    I1.M1();
        // //  n3 obj =new n3();
        //}
        class n1
        {
            static n1()
            {
                Console.WriteLine("n1");    
            }
        }
        class n2:n1
        {
            static n2()
            {
                Console.WriteLine("n2");
            }
        }
        class n3:n2
        {
            static n3()
            {
                Console.WriteLine("n3");
            }
        }

        class class4 : Interface3, Interface4
        {
            public void M1()
            {
                Console.WriteLine("Varun"); 
            }
        }





    }
}
