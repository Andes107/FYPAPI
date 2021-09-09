using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FYPAPI.Infrastructure.UOWRepositories;
using FYPAPI.Infrastructure.Models;

namespace FYPAPI.Infrastructure.Repositories
{
    public class ImplementedUOW : IUnitOfWork
    {
        private readonly FYPContext _context;
        public ImplementedUOW()
        {
            _context = new FYPContext();
            MapperConfiguration _config = new MapperConfiguration(cfg => cfg.CreateMap<tblCSEStudent, CSEStudent>());
            IMapper _mapper = _config.CreateMapper();
            CSEStudents = new CSEStudentRepository(_context, _config, _mapper);
        }
        public void Dispose() { _context.Dispose(); }
        public ICSEStudent CSEStudents { get; }

        public IFaculty Faculties => throw new NotImplementedException();

        public IFyp Fyps => throw new NotImplementedException();

        public IFYPCategory FYPCategories => throw new NotImplementedException();

        public IInterestedIn InterestedIns => throw new NotImplementedException();

        public IProjectGroup ProjectGroups => throw new NotImplementedException();

        public IRequirementGrade RequirementGrades => throw new NotImplementedException();

        public int Complete()
        {
            throw new NotImplementedException();
        }
    }
}
