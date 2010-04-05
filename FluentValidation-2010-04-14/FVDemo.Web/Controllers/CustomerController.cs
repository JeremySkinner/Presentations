namespace FVDemo.Web.Controllers {
	using System.Web.Mvc;

	public class CustomerController : Controller {
		public ActionResult Index() {
			return View();
		}

		[HttpPost]
		public ActionResult Index(Customer customer) {
			return View();
		}
	}
}