using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FYPAPI.Models;

namespace FYPAPI.Test.Repositories
{
    public class listOfCSEStudent: IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {
                new CSEStudent {
                    name = "Clint Chu"
                },
                new List<CSEStudent>(){
                    new CSEStudent(){PK_tblCSEStudents = "clintchu", name = "Clint Chu", groupId = 15 }
                }},
            new object[] {
                new CSEStudent{
                    groupId = 8
                },
                new List<CSEStudent>(){
                    new CSEStudent(){PK_tblCSEStudents = "brianma", name = "Brian Ma", groupId = 8},
                    new CSEStudent(){PK_tblCSEStudents = "kathyko", name = "Kathy Ko", groupId = 8 },
                    new CSEStudent(){PK_tblCSEStudents = "monicama",name =  "Monica Ma", groupId = 8},
                    new CSEStudent(){PK_tblCSEStudents = "susansze",name =  "Susan Sze", groupId = 8 }
                }},
            new object[] {
                new CSEStudent(),
                FYPContextInitializer.studs
            }
        };
        public IEnumerator<object[]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
}
