using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HospitalRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientLibrary;

namespace MVCwithWillis.Controllers
{
    public class PatientController : Controller
    { 
       
        public IActionResult Add() // Load the UI
        {
            return View("PatientAdd"); // <---- here will be the problem
        }

        
    }
}