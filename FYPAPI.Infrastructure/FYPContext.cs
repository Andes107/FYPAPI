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
    public partial class tblFaculty
    {
        public tblFaculty(string PK_tblFaculties, string name, string roomNo, string facultyCode)
        {
            this.PK_tblFaculties = PK_tblFaculties;
            this.name = name;
            this.roomNo = roomNo;
            this.facultyCode = facultyCode;
        }
    }
    public partial class tblFyp
    {
        public tblFyp(short PK_tblFyp, string title, string description, string category, 
            string type, string otherRequirement, short minStudents, short maxStudents, 
            bool isAvailable)
        {
            this.PK_tblFyp = PK_tblFyp;
            /*
                1. In the parameter list, I typed PK_tblFYp
                    In the assignment, I used PK_tblFyp
                    As a result, null is initialized
                    Since PK_tblFyp is a primary key, it is not nullable
                    The database complains accordingly
             */
            this.title = title;
            this.description = description;
            this.category = category;
            this.type = type;
            this.otherRequirements = otherRequirement;
            this.minStudents = minStudents;
            this.maxStudents = maxStudents;
            this.isAvailable = isAvailable;
        }
    }
    public partial class tblProjectGroup
    {
        public tblProjectGroup(short PK_tblProjectGroup, string groupCode, short? assignedFYP, string reader)
        {
            this.PK_tblProjectGroups = PK_tblProjectGroup;
            this.groupCode = groupCode;
            this.assignedFYP = assignedFYP;
            this.reader = reader;
        }
    }
    public partial class tblSupervis
    {
        public tblSupervis(string username, short fypId)
        {
            this.username = username;
            this.fypId = fypId;
        }
    }
    public partial class tblRequirementGrade
    {
        public tblRequirementGrade()
        {

        }
        public tblRequirementGrade(string facultyUsername, string studentUsername, 
            decimal? proposalReport, decimal? progressReport, decimal? finalReport,
            decimal? presentation)
        {
            this.facultyUsername = facultyUsername;
            this.studentUsername = studentUsername;
            this.proposalReport = proposalReport;
            this.progressReport = progressReport;
            this.finalReport = finalReport;
            this.presentation = presentation;
        }
    }
    public partial class tblCSEStudent
    {
        public tblCSEStudent(string PK_tblCSEStudents, string name, short? groupId)
        {
            this.PK_tblCSEStudents = PK_tblCSEStudents;
            this.name = name;
            this.groupId = groupId;
        }
    }
    public partial class tblInterestedIn
    {
        public tblInterestedIn(short fypId, short groupId, short priority)
        {
            this.fypId = fypId;
            this.groupId = groupId;
            this.priority = priority;
        }
    }
}
