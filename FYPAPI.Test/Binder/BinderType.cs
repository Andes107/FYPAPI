using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using FYPAPI.Infrastructure.Models;

namespace FYPAPI.Test.Binder
{
    public class listOfFYPCategory : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { "PK_tblFypCategories:Computer Games",
                new FYPCategory {
                    PK_tblFypCategories = "Computer Games"
                }},
            new object[] { "PK_tblFypCategories:does not exists",
                new FYPCategory{
                    PK_tblFypCategories = "does not exists"
                }},
            new object[] { "PK_tblFypCategories:",
                new FYPCategory{
                    PK_tblFypCategories = ""
                }},
            new object[] { "notpk:heh",
                new FYPCategory{
                }},
            new object[]{ "", 
                new FYPCategory()
                },
            new object[]{ null,
                new FYPCategory()
                }
        };
        public IEnumerator<object[]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
    public class FYPCategoryForModelBinder : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { "PK_tblFypCategories:Computer Games",
                new FYPCategory {
                    PK_tblFypCategories = "Computer Games"
                }},
            new object[] { "PK_tblFypCategories:does not exists",
                new FYPCategory()
                },
            new object[] { "PK_tblFypCategories:",
                new FYPCategory()
                },
            new object[] { "notpk:heh",
                new FYPCategory{
                }},
            new object[]{ "",
                new FYPCategory()
                },
            new object[]{ null, null
                }
        };
        public IEnumerator<object[]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
}
