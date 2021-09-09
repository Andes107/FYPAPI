using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FYPAPI.Infrastructure.UOWRepositories;
using FYPAPI.Infrastructure.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace FYPAPI.Infrastructure.Repositories
{
    public class CSEStudentRepository : ICSEStudent
    {
        private readonly FYPContext _context;
        private readonly MapperConfiguration _config;
        private readonly IMapper _mapper;
        public CSEStudentRepository(FYPContext context, MapperConfiguration config, IMapper mapper) 
        { 
            _context = context;
            _config = config;
            _mapper = mapper;
        }
        public IEnumerable<CSEStudent> GetAll()
        {
            return _context.tblCSEStudents.ProjectTo<CSEStudent>(_config).ToList();
        }
        public IEnumerable<CSEStudent> FindMany(CSEStudent entity)
        {
            return _context.tblCSEStudents
                .Where(x => entity.PK_tblCSEStudents == null || x.PK_tblCSEStudents == entity.PK_tblCSEStudents)
                .Where(x => entity.name == null || x.name == entity.name)
                .Where(x => entity.groupId == null || x.groupId == entity.groupId)
                .ProjectTo<CSEStudent>(_config).ToList();
        }
        public CSEStudent Get(string PK_tblCSEStudents, string etag, ref string newETag)
        {
            if (PK_tblCSEStudents is null) return null;
            tblCSEStudent source = _context.tblCSEStudents
                .Where(x => x.PK_tblCSEStudents == PK_tblCSEStudents)
                .FirstOrDefault();
            if (source is null) return null;

            if (string.IsNullOrEmpty(etag) || source.etag != etag) newETag = source.etag;
            return _mapper.Map<tblCSEStudent, CSEStudent>(source);
        }
    }
}
