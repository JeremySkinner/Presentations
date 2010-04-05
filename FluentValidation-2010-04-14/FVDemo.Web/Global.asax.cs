namespace FVDemo.Web {
	using System.Web;
	using System.Web.Mvc;
	using System.Web.Routing;
	using Castle.Windsor;
	using FluentValidation.Attributes;
	using FluentValidation.Mvc;

	public class MvcApplication : HttpApplication {
		static IWindsorContainer container;

		public static void RegisterRoutes(RouteCollection routes) {
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"Default", // Route name
				"{controller}/{action}/{id}", // URL with parameters
				new {controller = "Home", action = "Index", id = UrlParameter.Optional} // Parameter defaults
				);
		}

		protected void Application_Start() {
			AreaRegistration.RegisterAllAreas();
			RegisterRoutes(RouteTable.Routes);
			container = new WindsorContainer();
			container.Register(new ContainerRegistration());

			DataAnnotationsModelValidatorProvider
				.AddImplicitRequiredAttributeForValueTypes = false;

			var factory = new WindsorValidatorFactory(container);

			var fvProvider
				= new FluentValidationModelValidatorProvider(factory);

			ModelValidatorProviders
				.Providers.Add(fvProvider);
		}
	}
}