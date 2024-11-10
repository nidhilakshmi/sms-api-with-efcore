using smsapi.Model;

namespace smsapi.Repositories
{
    public interface ISchoolRepo
    {
        Task<int> CreateSchool(School school);
        Task<List<School>> GetAllSchools();
    }
}
