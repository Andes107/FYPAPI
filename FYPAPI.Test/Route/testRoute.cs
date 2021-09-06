using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using System.Net.Http;
using System.Web.Http;
using FYPAPI.Controllers;

namespace FYPAPI.Test.Route
{
    public class testRoute
    {
        [Theory]
        [InlineData("https://localhost:44359/api/csestudent/getmany?student=name:brunoho")]
        [InlineData("https://localhost:44359/api/csestudent/getmany")]
        public void testGetMany(string requestUrl)
        {
            //Arrange
            HttpConfiguration mockConfig = new HttpConfiguration(); 
            WebApiConfig.Register(mockConfig);
            mockConfig.EnsureInitialized();
            HttpRequestMessage mockRequest = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            testHelper mockTestHelper = new testHelper(mockConfig, mockRequest);
            //Assert
            Assert.Equal(typeof(CSEStudentController), mockTestHelper.GetControllerType());
            Assert.Equal("GetMany", mockTestHelper.GetActionName());
        }
    }
}
