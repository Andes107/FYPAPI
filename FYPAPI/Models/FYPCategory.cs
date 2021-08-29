using System;

namespace FYPAPI.Models
{
    public class FYPCategory: IEquatable<FYPCategory>
    {
        public string PK_tblFypCategories { get; set; }

        public bool Equals(FYPCategory other)
        {
            return (this.PK_tblFypCategories == other.PK_tblFypCategories);
        }
    }
}