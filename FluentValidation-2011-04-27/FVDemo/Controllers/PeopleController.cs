
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
            if (!ModelState.IsValid) {
                return View("Edit", person);
            }

            repository.Save(person);
            TempData["notice"] = "Person added successfully.";

            return RedirectToAction("Index");
        }

       public ActionResult Edit(int id) {
            var person = repository.FindById(id);
            return View(person);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection form) {
            var person = repository.FindById(id);

            if (!TryUpdateModel(person, form)) {
                return View(person);
            }

            TempData["notice"] = "Changes saved.";

            return RedirectToAction("Index");
        }
    }
}