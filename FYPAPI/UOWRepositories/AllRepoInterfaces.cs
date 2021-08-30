using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FYPAPI.Models;

namespace FYPAPI.UOWRepositories
{
    public interface ICSEStudent : IRepository<CSEStudent> { 
        CSEStudent Get(string PK_tblCSEStudents);
        bool NoneMatch(string PK_tblCSEStudents, string etag);
    }
    public interface IFaculty : IRepository<Faculty> { 
        Faculty Get(string PK_tblFaculties);
        bool NoneMatch(string PK_tblFaculties, string etag);
    }
    public interface IFyp : IRepository<Fyp> { 
        Fyp Get(int PK_tblFyp);
        bool NoneMatch(string PK_tblFyp, string etag);
    }
    public interface IFYPCategory : IRepository<FYPCategory> { 
        FYPCategory Get(string PK_tblFypCategories);
        bool NoneMatch(string PK_tblFypCategories, string etag);
    }
    public interface IInterestedIn : IRepository<InterestedIn> { 
        InterestedIn Get(int fypId, int groupId);
        bool NoneMatch(int fypId, int groupId, string etag);
    }
    public interface IProjectGroup : IRepository<ProjectGroup> { 
        ProjectGroup Get(int PK_tblProjectGroups);
        bool NoneMatch(int PK_tblProjectGroups, string etag);
    }
    public interface IRequirementGrade : IRepository<RequirementGrade> { 
        RequirementGrade Get(string facultyUsername, string studentUsername);
        bool NoneMatch(string facutlyUsername, string studentUsername, string etag);
    }
}