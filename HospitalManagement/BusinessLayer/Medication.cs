using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    //Medication Information of Patient and Composition Relationship with Problem
    public class Medication
    {
        public string medication_name;
        public string description;
        public Medication() { }
        public Medication(string name,string description)
        {
            medication_name = name;
            this.description = description;
        }
    }
}
