using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    //Patient class which contains all information of Patient
    //Aggregation Relationship with Doctor, Nurses, Wardboy, Visit
    //Composition Relationship with Allergy 
    public class Patient
    {
        public short id;
        public string name;
        public Address adr;
        public string phoneNumber { get; set; }
        public List<Allergies> allergy;
        public List<Visit> visit;
        public Doctor d;
        public List<Nurses> nurse;
        public List<Wardboy> wardboy;
        public Patient()
        {
            allergy = new List<Allergies>();
            nurse = new List<Nurses>();
            wardboy = new List<Wardboy>();
        }
    }
}
