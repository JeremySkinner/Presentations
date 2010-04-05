using System.Web.Routing;
using FarmYard;
using FarmYard.Controllers;
using MvcContrib.TestHelper;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	public class RouteTester
	{
		[Test]
		public void Default_route()
		{
			"~/Home".Route().ShouldMapTo<HomeController>(c => c.Index());
		}

		[Test]
		public void Editing_cow()
		{
			Assert.Fail("Write me!");
		}

		[SetUp]
		public void Setup()
		{
			RouteTable.Routes.Clear();
			MvcApplication.RegisterRoutes(RouteTable.Routes);
		}

		[TearDown]
		public void Teardown()
		{
			RouteTable.Routes.Clear();
		}
	}
}