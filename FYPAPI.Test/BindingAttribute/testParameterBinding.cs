using System;
using Moq;
using Xunit;
using FYPAPI;
using FYPAPI.Models;
using System.Web.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http.Controllers;
using System.Threading;
using FYPAPI.BindingAttribute;

namespace FYPAPI.Test.BindingAttribute
{
    public class testParameterBinding
    {
        [Theory]
        [InlineData("\"20201231094523\"")]
        //[InlineData(null, false)]
        public void testHasETag(string etagValue)
        {
            string parameterName = "etag";
            //Arrange
            HttpRequestMessage mockRequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44308/api/etag/1");
            mockRequestMessage.Headers.IfNoneMatch.Add(new EntityTagHeaderValue(etagValue));

            HttpActionContext mockHttpActionContext = new HttpActionContext
            {
                ControllerContext = new HttpControllerContext
                {
                    Request = mockRequestMessage
                }
            };

            Mock<HttpParameterDescriptor> mockParameterDescriptor = new Mock<HttpParameterDescriptor>();
            mockParameterDescriptor.SetupGet(i => i.ParameterName).Returns(parameterName);

            ETagParameterBinding etagParameterBinding = new ETagParameterBinding(mockParameterDescriptor.Object);

            //Act
            etagParameterBinding.ExecuteBindingAsync(null, mockHttpActionContext, new CancellationTokenSource().Token).Wait();

            //Assert
            Assert.Equal(etagValue, mockHttpActionContext.ActionArguments[parameterName]);
            /*Exception exception = Record.Exception(() => mockHttpActionContext.ActionArguments[parameterName]);
            Assert.NotNull(exception);*/
        }
        [Theory]
        [InlineData(null)]
        public void testNoETag(string etagValue)
        {
            string parameterName = "etag";
            //Arrange
            HttpRequestMessage mockRequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44308/api/etag/1");

            HttpActionContext mockHttpActionContext = new HttpActionContext
            {
                ControllerContext = new HttpControllerContext
                {
                    Request = mockRequestMessage
                }
            };

            Mock<HttpParameterDescriptor> mockParameterDescriptor = new Mock<HttpParameterDescriptor>();
            mockParameterDescriptor.SetupGet(i => i.ParameterName).Returns(parameterName);

            ETagParameterBinding etagParameterBinding = new ETagParameterBinding(mockParameterDescriptor.Object);

            //Act
            etagParameterBinding.ExecuteBindingAsync(null, mockHttpActionContext, new CancellationTokenSource().Token).Wait();

            //Assert
            Exception exception = Record.Exception(() => mockHttpActionContext.ActionArguments[parameterName]);
            Assert.NotNull(exception);
        }
    }
}
