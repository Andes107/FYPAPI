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
    public class testRepository: IClassFixture<repositoryFixture>
    {
        public testRepository() { EffortProviderFactory.ResetDb(); }

        [Fact]
        public void testContext()
        {
            EntityConnection connection = Effort.EntityConnectionFactory.CreatePersistent("name=FYPContext");
            FYPContext _context = new FYPContext(connection);
            List<tblFypCategory> students = new List<tblFypCategory>();
            using (_context)
            {
                _context.tblFypCategories.Add(new tblFypCategory()
                {
                    PK_tblFypCategories = "AI"
                });
                _context.SaveChanges();
                students = _context.tblFypCategories.ToList();
            }
            Assert.Equal(2, students.Count);
        }
    }
}
