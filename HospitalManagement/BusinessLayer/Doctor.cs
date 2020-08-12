using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Doctor : Staff
    {
        string speciality;
        Salary s;
        public Doctor(Salary s,string speciality,Address adr, short id, short age, string name, string mobile) : base(adr, id, age, name, "Doctor", mobile)
        {
            this.speciality = speciality;
            this.s = s;
        }
        public void DisplayDoctor()
        {
            DisplayInformation();
            Console.WriteLine("Doctor Speciality: " + speciality);
        }
        public int DoctorSalary(short patient_count)
        {
            return s.GetSalary(patient_count);
        }
    }
}
