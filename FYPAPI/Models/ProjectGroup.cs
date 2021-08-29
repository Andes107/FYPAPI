using FYPAPI.GenericConverter;
using System;
using System.ComponentModel;

namespace FYPAPI.Models
{
    [TypeConverter(typeof(Converter<ProjectGroup>))]
    public class ProjectGroup: IEquatable<ProjectGroup>
    {
        public int PK_tblProjectGroups { get; set; }
        public string groupCode { get; set; }
        public int? assignedFYP { get; set; }
        public string reader { get; set; }

        public bool Equals(ProjectGroup other)
        {
            return (this.PK_tblProjectGroups == other.PK_tblProjectGroups) &&
                    (this.groupCode == other.groupCode) &&
                    (this.assignedFYP == other.assignedFYP) &&
                    (this.reader == other.reader);
        }
    }
}