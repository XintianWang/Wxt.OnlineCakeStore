using Autofac;
using Autofac.Integration.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wxt.OnlineCakeStore.Domain;
using Wxt.OnlineCakeStore.Domain.Concret;

namespace Wxt.OnlineCakeStore.WebApp
{
    //IOC - Inversion of control
    public class IocConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            //builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterControllers(AppDomain.CurrentDomain.GetAssemblies()).PropertiesAutowired();
            // Set the dependency resolver to be Autofac.

            //Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
            //mock.Setup(m => m.Cakes).Returns(new List<Cake>{
            //    new Cake { Name = "Football", Price = 25 },
            //    new Cake { Name = "Surf board", Price = 179 },
            //    new Cake { Name = "Running shoes", Price = 95 }
            //});
            //builder.RegisterInstance<IStoreRepository>(mock.Object).PropertiesAutowired();

            builder.RegisterType<EFDbStoreRepository>().As<IStoreRepository>().PropertiesAutowired();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}