using System.Web.Mvc;
using FarmYard.Models;
using MvcContrib.Pagination;

namespace FarmYard.Controllers
{
	public class CowsController : Controller
	{
		private CowRepository cowRepository;


		public ActionResult Edit(int id)
		{
			var cow = cowRepository.FindById(id);
			return View(cow);
		}
		
		[AcceptVerbs(HttpVerbs.Post)]
		public ActionResult Edit(int id, FormCollection form)
		{
			var cow = cowRepository.FindById(id);
			UpdateModel(cow, form.ToValueProvider());

			TempData["notice"] = "Cow successfully saved.";
			return RedirectToAction("Edit", new { id });
		}

		public ActionResult List(int? page)
		{
			var allCows = cowRepository.FindAll();
			return View(allCows);
		}

		public ActionResult CowByName(string name)
		{
			var cow = cowRepository.FindByName(name);
			return View(cow);
		}

		public CowsController() {
			//Don't do this in a real app - use a DI container!
			this.cowRepository = new CowRepository();
		}
	}
}