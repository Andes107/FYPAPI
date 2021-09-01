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
    public class testRepository: IClassFixture<repositoryFixture>, IDisposable
    {
        private readonly FYPContext _context;
        private readonly MapperConfiguration _config;
        private readonly IMapper _mapper;
        public testRepository()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<tblCSEStudent, CSEStudent>());
            _mapper = _config.CreateMapper();
            EntityConnection connection = Effort.EntityConnectionFactory.CreatePersistent("name=FYPContext");
            _context = new FYPContext(connection);
            FYPContextInitializer.ContextInit(_context);
        }
        public void Dispose() { _context.Dispose(); }
        [Fact]
        public void testCSEStudentRepositoryGetAll()
        {
            //Arrange
            ICSEStudent csestudentRepo = new CSEStudentRepository(_context, null, _config);
            //Act
            List<CSEStudent> actualListOfStuds = csestudentRepo.GetAll().ToList();
            List<CSEStudent> expectedListOfStuds = _mapper.Map<IEnumerable<tblCSEStudent>, IEnumerable<CSEStudent>>(FYPContextInitializer.studs).ToList();
            //Assert
            Assert.Equal(expectedListOfStuds, actualListOfStuds);
        }
        [Fact]
        public void testCSEStudentRepositorFindMany()
        {
            //Arrange
            ICSEStudent csestudentRepo = new CSEStudentRepository(_context, null, _config);
            CSEStudent mockStud = new CSEStudent() { PK_tblCSEStudents = "brunoho" };
            //Act
            List <CSEStudent> lsitOFStuds = csestudentRepo.FindMany(mockStud).ToList();
            //Assert
            Assert.Equal(1, lsitOFStuds.Count);
        }
    }
}
