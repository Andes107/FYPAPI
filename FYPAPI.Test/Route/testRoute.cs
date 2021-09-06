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
        public void testGetManyRight(string requestUrl)
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
        [Theory]
        [InlineData("https://localhost:44359/api/csestudent/getmany")]
        public void testGetManyWrong(string requestUrl)
        {
            //Arrange
            HttpConfiguration mockConfig = new HttpConfiguration();
            WebApiConfig.Register(mockConfig);
            mockConfig.EnsureInitialized();
            HttpRequestMessage mockRequest = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            testHelper mockTestHelper = new testHelper(mockConfig, mockRequest);
            //Assert
            Assert.Equal(typeof(CSEStudentController), mockTestHelper.GetControllerType());
            Exception exception = Record.Exception(() => mockTestHelper.GetActionName());
            Assert.NotNull(exception);
        }
        [Theory]
        [InlineData("https://localhost:44359/api/csestudent/getone/1")]
        public void testGetOneCorrect(string requestUrl)
        {
            //Arrange
            HttpConfiguration mockConfig = new HttpConfiguration();
            WebApiConfig.Register(mockConfig);
            mockConfig.EnsureInitialized();
            HttpRequestMessage mockRequest = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            testHelper mockTestHelper = new testHelper(mockConfig, mockRequest);
            //Assert
            Assert.Equal(typeof(CSEStudentController), mockTestHelper.GetControllerType());
            Assert.Equal("GetOne", mockTestHelper.GetActionName());
        }
        [Theory]
        [InlineData("https://localhost:44359/api/csestudent/getone")]
        public void testGetOneWrong(string requestUrl)
        {
            //Arrange
            HttpConfiguration mockConfig = new HttpConfiguration();
            WebApiConfig.Register(mockConfig);
            mockConfig.EnsureInitialized();
            HttpRequestMessage mockRequest = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            testHelper mockTestHelper = new testHelper(mockConfig, mockRequest);
            //Assert
            Assert.Equal(typeof(CSEStudentController), mockTestHelper.GetControllerType());
            Exception exception = Record.Exception(() => mockTestHelper.GetActionName());
            Assert.NotNull(exception);
        }
    }
}
