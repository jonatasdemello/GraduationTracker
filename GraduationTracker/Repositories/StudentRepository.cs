using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker
{
    public interface IStudentRepository
    {
        Student GetStudent(int id);

        IEnumerable<Student> GetStudents();
    }

    public class StudentRepository : IStudentRepository
    {
        private ICourseRepository _repo;

        public StudentRepository(ICourseRepository repo)
        {
            _repo = repo;
        }

        public Student GetStudent(int id)
        {
            return GetStudents().Where(x => x.Id == id).SingleOrDefault();
        }

        public IEnumerable<Student> GetStudents()
        {
            return new List<Student>
            {
               new Student
               {
                   Id = 1,
                   Courses = _repo.GetCourses(95)
               },
               new Student
               {
                   Id = 2,
                   Courses = _repo.GetCourses(80)
               },
                new Student
                {
                    Id = 3,
                    Courses = _repo.GetCourses(50)
                },
                new Student
                {
                    Id = 4,
                    Courses = _repo.GetCourses(40)
                }
            };
        }
    }
}