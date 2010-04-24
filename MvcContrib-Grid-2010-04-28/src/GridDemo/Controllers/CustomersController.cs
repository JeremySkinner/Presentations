using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridDemo.Controllers {
	using GridDemo.Lib;
	using GridDemo.Models;

	[HandleError]
	public class CustomersController : Controller {
		//Use a DI Container in a real app!
		CustomerRepository customerRepository = new CustomerRepository();

		public ActionResult Index() {
			var customers = customerRepository.FindAll();
			return View(customers);
		}

		public ActionResult Show(int id) {
			var customer = customerRepository.FindById(id);
			return View(customer);
		}

		#region Renderer Demo

		public ActionResult Export() {
			var customers = customerRepository.FindAll();

			return new ExcelResult<Customer>(customers)
				.Columns(column => {
					column.For(x => x.Id);
					column.For(x => x.Name);
					column.For(x => x.DateOfBirth).Format("{0:d}");
				});
		}

		#endregion
	}
}
