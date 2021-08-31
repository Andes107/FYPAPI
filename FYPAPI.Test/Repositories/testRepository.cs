using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FYPAPI.Infrastructure;
using System.Data.Entity.Core.EntityClient;

namespace FYPAPI.Test.Repositories
{
    public class repositoryFixture
    {
        public repositoryFixture()
        {
            Effort.Provider.EffortProviderConfiguration.RegisterProvider();
        }
    }
    public class testRepository: IClassFixture<repositoryFixture>
    {
        [Fact]
        public void testContext()
        {
            EntityConnection connection = Effort.EntityConnectionFactory.CreatePersistent("name=FYPContext");
            FYPContext _context = new FYPContext(connection);
            FYPContextInitializer.ContextInit(_context);
            List<tblFypCategory> students = new List<tblFypCategory>();
            using (_context)
            {
                students = _context.tblFypCategories.ToList();
            }
            Assert.Equal(2, students.Count);
        }
    }
}
