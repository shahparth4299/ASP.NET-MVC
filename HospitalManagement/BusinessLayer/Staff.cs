using System;

namespace BusinessLayer
{
    //It is Base Class for Doctors, Nurses, Wardboys
    public class Staff
    {
        public short id;
        public DateTime doj;
        public short age;
        public string name;
        public string department;
        public string mobileNumber { get; set; }
        public Address addr;
        public Staff() { }
        public Staff(Address adr,short id,short age,string name,string department,string mobile,DateTime doj)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.department = department;
            mobileNumber = mobile;
            addr = adr;
            this.doj = doj;
        }
        /*
        protected void DisplayInformation()
        {
            Console.WriteLine("Staff Id: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Mobile Number: " + mobile_number);

            Console.WriteLine("Address: " + addr.flat + ", " + addr.building + ", " + addr.street + "\nPin: " + addr.pin);
        }*/
    }
}

/*
                if (RegularExpressionCheck.RegCheck(value, @"(\+[0-9]{2}|\+[0-9]{2}\(0\)|\(\+[0-9]{2}\)\(0\)|00[0-9]{2}|0)([0-9]{9}|[0-9\-\s]{9,18})"))
                    mobileNumber = value;
                else
                    throw new Exception("Invalid Phone Number");
                */