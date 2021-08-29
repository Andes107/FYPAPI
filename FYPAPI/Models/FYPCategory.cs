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
        public static bool TryParse(string queryParameter, out FYPCategory result)
        {
            result = new FYPCategory();

            if (queryParameter is null) return false;
            
            string[] parts = queryParameter.Split(':');
            if (parts.Length != 2) return false;
            
            result.PK_tblFypCategories = parts[1];
            return true;
        }
    }
}