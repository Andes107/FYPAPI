using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FYPAPI.UOWRepositories;
using FYPAPI.Models;
using AutoMapper;

namespace FYPAPI.Infrastructure.Repositories
{
    public class CSEStudentRepository : IRepository<CSEStudent>, ICSEStudent
    {
        private readonly FYPContext _context;
        private readonly IMapper _mapper;
        public CSEStudentRepository(FYPContext context, IMapper mapper) 
        { 
            _context = context;
            _mapper = mapper;
        }
        public IEnumerable<CSEStudent> GetAll()
        {
            return _mapper.ProjectTo<CSEStudent>(_context.tblCSEStudents)
                            .ToList();
        }
        public IEnumerable<CSEStudent> FindMany(CSEStudent entity)
        {
            return _mapper.ProjectTo<CSEStudent>(_context.tblCSEStudents
                .Where(x => entity.PK_tblCSEStudents == null || x.PK_tblCSEStudents == entity.PK_tblCSEStudents)
                .Where(x => entity.name == null || x.name == entity.name)
                .Where(x => entity.groupId == null || x.groupId == entity.groupId))
                .ToList();
        }
        public CSEStudent Get(string PK_tblCSEStudents, string etag, ref string newETag)
        {
            tblCSEStudent source = _context.tblCSEStudents
                .Where(x => x.PK_tblCSEStudents == PK_tblCSEStudents)
                .FirstOrDefault();
            if (source.etag == etag)
                return null;
            newETag = source.etag;
            return _mapper.Map<tblCSEStudent, CSEStudent>(source);
        }
    }
}
