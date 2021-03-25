using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace GraduationTracker.Tests.Unit
{
    [TestClass()]
    public class RepositoryTests : TestBase
    {
        [TestMethod()]
        public void GetStudentTest()
        {
            var student = _students.GetStudent(1);

            Assert.IsTrue(student.Id == 1);
        }

        [TestMethod()]
        public void GetInvalidStudentTest()
        {
            var student = _students.GetStudent(1000);

            Assert.IsNull(student);
        }

        [TestMethod()]
        public void GetStudentsTest()
        {
            var students = _students.GetStudents();

            Assert.IsTrue(students.Count() == 4);
        }

        [TestMethod()]
        public void GetDiplomaTest()
        {
            var diploma = _diplomas.GetDiploma(1);

            Assert.IsTrue(diploma.Id == 1);
        }

        [TestMethod()]
        public void GetInvalidDiplomaTest()
        {
            var diploma = _diplomas.GetDiploma(1000);

            Assert.IsNull(diploma);
        }

        [TestMethod()]
        public void GetDiplomasTest()
        {
            var diplomas = _diplomas.GetDiplomas();

            Assert.IsTrue(diplomas.Count() == 1);
        }

        [TestMethod()]
        public void GetRequirementTest()
        {
            var requirement = _requirements.GetRequirement(100);

            Assert.IsTrue(requirement.Id == 100);
        }

        [TestMethod()]
        public void GetInvalidRequirementTest()
        {
            var requirement = _requirements.GetRequirement(1000);

            Assert.IsNull(requirement);
        }

        [TestMethod()]
        public void GetRequirementsTest()
        {
            var requirements = _requirements.GetRequirements();

            Assert.IsTrue(requirements.Count() == 4);
        }
    }
}