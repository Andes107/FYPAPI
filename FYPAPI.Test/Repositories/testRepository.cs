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
using FluentAssertions;

namespace FYPAPI.Test.Repositories
{
    public class repositoryFixture
    {
        public int MyProperty { get; set; }
        public repositoryFixture()
        {
            Effort.Provider.EffortProviderConfiguration.RegisterProvider();
            EntityConnection connection = Effort.EntityConnectionFactory.CreatePersistent("name=FYPContext");
            FYPContext tempContext = new FYPContext(connection);
            FYPContextInitializer.ContextInit(tempContext);
            tempContext.Dispose();
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
        }
        public void Dispose() { _context.Dispose(); }
        [Fact]
        public void testListOrder()
        {
            //Arrange
            //Seems that even they share the same elements, the are still different due to 
            //hashcode
            List<FYPCategory> first = new List<FYPCategory>() {
                new FYPCategory() {PK_tblFypCategories = "AI"},
                new FYPCategory() {PK_tblFypCategories = "DB"}
            };
            List<FYPCategory> second= new List<FYPCategory>() {
                new FYPCategory() {PK_tblFypCategories = "DB"},
                new FYPCategory() {PK_tblFypCategories = "AI"}
            };
            //Assert
            //Assert.Equal(first, second);
            first.Should().BeEquivalentTo(second);
        }
        [Fact]
        public void testCSEStudentRepositoryGetAll()
        {
            //Arrange
            ICSEStudent csestudentRepo = new CSEStudentRepository(_context, null, _config);
            //Act
            IEnumerable<CSEStudent> actual = csestudentRepo.GetAll();
            IEnumerable<CSEStudent> expected = _mapper.Map<IEnumerable<tblCSEStudent>, IEnumerable<CSEStudent>>(FYPContextInitializer.studs);
            //Assert
            actual.Should().BeEquivalentTo(expected);
        }
        [Theory, ClassData(typeof(listOfCSEStudent))]
        public void testCSEStudentRepositorFindMany(CSEStudent condition, List<CSEStudent> expected)
        {
            //Arrange
            ICSEStudent csestudentRepo = new CSEStudentRepository(_context, null, _config);
            //Act
            List <CSEStudent> actual = csestudentRepo.FindMany(condition).ToList();
            //Assert
            actual.Should().BeEquivalentTo(expected);
        }
        [Theory, ClassData(typeof(CSEStudentSingleton))]
        public void testCSEStudentRepositoryGet(string PK_tblCSEStudents, string etag, string newETag, CSEStudent expected, string expectedTag)
        {
            //Arrange
            ICSEStudent csestudentRepo = new CSEStudentRepository(_context, _mapper, _config);
            //Act
            CSEStudent actual = csestudentRepo.Get(PK_tblCSEStudents, etag, ref newETag);
            //Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expectedTag, newETag);
        }
    }
}
