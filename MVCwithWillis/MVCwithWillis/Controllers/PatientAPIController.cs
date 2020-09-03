using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HospitalRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCwithWillis.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [EnableCors("MyCorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class PatientAPIController : ControllerBase
    {
        private HospitalDbContext db;
        public PatientAPIController(IPatient p, HospitalDbContext db)
        {
            this.db = db;

        }
        // GET: api/<PatientAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PatientAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/PatientAPI
        [HttpPost]
        public IActionResult Post([FromBody] List<Patient> obj)
        {
            foreach(var item in obj)
            {
                Patient p = new Patient();
                //p.id = item.id;
                p.name = item.name;
                p.address = item.address;

                var context = new ValidationContext(obj, null, null);
                List<ValidationResult> errresult = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(obj, context, errresult, true);
                if (isValid)
                {
                    db.patients.Add(p);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, errresult);
                }
            }
            db.SaveChanges();
            List<Patient> pat = db.patients.ToList();
            return Ok(pat);
        }

        // PUT api/<PatientAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PatientAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
