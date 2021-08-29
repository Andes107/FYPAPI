using System;
using Xunit;
using Moq;
using FYPAPI.Models;
using FYPAPI.GenericConverter;
using System.ComponentModel;

namespace FYPAPI.Test.GenericConverter
{
    public class testConverter
    {
        [Theory]
        [InlineData(typeof(string), true)]
        [InlineData(typeof(int), false)]
        public void testCanConvertFrom(Type sourceType, bool expected)
        {
            //Arrange
            Type randomType = typeof(CSEStudent);
            Type typeGenericConverter = typeof(Converter<>);
            Type typeActualConverter = typeGenericConverter.MakeGenericType(randomType);

            dynamic testConverter = Activator.CreateInstance(typeActualConverter);
            Mock<ITypeDescriptorContext> mockDescContext = new Mock<ITypeDescriptorContext>();
            //Act
            bool actual = testConverter.CanConvertFrom(mockDescContext.Object, sourceType);
            
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory, ClassData(typeof(listOfCSEStudents))]
        public void testConverFromCSEStudents(object value, CSEStudent expected)
        {
            //Arrange
            Converter<CSEStudent> testConverter = new Converter<CSEStudent>();
            Mock<ITypeDescriptorContext> mockDescContext = new Mock<ITypeDescriptorContext>();
            //Act
            CSEStudent actual = testConverter.ConvertFrom(mockDescContext.Object, null, value) as CSEStudent;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory, ClassData(typeof(listOfFaculty))]
        public void testConverFromFaculty(object value, Faculty expected)
        {
            //Arrange
            Converter<Faculty> testConverter = new Converter<Faculty>();
            Mock<ITypeDescriptorContext> mockDescContext = new Mock<ITypeDescriptorContext>();
            //Act
            Faculty actual = testConverter.ConvertFrom(mockDescContext.Object, null, value) as Faculty;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
