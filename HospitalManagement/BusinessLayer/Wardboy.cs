using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Wardboy : Staff
    {
        Salary s;
        public Wardboy(Salary s, Address adr, short id, short age, string name, string mobile) : base(adr, id, age, name, "Wardboy", mobile)
        {
            this.s = s;
        }
        public void DisplayWardboy()
        {
            DisplayInformation();
        }
        public int WardboySalary()
        {
            return s.GetSalary();
        }
    }
}
