using System.Web.Http;
using System.Web.Mvc;
using Data;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

namespace AngularSPAWebAPI
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // e.g. container.RegisterType<ITestService, TestService>();            
            container.RegisterType<IProductRepository, ProductRepository>();

            return container;
        }

        /// <summary>
        /// Service Locator Implementation to allow for ASP.NET WebForms pages (i.e. Reports) 
        /// to workaround constructor injection issues. 
        /// 
        /// The use of this service locator should be very limited to places where true Dependency Injection 
        /// through constructors is not feasible.
        /// </summary>
        /// <typeparam name="T">Type of the Object to be Resolved / Instantiated</typeparam>
        /// <returns>An instatiated object</returns>
        public static T Resolve<T>()
        {
            return DependencyResolver.Current.GetService<T>();
        }
    }
}