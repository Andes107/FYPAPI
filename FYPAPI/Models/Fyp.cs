using System;

namespace FYPAPI.Models
{
    public class Fyp: IEquatable<Fyp>
    {
        public int PK_tblFyp { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        public string otherRequirements { get; set; }
        public int minStudents { get; set; }
        public int maxStudents { get; set; }
        public bool isAvailable { get; set; }

        public bool Equals(Fyp other)
        {
            return (this.PK_tblFyp == other.PK_tblFyp) &&
                    (this.title == other.title) &&
                    (this.description == other.description) &&
                    (this.category == this.type) &&
                    (this.type == other.type) &&
                    (this.otherRequirements == other.otherRequirements) &&
                    (this.minStudents == other.minStudents) &&
                    (this.maxStudents == other.maxStudents) &&
                    (this.isAvailable == other.isAvailable);
        }
    }
}