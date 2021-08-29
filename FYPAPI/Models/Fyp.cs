namespace FYPAPI.Models
{
    public class Fyp
    {
        public short PK_tblFyp { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        public string otherRequirements { get; set; }
        public short minStudents { get; set; }
        public short maxStudents { get; set; }
        public bool isAvailable { get; set; }
    }
}