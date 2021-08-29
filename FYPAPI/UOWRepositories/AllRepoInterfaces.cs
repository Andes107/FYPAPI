using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FYPAPI.Models;

namespace FYPAPI.UOWRepositories
{
    public interface ICSEStudent : IRepository<CSEStudent> { CSEStudent Get(string PK_tblCSEStudents); }
    public interface IFaculty : IRepository<Faculty> { Faculty Get(string PK_tblFaculties); }
    public interface IFyp : IRepository<Fyp> { Fyp Get(int PK_tblFyp); }
    public interface IFYPCategory : IRepository<FYPCategory> { FYPCategory Get(string PK_tblFypCategories); }
    public interface IInterestedIn : IRepository<InterestedIn> { InterestedIn Get(int fypId, int groupId); }
    public interface IProjectGroup : IRepository<ProjectGroup> { ProjectGroup Get(int PK_tblProjectGroups); }
    public interface IRequirementGrade : IRepository<RequirementGrade> { RequirementGrade Get(string facultyUsername, string studentUsername); }
}