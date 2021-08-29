using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using FYPAPI.BindingAttribute;
using FYPAPI.Models;
using FYPAPI.UOWRepositories;

namespace FYPAPI.Controllers
{
    [RoutePrefix("api/csestudent")]
    public class CSEStudentController: ApiController
    {
        private readonly IUnitOfWork _context;
        public CSEStudentController(IUnitOfWork context) { _context = context; }
        [Route("getmany")]
        public IHttpActionResult GetMany(CSEStudent student) { return Ok(_context.CSEStudents.FindMany(student)); }
        [Route("getone")]
        public HttpResponseMessage GetOne(string PK_tblCSEStudents, [IfNoneMatch]string etag)
        {
            CSEStudent stud = _context.CSEStudents.Get(PK_tblCSEStudents);
        }
    }
}