using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientLibrary;

namespace MVCwithWillis.Controllers
{
    public class PatientController : Controller
    {
        
        public static HospitalViewModel addModel = new HospitalViewModel();
        
        public PatientController( IPatient p)
        {
            if(addModel.total_patients is null)
            {
                addModel.total_patients = new List<Patient>();
            }
        }
       
        public IActionResult Add() // Load the UI
        {
            return View("PatientAdd" , addModel); // <---- here will be the problem
        }

        [HttpPost]
        public IActionResult AddPatient(Patient obj) // When button is clicked
        {
            if(addModel.current_patient is null)
            {
                addModel.current_patient = obj;
            }
            return View("PatientAdd",addModel);
        }
        [HttpPost]
        public IActionResult AddProblems(PatientProblem obj) // When button is clicked
        {
            if (addModel.current_problem is null)
            {
                addModel.current_problem = obj;
            }
            return View("PatientAdd", addModel);
        }
        public IActionResult AddTreatments(Treatment obj) // When button is clicked
        {
            addModel.current_problem.treatment.Add(obj);
            return View("PatientAdd", addModel);
        }
        public IActionResult AddFinal2()
        {
            addModel.current_patient.problems.Add(addModel.current_problem);
            addModel.current_problem = null;
            return View("PatientAdd", addModel);
        }
        public IActionResult AddFinal()
        {
            addModel.total_patients.Add(addModel.current_patient);
            addModel.current_patient = null;
            return View("PatientAdd", addModel);
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}