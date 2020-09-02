using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    //Storing problems of Patient and composition relationship with Medication, Aggregation relationship with Visit
    public class Problems
    {
        public string problem_name, problem_description;
        private short _totalDays;
        public short totalDays
        {
            get
            {
                return _totalDays;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Invalid Days");
                else
                    _totalDays = value;
            }
        }
        public List<Medication> medication;
        public Problems() { }
        public Problems(string problem_name,string problem_description,short totalDays)
        {
            this.problem_name = problem_name;
            this.problem_description = problem_description;
            this.totalDays = totalDays;
        }
    }
}
