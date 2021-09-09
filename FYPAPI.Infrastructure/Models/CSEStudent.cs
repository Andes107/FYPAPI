using System;
using System.ComponentModel;
using FYPAPI.Infrastructure.GenericConverter;

namespace FYPAPI.Infrastructure.Models
{
    [TypeConverter(typeof(Converter<CSEStudent>))]
    public class CSEStudent: IEquatable<CSEStudent>
    {
        public string PK_tblCSEStudents { get; set; }
        public string name { get; set; }
        public short? groupId { get; set; }

        public bool Equals(CSEStudent other)
        {
            return (this.PK_tblCSEStudents == other.PK_tblCSEStudents) &&
                    (this.name == other.name) &&
                    (this.groupId == other.groupId);
        }
    }
}