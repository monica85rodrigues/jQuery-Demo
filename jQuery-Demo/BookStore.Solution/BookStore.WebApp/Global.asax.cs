using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using BookStore.Model;
using BookStore.Model.Repositories;
using BookStore.Model.ServicesImplementation;
using BookStore.WebApp.Controllers;

namespace BookStore.WebApp
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            /*
               Resolução de dependências
             -----------------------------------------------------------------------------
               NOTA: Este código não deveria estar aqui, deve ser feito num assembly à parte.
               Mas por agora dá geito.
             -------------------------------------------------------------------------------
             */
            var builder = new ContainerBuilder();
            //register types
            builder.RegisterType<BooksService>().As<IBooksService>().InstancePerHttpRequest();
            builder.RegisterType<MemoryBookRepository>().As<IBooksRepository>().InstancePerHttpRequest();
            builder.RegisterType<BooksController>().InstancePerHttpRequest();
            builder.RegisterType<TemplatingController>().InstancePerHttpRequest();
            builder.RegisterType<ChartingController>().InstancePerHttpRequest();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
           
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}