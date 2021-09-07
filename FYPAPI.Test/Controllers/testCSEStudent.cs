using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using Moq;
using FYPAPI.UOWRepositories;
using FYPAPI.Models;

namespace FYPAPI.Test.Controllers
{
    public class testCSEStudent
    {
        public delegate void delegateForRefString(string first, string second, ref string input);
        [Fact]
        public void testCSEStudentController()
        {
            //Assert
            Mock<ICSEStudent> mockICSEStud = new Mock<ICSEStudent>();
            mockICSEStud.Setup(call => call.Get(It.IsAny<string>(), It.IsAny<string>(), ref It.Ref<string>.IsAny))
                        .Callback(new delegateForRefString((string first, string second, ref string input) => input = "!"))
                        .Returns((CSEStudent)null);
            Mock<IUnitOfWork> mockIUnit = new Mock<IUnitOfWork>();
            mockIUnit.SetupGet(unit => unit.CSEStudents).Returns(mockICSEStud.Object);
        }
    }
}
