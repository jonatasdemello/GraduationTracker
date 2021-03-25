namespace GraduationTracker.Tests.Unit
{
    public class TestBase
    {
        public CourseRepository _courses;
        public RequirementRepository _requirements;
        public DiplomaRepository _diplomas;
        public StudentRepository _students;

        public TestBase()
        {
            _courses = new CourseRepository();
            _requirements = new RequirementRepository(_courses);
            _diplomas = new DiplomaRepository(_requirements);
            _students = new StudentRepository(_courses);
        }
    }
}