using FYPAPI.GenericConverter;
using System;
using System.ComponentModel;

namespace FYPAPI.Models
{
    [TypeConverter(typeof(Converter<RequirementGrade>))]
    public class RequirementGrade: IEquatable<RequirementGrade>
    {
        public string facultyUsername { get; set; }
        public string studentUsername { get; set; }
        public decimal? proposalReport { get; set; }
        public decimal? progressReport { get; set; }
        public decimal? finalReport { get; set; }
        public decimal? presentation { get; set; }

        public bool Equals(RequirementGrade other)
        {
            return (this.facultyUsername == other.facultyUsername) &&
                    (this.studentUsername == other.studentUsername) &&
                    (this.proposalReport == other.proposalReport) &&
                    (this.progressReport == other.progressReport) &&
                    (this.finalReport == other.finalReport) &&
                    (this.presentation == other.presentation);
        }
    }
}