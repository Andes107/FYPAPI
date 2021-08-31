using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FYPAPI.UOWRepositories;
using FYPAPI.Infrastructure;
using FYPAPI.Infrastructure.Repositories;
using System.Data.Entity.Core.EntityClient;
using AutoMapper;
using FYPAPI.Models;

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
        private readonly FYPContext _context;
        private readonly MapperConfiguration _config;

        public testRepository()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<tblCSEStudent, CSEStudent>());
            EntityConnection connection = Effort.EntityConnectionFactory.CreatePersistent("name=FYPContext");
            _context = new FYPContext(connection);
            FYPContextInitializer.ContextInit(_context);
        }
        [Fact]
        public void testContext()
        {
            List<tblFypCategory> students = new List<tblFypCategory>();
            using (_context)
            {
                students = _context.tblFypCategories.ToList();
            }
            Assert.Equal(15, students.Count);
        }
        [Fact]
        public void testCSEStudentRepository()
        {
            //Arrange
            ICSEStudent csestudentRepo = new CSEStudentRepository(_context, null, _config);
            //Act
            List<CSEStudent> lsitOFStuds = csestudentRepo.GetAll().ToList();
            //Assert
            Assert.Equal(40, lsitOFStuds.Count);
        }
    }
}
