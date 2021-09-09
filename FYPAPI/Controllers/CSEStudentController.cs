using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using FYPAPI.BindingAttribute;
using FYPAPI.Infrastructure.Models;
using FYPAPI.Infrastructure.UOWRepositories;

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
        [Route("getone/{PK_tblCSEStudents}")]
        public HttpResponseMessage GetOne(string PK_tblCSEStudents, [IfNoneMatch]string etag)
        {
            string newETag = "";
            CSEStudent stud = _context.CSEStudents.Get(PK_tblCSEStudents, etag, ref newETag);
            if (stud is null) return new HttpResponseMessage(HttpStatusCode.NotFound);
            if (newETag == "") return new HttpResponseMessage(HttpStatusCode.NotModified);
            HttpResponseMessage returnMessage = Request.CreateResponse(HttpStatusCode.OK, stud);
            returnMessage.Headers.ETag = new EntityTagHeaderValue('\"' + newETag + '\"');
            return returnMessage;
        }
    }
}