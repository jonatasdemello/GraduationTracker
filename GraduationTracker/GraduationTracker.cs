using GraduationTracker.Models;
using System.Linq;

namespace GraduationTracker
{
    public class GraduationTracker
    {
        private readonly CourseRepository _courses;
        private readonly RequirementRepository _requirements;

        public GraduationTracker()
        {
            // later we can DI here
            _courses = new CourseRepository();
            _requirements = new RequirementRepository(_courses);
        }

        public GraduationStatus HasGraduated(Diploma diploma, Student student)
        {
            var average = CalcAverage(diploma, student);

            var standing = CheckAverage(average);

            return CheckStatus(standing);
        }

        private int CalcAverage(Diploma diploma, Student student)
        {
            var credits = 0;
            var average = 0;

            foreach (var dip in diploma.Requirements)
            {
                foreach (var cur in student.Courses)
                {
                    var requirement = _requirements.GetRequirement(dip.Id);
                    foreach (var rc in requirement.Courses)
                    {
                        if (rc.Id == cur.Id)
                        {
                            average += cur.Mark;
                            if (cur.Mark > requirement.MinimumMark)
                            {
                                credits += requirement.Credits;
                            }
                        }
                    }
                }
            }
            average /= student.Courses.Count();
            return average;
        }

        private static Standing CheckAverage(int average)
        {
            Standing standing = Standing.None;
            if (average < 50)
                standing = Standing.Remedial;
            else if (average < 80)
                standing = Standing.Average;
            else if (average < 95)
                standing = Standing.MagnaCumLaude;
            else
                standing = Standing.SumaCumLaude;
            return standing;
        }

        private static GraduationStatus CheckStatus(Standing standing)
        {
            switch (standing)
            {
                case Standing.Remedial:
                    return new GraduationStatus(false, standing);

                case Standing.Average:
                    return new GraduationStatus(true, standing);

                case Standing.SumaCumLaude:
                    return new GraduationStatus(true, standing);

                case Standing.MagnaCumLaude:
                    return new GraduationStatus(true, standing);

                default:
                    return new GraduationStatus(false, standing);
            }
        }
    }
}