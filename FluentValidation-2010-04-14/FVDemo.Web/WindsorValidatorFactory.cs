namespace FVDemo.Web {
	using System;
	using Castle.Windsor;
	using FluentValidation;

	public class WindsorValidatorFactory : ValidatorFactoryBase {
		IWindsorContainer container;

		public WindsorValidatorFactory(IWindsorContainer container) {
			this.container = container;
		}

		public override IValidator CreateInstance(Type validatorType) {

			if(container.Kernel.HasComponent(validatorType)) {
				return container.Resolve(validatorType) as IValidator;
			}

			return null;
		}
	}
}