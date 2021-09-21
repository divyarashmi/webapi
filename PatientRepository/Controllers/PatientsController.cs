using Microsoft.AspNetCore.Mvc;
using PatientRepository.Model;
using PatientRepository.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace PatientRepository.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientsController : ControllerBase
    {
        IPatientsRepository ipatientsRepository;

        public PatientsController(IPatientsRepository _ipatientsRepository)
        {
            ipatientsRepository=_ipatientsRepository;
        }
        [HttpPost("Add")]
        public IActionResult CreatePatient(Patient patient)
        {
            ipatientsRepository.AddPatientRecord(patient);
            return Ok("Record Added");
        }
        [HttpPut("Update")]
            public IActionResult Edit(Patient patient)  
        {  
            if(ModelState.IsValid)
            {
                ipatientsRepository.UpdatePatientRecord(patient);
                return Ok("record is updated ");
            }
            return BadRequest();
        }
           [HttpDelete("{id}")]  
        public IActionResult DeleteConfirmed(string id)  
        {  
            var data = ipatientsRepository.GetPatientSingleRecord(id);  
            if (data == null)  
            {  
                return NotFound();  
            }  
            ipatientsRepository.DeletePatientRecord(id);  
            return Ok();  
        }  
          [HttpGet("{id}")]  
        public Patient Details(string id)  
        {  
            return ipatientsRepository.GetPatientSingleRecord(id);  
        } 
          [HttpGet]  
        public List<Patient> Get()  
        {  
            return ipatientsRepository.GetPatientRecords();  
        }  
  
        
    }
}