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
                    new CSEStudent(){PK_tblCSEStudents = "monicama",name = "Monica Ma", groupId = 8},
                    new CSEStudent(){PK_tblCSEStudents = "susansze",name = "Susan Sze", groupId = 8 }
                }},
            new object[] {
                new CSEStudent(),
                new List<CSEStudent>()
                {
                    new CSEStudent(){ PK_tblCSEStudents = "brunoho"     ,name =  "Bruno Ho"    ,groupId =  1 },
                    new CSEStudent(){ PK_tblCSEStudents = "daisyyeung"  ,name =  "Daisy Yeung" ,groupId =  2},
                    new CSEStudent(){ PK_tblCSEStudents = "adamau"      ,name =  "Adam Au"     ,groupId =  3},
                    new CSEStudent(){ PK_tblCSEStudents = "lesterlo"    ,name =  "Lester Lo"   ,groupId =  4},
                    new CSEStudent(){ PK_tblCSEStudents = "shirleysit"  ,name =  "Shirley Sit" ,groupId =  5},
                    new CSEStudent(){ PK_tblCSEStudents = "frankfung"   ,name =  "Frank Fung"  ,groupId =  6},
                    new CSEStudent(){ PK_tblCSEStudents = "larrylai"    ,name =  "Larry Lai"   ,groupId =  6},
                    new CSEStudent(){ PK_tblCSEStudents = "fredfan"     ,name =  "Fred Fan"    ,groupId =  7},
                    new CSEStudent(){ PK_tblCSEStudents = "jennyjones"  ,name =  "Jenny Jones" ,groupId =  7},
                    new CSEStudent(){ PK_tblCSEStudents = "timothytu"   ,name =  "Timothy Tu"  ,groupId =  7},
                    new CSEStudent(){ PK_tblCSEStudents = "brianma"     ,name =  "Brian Ma"    ,groupId =  8},
                    new CSEStudent(){ PK_tblCSEStudents = "kathyko"     ,name =  "Kathy Ko"    ,groupId =  8},
                    new CSEStudent(){ PK_tblCSEStudents = "monicama"    ,name =  "Monica Ma"   ,groupId =  8},
                    new CSEStudent(){ PK_tblCSEStudents = "susansze"    ,name =  "Susan Sze"   ,groupId =  8},
                    new CSEStudent(){ PK_tblCSEStudents = "terrytam"    ,name =  "Terry Tam"   ,groupId =  9},
                    new CSEStudent(){ PK_tblCSEStudents = "sharonsu"    ,name =  "Sharon Su"   ,groupId =  10 },
                    new CSEStudent(){ PK_tblCSEStudents = "wendywong"   ,name =  "Wendy Wong"  ,groupId =  11},
                    new CSEStudent(){ PK_tblCSEStudents = "ireneip"     ,name =  "Irene Ip"    ,groupId =  12},
                    new CSEStudent(){ PK_tblCSEStudents = "peterpoon"   ,name =  "Peter Poon"  ,groupId =  12},
                    new CSEStudent(){ PK_tblCSEStudents = "tiffanytan"  ,name =  "Tiffany Tan" ,groupId =  13},
                    new CSEStudent(){ PK_tblCSEStudents = "victoriayu"  ,name =  "Victoria Yu" ,groupId =  13},
                    new CSEStudent(){ PK_tblCSEStudents = "dannydoan"   ,name =  "Danny Doan"  ,groupId =  13},
                    new CSEStudent(){ PK_tblCSEStudents = "carolchen"   ,name =  "Carol Chen"  ,groupId =  14},
                    new CSEStudent(){ PK_tblCSEStudents = "cindychan"   ,name =  "Cindy Chan"  ,groupId =  14},
                    new CSEStudent(){ PK_tblCSEStudents = "tracytse"    ,name =  "Tracy Tse"   ,groupId =  14},
                    new CSEStudent(){ PK_tblCSEStudents = "yvonneyu"    ,name =  "Yvonne Yu"   ,groupId =  14},
                    new CSEStudent(){ PK_tblCSEStudents = "clintchu"    ,name =  "Clint Chu"   ,groupId =  15},
                    new CSEStudent(){ PK_tblCSEStudents = "amandahui"   ,name =  "Amanda Hui"  ,groupId =  15},
                    new CSEStudent(){ PK_tblCSEStudents = "henryho"     ,name =  "Henry Ho"    ,groupId =  16},
                    new CSEStudent(){ PK_tblCSEStudents = "tonytong"    ,name =  "Tony Tong"   ,groupId =  16},
                    new CSEStudent(){ PK_tblCSEStudents = "walterwu"    ,name =  "Walter Wu"   ,groupId =  16},
                    new CSEStudent(){ PK_tblCSEStudents = "xavierxie"   ,name =  "Xavier Xie"  ,groupId =  16},
                    new CSEStudent(){ PK_tblCSEStudents = "steviesu"    ,name =  "Stevie Su"   ,groupId =  null},
                    new CSEStudent(){ PK_tblCSEStudents = "rezanlim"    ,name =  "Rezan Lim"   ,groupId =  null},
                    new CSEStudent(){ PK_tblCSEStudents = "bradybond"   ,name =  "Brady Bond"  ,groupId =  null},
                    new CSEStudent(){ PK_tblCSEStudents = "vivianso"    ,name =  "Vivian So"   ,groupId =  null},
                    new CSEStudent(){ PK_tblCSEStudents = "alanseto"    ,name =  "Alan Seto"   ,groupId =  null},
                    new CSEStudent(){ PK_tblCSEStudents = "lucylam"     ,name =  "Lucy Lam"    ,groupId =  null},
                    new CSEStudent(){ PK_tblCSEStudents = "hughhawes"   ,name =  "Hugh Hawes"  ,groupId =  null},
                    new CSEStudent(){ PK_tblCSEStudents = "carlchan"    ,name =  "Carl Chan"   ,groupId =  null}
                }}
        };
        public IEnumerator<object[]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
    public class CSEStudentSingleton: IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {
                null, "20121231230023", "", null, ""
            },
            new object[] {
                "does-not-exist", "", null, null, null
            },
            new object[] {
                "brunoho", "", "",
                new CSEStudent(){ PK_tblCSEStudents = "brunoho"     ,name =  "Bruno Ho"    ,groupId =  1 },
                "20121231210032"
            },
            new object[] {
                "brunoho", null, "",
                new CSEStudent(){ PK_tblCSEStudents = "brunoho"     ,name =  "Bruno Ho"    ,groupId =  1 },
                "20121231210032"
            },
            new object[] {
                "brunoho", "wrong-etag", "",
                new CSEStudent(){ PK_tblCSEStudents = "brunoho"     ,name =  "Bruno Ho"    ,groupId =  1 },
                "20121231210032"
            },
            new object[] {
                "brunoho", "20121231210032", "", 
                new CSEStudent(){ PK_tblCSEStudents = "brunoho"     ,name =  "Bruno Ho"    ,groupId =  1 },
                ""
            }
        };
        public IEnumerator<object[]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
}
