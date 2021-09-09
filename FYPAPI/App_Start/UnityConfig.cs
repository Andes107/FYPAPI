using System.Web.Http;
using Unity;
using Unity.WebApi;
using FYPAPI.Infrastructure.UOWRepositories;
using FYPAPI.Infrastructure.Repositories;
using Unity.Lifetime;

namespace FYPAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents(HttpConfiguration _config)
        {

            UnityContainer container = new UnityContainer();
            container.RegisterType<IUnitOfWork, ImplementedUOW>(new HierarchicalLifetimeManager());

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            _config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}