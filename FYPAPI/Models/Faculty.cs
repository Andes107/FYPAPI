﻿using System;

namespace FYPAPI.Models
{
    public class Faculty: IEquatable<Faculty>
    {
        public string PK_tblFaculties { get; set; }
        public string name { get; set; }
        public string roomNo { get; set; }
        public string facultyCode { get; set; }

        public bool Equals(Faculty other)
        {
            return (this.PK_tblFaculties == other.PK_tblFaculties) &&
                    (this.name == other.name) &&
                    (this.roomNo == other.roomNo) &&
                    (this.facultyCode == other.facultyCode);
        }
    }
}