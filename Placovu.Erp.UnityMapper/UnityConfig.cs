
using Placovu.Erp.IManager;
using Placovu.Erp.IRepository;
using Placovu.Erp.Manager;
using Placovu.Erp.Repository;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.WebApi;

namespace Placovu.Erp.UnityMapper
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
   
            container.RegisterType<IBSECompanyRepository, BSECompanyRepository>();
            container.RegisterType<IBSECompanyManager, BSECompanyManager>();            

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}