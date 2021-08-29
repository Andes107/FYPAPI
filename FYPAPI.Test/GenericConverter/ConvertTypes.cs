using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using FYPAPI.Models;
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
}
