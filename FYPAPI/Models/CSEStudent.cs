using System;

namespace FYPAPI.Models
{
    public class CSEStudent: IEquatable<CSEStudent>
    {
        public string PK_tblCSEStudents { get; set; }
        public string name { get; set; }
        public int? groupId { get; set; }

        public bool Equals(CSEStudent other)
        {
            return (this.PK_tblCSEStudents == other.PK_tblCSEStudents) &&
                    (this.name == other.name) &&
                    (this.groupId == other.groupId);
        }
    }
}