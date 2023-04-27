using System.Collections.Generic;  
using System.Linq;  
using Microsoft.AspNetCore.Mvc;  
using TestApplication.Models;  
  
namespace TestApplication.Controllers  
{  
    [ApiController]  
    [Route("api/[controller]")]  
    public class DoctorSearchApiController : ControllerBase  
    {  
        // Ejemplo de lista estática de doctores y clínicas  
        private static readonly List<DoctorSearchResult> _doctorsAndClinics = new List<DoctorSearchResult>  
        {  
            new DoctorSearchResult { Name = "Dr. John Smith", City = "New York" },  
            new DoctorSearchResult { Name = "Clinic ABC", City = "Los Angeles" },  
            // Agrega más doctores y clínicas aquí  
        };  
  
        [HttpGet]  
        public ActionResult<IEnumerable<DoctorSearchResult>> Search(string doctorOrClinicName, string city)  
        {  
            var results = _doctorsAndClinics  
                .Where(d => (string.IsNullOrEmpty(doctorOrClinicName) || d.Name.Contains(doctorOrClinicName))  
                         && (string.IsNullOrEmpty(city) || d.City.Contains(city)))  
                .ToList();  
  
            return Ok(results);  
        }  
    }  
}  
