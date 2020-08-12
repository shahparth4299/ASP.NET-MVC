using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Nurses : Staff
    {
        public Salary s;
        public Nurses(Salary s,Address adr, short id, short age, string name, string mobile) : base(adr,id,age,name,"Nurse",mobile)
        {
            this.s = s;
        }
        public void DisplayNurses()
        {
            DisplayInformation();
        }
        public int NurseSalary()
        {
            return s.GetSalary();
        }

    }
}
