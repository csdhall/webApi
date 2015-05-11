using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using _1_Request.Repository;

namespace _1_Request
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            RegisterTypes(container);
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        private static void RegisterTypes(UnityContainer container)
        {
            container.RegisterType<ITrainingRepository, TrainingRepository>();
        }
    }
}