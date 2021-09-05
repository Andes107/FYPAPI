using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FYPAPI.Models;

namespace FYPAPI.Test.Repositories
{
    public class lsitOfCSEStudent: IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {
                new CSEStudent {

                }},
            new object[] {
                new CSEStudent{
                    groupId = 3
                }}
        };
        public IEnumerator<object[]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
}
