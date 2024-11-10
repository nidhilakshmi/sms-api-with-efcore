using Microsoft.EntityFrameworkCore;
using smsapi.EfCore;
using smsapi.Model;

namespace smsapi.Repositories
{
    public class SchoolRepo : ISchoolRepo
    {
        private readonly SMSDBContext _smsDbContext;
        public SchoolRepo(SMSDBContext sMSDBContext)
        {
            _smsDbContext = sMSDBContext;
        }
        public async Task<int> CreateSchool(School school)
        {
           _smsDbContext.Schools.Add(school);
            return await _smsDbContext.SaveChangesAsync();
        }

        public async Task<List<School>> GetAllSchools()
        {
           return await _smsDbContext.Schools.ToListAsync();
        }
    }
}
