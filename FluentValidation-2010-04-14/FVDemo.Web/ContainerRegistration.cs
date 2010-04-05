namespace FVDemo.Web {
	using System;
	using Castle.MicroKernel;
	using Castle.MicroKernel.Registration;
	using FluentValidation;

	public class ContainerRegistration : IRegistration {
		public void Register(IKernel kernel) {
			AssemblyScanner.FindValidatorsInAssemblyContaining<CustomerValidator>()
				.ForEach(result => {
					kernel.Register(Component.For(result.InterfaceType)
						.ImplementedBy(result.ValidatorType)
						.LifeStyle.Singleton);
				});
		}
	}
}