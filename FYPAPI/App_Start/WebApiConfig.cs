using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using Unity;
using FYPAPI.Injection;
using FYPAPI.Infrastructure.UOWRepositories;
using FYPAPI.Infrastructure.Repositories;

namespace FYPAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            JsonSerializerSettings jsonSettings = GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings;
            jsonSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();
            jsonSettings.PreserveReferencesHandling = PreserveReferencesHandling.All;

            XmlMediaTypeFormatter xml = GlobalConfiguration.Configuration.Formatters.XmlFormatter;
            xml.Indent = true;

            /*var container = new UnityContainer();
            container.RegisterType<IUnitOfWork, ImplementedUOW>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);*/
        }
    }
}
