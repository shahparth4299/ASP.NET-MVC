using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    //Inheritance From Staff Class
    //Implementing Salary Interface
    public class Doctor : Staff, HospitalStaff
    {
        public string education { get; set; }
        public int totalPatientHandling { get; set; }
        public Doctor() 
        { }
        public Doctor(string education,Address adr, short id, short age, string name, string mobile, DateTime doj) : base(adr, id, age, name, "Doctor", mobile,doj)
        {
            this.education = education;
        }
        public void DisplayDoctor()
        {
            //DisplayInformation();
            Console.WriteLine("Doctor Education: " + education);
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
