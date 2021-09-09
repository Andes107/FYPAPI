using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FYPAPI.Infrastructure.Models;

namespace FYPAPI.Infrastructure.UOWRepositories
{
    public interface ICSEStudent : IRepository<CSEStudent> { CSEStudent Get(string PK_tblCSEStudents, string etag, ref string newETag); }
    public interface IFaculty : IRepository<Faculty> { Faculty Get(string PK_tblFaculties, string etag, ref string newETag);}
    public interface IFyp : IRepository<Fyp> { Fyp Get(int PK_tblFyp, string etag, ref string newETag); }
    public interface IFYPCategory : IRepository<FYPCategory> { FYPCategory Get(string PK_tblFypCategories, string etag, ref string newETag); }
    public interface IInterestedIn : IRepository<InterestedIn> { InterestedIn Get(int fypId, int groupId, string etag, ref string newETag); }
    public interface IProjectGroup : IRepository<ProjectGroup> { ProjectGroup Get(int PK_tblProjectGroups, string etag, ref string newETag); }
    public interface IRequirementGrade : IRepository<RequirementGrade> { RequirementGrade Get(string facultyUsername, string studentUsername, string etag, ref string newETag); }
}