using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourseById(int id);

        IEnumerable<Course> GetCourses(int minMark);
    }

    public class CourseRepository : ICourseRepository
    {
        public IEnumerable<Course> GetCourseById(int id)
        {
            return GetCourses(40).Where(x => x.Id == id);
        }

        // since the courses are all the same, just the mark changes, lets' isolate it here
        public IEnumerable<Course> GetCourses(int minMark)
        {
            return new List<Course>
            {
                new Course{ Id = 1, Name = "Math", Mark = minMark },
                new Course{ Id = 2, Name = "Science", Mark = minMark },
                new Course{ Id = 3, Name = "Literature", Mark = minMark },
                new Course{ Id = 4, Name = "Physichal Education", Mark = minMark }
            };
        }
    }
}