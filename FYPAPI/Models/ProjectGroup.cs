namespace FYPAPI.Models
{
    public class ProjectGroup
    {
        public int PK_tblProjectGroups { get; set; }
        public string groupCode { get; set; }
        public int? assignedFYP { get; set; }
        public string reader { get; set; }
    }
}