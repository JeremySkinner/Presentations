using Microsoft.Web.Mvc;

namespace FVDemo.Controllers {
	using System.Web.Mvc;
	using FVDemo.Models;

	public class PeopleController : Controller {
		readonly PeopleRepository repository = new PeopleRepository();

		public ActionResult Index() {
			var people = repository.FindAll();
			return View(people);
		}

		public ActionResult Create() {
			return View("Edit");
		}

		[AcceptVerbs(HttpVerbs.Post)]
		public ActionResult Create(Person person) {
			if(! ModelState.IsValid) {
				return View("Edit", person);
			}

			repository.Save(person);
			TempData["notice"] = "Person added successfully.";

			return RedirectToAction("Index");
		}

		#region Ajax demo

		[ActionName("Create"), AcceptAjax]
		public ActionResult Create_Ajax(Person person)
		{
			if(! ModelState.IsValid) {
				return PartialView("EditForm", person);
			}

			repository.Save(person);

			return PartialView("Success");
		}

		#endregion

		public ActionResult Edit(int id) {
			var person = repository.FindById(id);
			return View(person);
		}

		[AcceptVerbs(HttpVerbs.Post)]
		public ActionResult Edit(int id, FormCollection form) {
			var person = repository.FindById(id);

			if(! TryUpdateModel(person, form)) {
				return View(person);
			}

			TempData["notice"] = "Changes saved.";

			return RedirectToAction("Index");
		}
	}
}