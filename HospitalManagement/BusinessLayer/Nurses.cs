using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    //Nurse is inheriting from staff and implementing Salary
    public class Nurses : Staff, HospitalStaff
    {
        public int totalPatientHandling { get; set; }
        public Nurses() { }
        public Nurses(Address adr, short id, short age, string name, string mobile,DateTime doj) : base(adr,id,age,name,"Nurse",mobile,doj)
        {}
        public void DisplayNurses()
        {
            //DisplayInformation();
        }
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
