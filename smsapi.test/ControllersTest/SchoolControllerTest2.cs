using Moq;
using smsapi.Controllers;
using smsapi.Model;
using smsapi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smsapi.test.ControllersTest
{
    public class SchoolControllerTest2
    {
        private readonly Mock<ISchoolRepo> _mockSchoolRepo;
        private readonly SchoolController _schoolController;

        public SchoolControllerTest2()
        {
            _mockSchoolRepo = new Mock<ISchoolRepo>();
            _schoolController = new SchoolController(_mockSchoolRepo.Object);
            
        }

        [Fact]
        public void RegisterSchool_ValidInput_Return1()
        {
            //Arrange
            _mockSchoolRepo.Setup(x => x.CreateSchool(It.IsAny<School>())).ReturnsAsync(1);
            School school = new School();
            //Act
            var httpResponse = _schoolController.RegisterSchool(school);
            //Assert
        }

        [Fact]
        public void GetAllSchools_WithListOfSchools()
        {   //Arrange
            List<School> schools = new List<School>();
            School s1 = new School() { Id = 1, Name = "Vivekanada", Place = "Bannur" };
            School s2 = new School() { Id = 2, Name = "Sharada", Place = "Mandya" };
            schools.Add(s1);
            schools.Add(s2);
            _mockSchoolRepo.Setup(x => x.GetAllSchools()).ReturnsAsync(schools);
            //Act
            var httpResponse = _schoolController.GetAllSchools();
            //Assert

        }
    }
}
