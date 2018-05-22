using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Placovu.Erp.IManager;
using Placovu.Erp.IRepository;
using Placovu.Erp.Manager;
using Placovu.Erp.Repository;
using Placovu.Erp.Web.Controllers;
using Placovu.Erp.Web.Models;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.WebApi;

namespace Placovu.Erp.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

           

            container.RegisterType<AccountController>(new InjectionConstructor());           
            container.RegisterType<ManageController>(new InjectionConstructor());    

            container.RegisterType<IBSECompanyRepository, BSECompanyRepository>();
            container.RegisterType<IBSECompanyManager, BSECompanyManager>();            

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}