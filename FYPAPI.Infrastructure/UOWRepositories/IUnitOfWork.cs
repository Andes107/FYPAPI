using System;

namespace FYPAPI.Infrastructure.UOWRepositories
{
    public interface IUnitOfWork: IDisposable
    {
        ICSEStudent CSEStudents { get; }
        IFaculty Faculties { get; }
        IFyp Fyps { get; }
        IFYPCategory FYPCategories { get; }
        IInterestedIn InterestedIns { get; }
        IProjectGroup ProjectGroups { get; }
        IRequirementGrade RequirementGrades { get; }
        int Complete();
    }
}