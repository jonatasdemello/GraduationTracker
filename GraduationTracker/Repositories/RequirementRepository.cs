using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker
{
    public interface IRequirementRepository
    {
        Requirement GetRequirement(int id);

        IEnumerable<Requirement> GetRequirements();
    }

    public class RequirementRepository : IRequirementRepository
    {
        private ICourseRepository _repo;

        public RequirementRepository(ICourseRepository repo)
        {
            _repo = repo;
        }

        public Requirement GetRequirement(int id)
        {
            return GetRequirements().Where(x => x.Id == id).SingleOrDefault();
        }

        public IEnumerable<Requirement> GetRequirements()
        {
            return new List<Requirement>
                {
                    new Requirement
                    {
                        Id = 100,
                        Name = "Math",
                        MinimumMark = 50,
                        Courses = _repo.GetCourseById(1),
                        Credits = 1
                    },
                    new Requirement
                    {
                        Id = 102,
                        Name = "Science",
                        MinimumMark = 50,
                        Courses = _repo.GetCourseById(2),
                        Credits = 1
                    },
                    new Requirement
                    {
                        Id = 103,
                        Name = "Literature",
                        MinimumMark = 50,
                        Courses = _repo.GetCourseById(3),
                        Credits = 1
                    },
                    new Requirement
                    {
                        Id = 104,
                        Name = "Physichal Education",
                        MinimumMark = 50,
                        Courses = _repo.GetCourseById(14),
                        Credits = 1
                    }
                };
        }
    }
}