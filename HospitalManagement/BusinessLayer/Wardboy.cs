using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Wardboy : Staff, HospitalStaff
    {
        public int totalPatientHandling { get; set; }
        public Wardboy() { }
        public Wardboy(Address adr, short id, short age, string name, string mobile,DateTime doj) : base(adr, id, age, name, "Wardboy", mobile,doj)
        {}
        public int GetSalary()
        {
            throw new NotImplementedException();
        }

        public void DisplayData()
        {
            throw new NotImplementedException();
        }
    }
}
