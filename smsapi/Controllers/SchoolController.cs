using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smsapi.Model;
using smsapi.Repositories;

namespace smsapi.Controllers
{
    [Route("api/school")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        public readonly ISchoolRepo _schoolRepo;
        public SchoolController(ISchoolRepo schoolRepo)
        {
            _schoolRepo = schoolRepo;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterSchool(School school)
        {
           int numberOfSchoolsCreated = await _schoolRepo.CreateSchool(school);
           var result = 10 * numberOfSchoolsCreated;
           return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSchools()
        {
            List<School> numberOfSchoolsPresent = await _schoolRepo.GetAllSchools();
            return Ok(numberOfSchoolsPresent);
        }
    }
}
