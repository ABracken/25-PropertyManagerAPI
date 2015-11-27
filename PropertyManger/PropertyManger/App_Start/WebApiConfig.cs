using AutoMapper;
using Newtonsoft.Json.Serialization;
using PropertyManager.Core.Domain;
using PropertyManger.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PropertyManger
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var cors = new EnableCorsAttribute(
            origins: "*",
            headers: "*",
            methods: "*");
            config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            SetupAutomapper();
        }
        private static void SetupAutomapper()
        {
            Mapper.CreateMap<Property, PropertyModel>();
            Mapper.CreateMap<Tenant, TenantModel>();
            Mapper.CreateMap<Lease, LeaseModel>();
        }
    }
}
