using System.Collections.Generic;

namespace GraduationTracker
{
    public class Diploma
    {
        public int Id { get; set; }
        public int Credits { get; set; }
        public IEnumerable<Requirement> Requirements { get; set; }
    }
}