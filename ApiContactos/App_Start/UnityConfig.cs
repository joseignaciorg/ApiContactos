using System.Data.Entity;
using Microsoft.Practices.Unity;
using System.Web.Http;
using ApiContactos.Models;
using ApiContactos.Repositorios;
using Unity.WebApi;

namespace ApiContactos
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<DbContext, RedSocial13_dbEntities>();
            container.RegisterType<UsuarioRepositorio>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}