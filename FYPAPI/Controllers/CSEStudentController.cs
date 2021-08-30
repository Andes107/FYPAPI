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
        [HttpGet]
        [Route("getmany")]
        public IHttpActionResult GetMany(CSEStudent student) { return Ok(_context.CSEStudents.FindMany(student)); }
        [HttpGet]
        [Route("getone")]
        public HttpResponseMessage GetOne(string PK_tblCSEStudents, [IfNoneMatch]string etag)
        {
            if (_context.CSEStudents.NoneMatch(PK_tblCSEStudents, etag))
                return Request.CreateResponse(HttpStatusCode.NotModified,_context.CSEStudents.Get(PK_tblCSEStudents));
            return new HttpResponseMessage(HttpStatusCode.NotModified);
        }
    }
}