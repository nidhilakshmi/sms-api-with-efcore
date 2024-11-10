using Moq;
using smsapi.Controllers;
using smsapi.EfCore;
using smsapi.Model;
using smsapi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smsapi.test.ControllersTest
{
    public class SchoolControllerTests
    {
        [Fact]
        public void RegisterSchool_ValidInput_Returns1()
        {
            //Arrange
            Mock<ISchoolRepo> schoolRepoMock = new Mock<ISchoolRepo>();
            schoolRepoMock.Setup(x => x.CreateSchool(It.IsAny<School>())).ReturnsAsync(1);
            SchoolController schoolobj = new SchoolController(schoolRepoMock.Object);
            School school = new School();
            //Act
            var httpResponse = schoolobj.RegisterSchool(school);
           //Assert
        }

        [Fact]

        public void GetAllSchool_ReturnsListOfSchools()
        {
            //Arrange
            List<School> schools = new List<School>();
            School s1 = new School() { Id = 1, Name = "vivekananda", Place = "Bannur" };
            School s2 = new School() { Id = 2, Name = "Abinavabharathi", Place = "Mandya" };
            schools.Add(s1);
            schools.Add(s2);
            Mock<ISchoolRepo> schoolRepoMock = new Mock<ISchoolRepo>();
            schoolRepoMock.Setup(x => x.GetAllSchools()).ReturnsAsync(schools);
            SchoolController schoolobj = new SchoolController(schoolRepoMock.Object);
            //Act
            //Assert
        }
    }
}
