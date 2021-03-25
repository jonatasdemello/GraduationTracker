namespace GraduationTracker.Models
{
    public class GraduationStatus
    {
        public bool hasGraduated { get; set; }
        public Standing standing { get; set; }

        public GraduationStatus(bool _hasGraduated, Standing _standing)
        {
            hasGraduated = _hasGraduated;
            standing = _standing;
        }
    }
}