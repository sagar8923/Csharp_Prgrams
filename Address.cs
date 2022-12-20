using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Address
    {
        private int houseNo;
        private string area;
        private string pincode;

        public Address(int houseNo, string area, string pincode)
        {
           this. houseNo = houseNo;
           this. area = area;
            this.pincode = pincode;
        }
        public override string ToString()
        {
            return houseNo + " " + area + " " + pincode; 
        }

    }
     class Employee
    {
        private int eno;
        private string empName;
        private Address address;
        public Employee(int eno , string empName, Address address)
        {
            this.eno = eno;
            this.empName = empName;
            this.address = address;
        }
        public void show()
        {
           
            Console.WriteLine(eno);
            Console.WriteLine(empName);
            Console.WriteLine(address);
        }

    }

}
