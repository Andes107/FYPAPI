using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using Moq;
using FYPAPI.UOWRepositories;
using FYPAPI.Models;
using FYPAPI.Controllers;
using System.Web.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;

namespace FYPAPI.Test.Controllers
{
    public class testCSEStudent
    {
        public delegate void nullString(string first, string second, ref string input);
        
        [Theory]
        [InlineData("\"random\"")]
        public void test404(string etagValue)
        {
            //Assert
            Mock<ICSEStudent> mockICSEStud = new Mock<ICSEStudent>();
            mockICSEStud.Setup(call => call.Get(It.IsAny<string>(), It.IsAny<string>(), ref It.Ref<string>.IsAny))
                        .Callback(new nullString((string first, string second, ref string input) => input = "!"))
                        .Returns((CSEStudent)null);
            Mock<IUnitOfWork> mockIUnit = new Mock<IUnitOfWork>();
            mockIUnit.SetupGet(unit => unit.CSEStudents).Returns(mockICSEStud.Object);

            CSEStudentController mockController = new CSEStudentController(mockIUnit.Object);
            mockController.Configuration = new HttpConfiguration();
            WebApiConfig.Register(mockController.Configuration);
            mockController.Configuration.EnsureInitialized();

            mockController.Request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44359/api/csestudent/getone/1");
            mockController.Request.Headers.IfNoneMatch.Add(new EntityTagHeaderValue(etagValue));

            //Act
            HttpResponseMessage response = mockController.GetOne("", etagValue);

            //Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
