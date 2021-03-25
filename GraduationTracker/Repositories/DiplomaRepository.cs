using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker
{
    public interface IDiplomaRepository
    {
        Diploma GetDiploma(int id);

        IEnumerable<Diploma> GetDiplomas();
    }

    public class DiplomaRepository : IDiplomaRepository
    {
        private IRequirementRepository _repo;

        public DiplomaRepository(IRequirementRepository repo)
        {
            _repo = repo;
        }

        public Diploma GetDiploma(int id)
        {
            return GetDiplomas().Where(x => x.Id == id).SingleOrDefault();
        }

        public IEnumerable<Diploma> GetDiplomas()
        {
            return new List<Diploma>
            {
                new Diploma
                {
                    Id = 1,
                    Credits = 4,
                    Requirements = _repo.GetRequirements()
                }
            };
        }
    }
}