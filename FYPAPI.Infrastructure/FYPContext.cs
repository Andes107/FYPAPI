using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPAPI.Infrastructure
{
    public partial class FYPContext
    /*
        1. One partial class inherits from a class, all partial class follow
            https://stackoverflow.com/a/21794425
        2. A special constructor for Effort to inject its in-memory database
            https://stackoverflow.com/q/48064963
     */
    {
        public FYPContext(DbConnection dbConnection): base(dbConnection, contextOwnsConnection: true){}
    }
}
