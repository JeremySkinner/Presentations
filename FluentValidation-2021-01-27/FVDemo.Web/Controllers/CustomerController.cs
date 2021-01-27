using System.Threading.Tasks;
using FVDemo.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FVDemo.Web.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerData _data;

        public CustomerController(CustomerData data)
        {
            _data = data;
        }

        public ActionResult Index()
        {
            var customers = _data.AllCustomers();
            return View(customers);
        }

        public ActionResult Create()
        {
            return View("Edit");
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", customer);
            }

            _data.Save(customer);
            TempData["notice"] = "Person added successfully.";

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var person = _data.FindById(id);
            return View(person);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, IFormCollection form)
        {
            var customer = _data.FindById(id);

            if (!await TryUpdateModelAsync(customer))
            {
                return View(customer);
            }

            _data.Save(customer);

            TempData["notice"] = "Changes saved.";
            return RedirectToAction("Index");
        }
    }
}