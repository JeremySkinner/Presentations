using System.Web.Mvc;
using FarmYard.Controllers;
using FarmYard.Models;
using MvcContrib.TestHelper;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	public class CowControllerTester
	{
		[Test]
		public void Edit_renders_view_with_cow()
		{
			var controller = new CowsController();

			var result = controller.Edit(5) as ViewResult;
			
			Assert.IsNotNull(result);
			var model = result.ViewData.Model;
            Assert.IsInstanceOf(typeof(Cow), model);

			//TODO: This could be much nicer.
		}
	}
}