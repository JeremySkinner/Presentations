using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridDemo.Controllers {
	using GridDemo.Models;

	[HandleError]
	public class CustomersController : Controller {
		//Use a DI Container in a real app!
		CustomerRepository customerRepository = new CustomerRepository();

		public ActionResult Index() {
			IEnumerable<Customer> customers 
				= customerRepository.FindAll();
			

			return View(customers);
		}

		public ActionResult Show(int id) {
			var customer = customerRepository.FindById(id);
			return View(customer);
		}
	}
}
