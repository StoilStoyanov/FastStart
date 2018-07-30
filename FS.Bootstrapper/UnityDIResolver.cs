using FS.Services;
using FS.Services.Interfaces;
using Unity;
using System.Web.Mvc;
using Unity.AspNet.Mvc;
using System.Web.Http;

namespace FS.Bootstrapper
{
    public static class UnityDIResolver
    {
        public static void Initialize()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        }

        private static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IItemService, ItemService>();
        }
    }
}
