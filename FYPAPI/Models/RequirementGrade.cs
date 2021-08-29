namespace FYPAPI.Models
{
    public class RequirementGrade
    {
        public string facultyUsername { get; set; }
        public string studentUsername { get; set; }
        public decimal? proposalReport { get; set; }
        public decimal? progressReport { get; set; }
        public decimal? finalReport { get; set; }
        public decimal? presentation { get; set; }
    }
}