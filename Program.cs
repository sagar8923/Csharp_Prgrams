using System;

namespace ConsoleApp3
{
     class Demo
    {
        public int x = 100;
        public static int y = 200;
        public virtual void Marry()
        {
            Console.WriteLine("Marry ");
        }


    }
    class Mix:Demo

    {
        public override sealed void Marry()
        {
            Console.WriteLine("No Marry ");
        }
    }
    class Program:Mix
    {
        public new int x = 300;
        public new static int y = 400;
        const int z = 90;
        readonly string a;

        public void show()
        {
            const string ch = "varun";
            
            Console.WriteLine(ch);
        }

        static void Main(string[] args)
        {
            //Demo d=new Demo();
            //Program p = new Program();
            //Console.WriteLine(d.x+ "" + y);
            //Console.WriteLine("-----------");
            //Console.WriteLine(p.a);
            //d.Marry();
            //Address e = new Address(12, "Aligarh", "202001");
            //Employee employee = new Employee(1, "varun", e);
            //employee.show();

            //NewClass nw = new NewClass(1, "varun", 12000);
            //nw.show();
            //Demo1 d = new Demo1();
            //d.Z4();

            //      Delegates d = new Delegates();
            //      Calculation obj = new Calculation(d.Sum);
            //            obj.Invoke(1, 2);
            //  obj = d.Sub;
            //  obj.Invoke(20, 10);
            //   var student = new { eno = 1, eName = "varun", eSal = 1200 };
            //   Console.WriteLine(student.eno);
            overloading_with_typecasting ow = new overloading_with_typecasting();
            ow.show(999, 99);


        }
    }
}
