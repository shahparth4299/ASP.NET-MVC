using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Salary
    {
        public int salary;
        public Salary(int salary)
        {
            this.salary = salary; 
        }
        public int GetSalary()
        {
            return salary;
        }
        public int GetSalary(short total_patients)
        {
            return salary * total_patients;
        }
            
    }
}
