using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public partial class NewClass
    {
        static partial  void Zone();
        public NewClass(int eno, string ename, float salary)
        {
            this.eno = eno;
            this.ename = ename;
            this.salary = salary;
        }
    }
}
