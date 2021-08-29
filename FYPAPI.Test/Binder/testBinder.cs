using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using Moq;
using FYPAPI.Binder;
using FYPAPI.Models;
using System.Web.Http.Controllers;
/*
    1.  No Http?
        https://stackoverflow.com/a/32194110
 */
using System.Web.Http.Metadata.Providers;
using System.Web.Http.Metadata;
using System.Web.Http.ValueProviders;
using System.Web.Http.ModelBinding;
using System.Globalization;

namespace FYPAPI.Test.Binder
{
    public class testBinder
    {
        [Theory, ClassData(typeof(FYPCategoryForModelBinder))]
        public void testBindModel(string actualExpression, FYPCategory expected)
        {
            //Arrange
            HttpActionContext mockActionContext = new HttpActionContext();

            DataAnnotationsModelMetadataProvider data = new DataAnnotationsModelMetadataProvider();
            ModelMetadata modelMetadata = data.GetMetadataForType(null, typeof(FYPCategory));
            Mock<IValueProvider> mockValueProvider = new Mock<IValueProvider>();
            mockValueProvider.Setup(x => x.GetValue(It.IsAny<string>())).Returns(
                new ValueProviderResult(actualExpression, "", CultureInfo.InvariantCulture)
                );
            ModelBindingContext mockModelBindingcontext = new ModelBindingContext
            {
                ModelName = "category",
                ValueProvider = mockValueProvider.Object,
                ModelMetadata = modelMetadata
            };

            FYPCategoryModelBinder mockBinder = new FYPCategoryModelBinder();
            //Act
            mockBinder.BindModel(mockActionContext, mockModelBindingcontext);
            //Assert
            Assert.Equal(expected, mockModelBindingcontext.Model);
        }

        [Fact]
        public void testSplit()
        {
            //Arrange
            string test = "hello:";
            //Act
            string[] testArray = test.Split(':');
            //Assert
            Assert.Equal("hello", testArray[0]);
            Assert.Equal("", testArray[1]);
        }
    }
}
