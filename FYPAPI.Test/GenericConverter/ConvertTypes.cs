﻿using System.Collections.Generic;
using FYPAPI.Infrastructure.Models;
using System.Collections;

namespace FYPAPI.Test.GenericConverter
{
    public class listOfCSEStudents : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { "PK_tblCSEStudents:lesterlo;name:Lester Lo;groupId:1",
                new CSEStudent {
                PK_tblCSEStudents = "lesterlo", name = "Lester Lo", groupId = 1
                }},
            new object[] { "name:Lester Lo",
                new CSEStudent {
                name = "Lester Lo"
                }}
        };
        public IEnumerator<object[]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
    public class listOfFaculty : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { "PK_tblFaculties:xavieryu;name:Xavier Yu;roomNo:4962N;facultyCode:XY",
                new Faculty {
                PK_tblFaculties = "xavieryu", name = "Xavier Yu", roomNo = "4962N", facultyCode = "XY"
                }},
            new object[] { "PK_tblFaculties:xavieryu;name:Xavier Yu",
                new Faculty {
                PK_tblFaculties = "xavieryu", name = "Xavier Yu"
                }}
        };
        public IEnumerator<object[]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
}
