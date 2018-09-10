using System.Web.Http;
using System.Web.Mvc;
using Unity;
using WebApp.BusinessLogic;
using WebApp.BusinessLogic.OperationProvider;
using WebApp.Interfaces.Calculator;
using WebApp.Interfaces.OperationProvider;

namespace WebApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

			container.RegisterInstance<IOperationProvider>(new MyDummyOperationProvider());
	        container.RegisterType<ICalculatorService, CalculatorService>();
            
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
			GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
		}
    }
}