
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    //Adding the allergies of Patient and Patient can have multiple Allergies
    //Composition Relationship with the Patient class
    public class Allergies
    {
        public string name;
        public string description;
        private short _totalYears;
        public short totalYears
        {
            get
            {
                return _totalYears;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Invalid Years");
                else
                    _totalYears = value;
            }
        }
        public Patient p;
        public Allergies() { }
        public Allergies(string name, string description, short totalYears)
        {
            this.name = name;
            this.description = description;
            this.totalYears = totalYears;
        }
    }
}
