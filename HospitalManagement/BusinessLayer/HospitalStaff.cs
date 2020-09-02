using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    //HospitalStaff Interface for Doctors, Nurses, Wardboys
    //Contract for totalPatientHandling, Salary and Display Data
    public interface HospitalStaff
    {
        int totalPatientHandling { get; set; }
        int GetSalary();
        void DisplayData();
    }
    //Factory Method to create Doctor, Nurse, Wardboy by passing Value
    public static class Factory
    {
        public static HospitalStaff CreateStaff(string staff)
        {
            if(staff.Equals("Doctor"))
            {
                return new Doctor();
            }
            else if (staff.Equals("Nurse"))
            {
                return new Nurses();
            }
            else if(staff.Equals("Wardboy"))
            {
                return new Wardboy();
            }
            else
            {
                throw new Exception("You selected inappropriate option");
            }
        }
    }
}
