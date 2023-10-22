using Autofac;
using Autofac.Integration.Mvc;
using OdeToFood.Business.Repositories;
using OdeToFood.Business.Services;
using OdeToFood.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Generator;

namespace OdeToFood.Web
{
    public class ContainerConfig
    {
        public static void RegisterContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<RestaurantRepository>()
                   .As<IResturantRepository>()
                   .InstancePerRequest();

            builder.RegisterType<OdeToFoodDbContext>()
                   .As<OdeToFoodDbContext>()
                   .InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}