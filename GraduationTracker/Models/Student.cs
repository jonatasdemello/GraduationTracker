using System.Collections.Generic;

namespace GraduationTracker
{
    public class Student
    {
        public int Id { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public Standing Standing { get; set; } = Standing.None;
    }
}