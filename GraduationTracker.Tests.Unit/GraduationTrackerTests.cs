using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests : TestBase
    {
        [TestMethod]
        public void TestHasCredits()
        {
            var tracker = new GraduationTracker();

            var diploma = _diplomas.GetDiploma(1);

            var students = _students.GetStudents();

            var results = students.ToList().Select(student => tracker.HasGraduated(diploma, student)).ToList();

            var graduated = results.Where(x => x.hasGraduated == true).ToList();

            var notGraduated = results.Where(x => x.hasGraduated == false).ToList();

            Assert.IsTrue(graduated.Any());
        }
    }
}