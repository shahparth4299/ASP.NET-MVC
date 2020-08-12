using System;

namespace BusinessLayer
{
    public class Staff
    {
        protected short id;
        protected short age;
        protected string name;
        protected string position;
        protected string mobile_number;
        protected Address addr;
        protected Staff(Address adr,short id,short age,string name,string position,string mobile)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.position = position;
            mobile_number = mobile;
            addr = adr;
        }
        protected void DisplayInformation()
        {
            Console.WriteLine("Staff Id: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Position: " + position);
            Console.WriteLine("Mobile Number: " + mobile_number);

            Console.WriteLine("Address: " + addr.flat + ", " + addr.building + ", " + addr.street + "\nPin: " + addr.pin);
        }
    }
}
