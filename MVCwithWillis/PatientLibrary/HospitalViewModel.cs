using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PatientLibrary
{
    public class HospitalViewModel
    {
        public List<Patient> total_patients { get; set; }
        public Patient current_patient { get; set; }
        //public List<PatientProblem> total_problems { get; set; }
        public PatientProblem current_problem { get; set; }
        public List<ValidationResult> errors { get; set; }
    }

    
}
