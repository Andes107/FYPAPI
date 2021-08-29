using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FYPAPI.Models;
using Xunit;

namespace FYPAPI.Test.Binder
{
    public class testTryParse
    {
        [Theory, ClassData(typeof(listOfFYPCategory))]
        public void test(string queryParameter, FYPCategory expected)
        {
            //Arrange
            FYPCategory actual;

            //Act
            FYPCategory.TryParse(queryParameter, out actual);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
