using coreEntityFrameworkDatabaseFirstLook.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreEntityFrameworkDatabaseFirstLook.Controllers
{
    public class CustomerController : Controller
    {
        private readonly FirstLookDbContext _context;
        public CustomerController()
        {
            // Initialize context
            _context = new FirstLookDbContext();    
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            // context.Customers.ToList method get all the customers and assigning them to the customers.
            // Lambda expression, which helps in communicating with the DB set in th Model AppDBContext or FirstLookDbContext in my case
            var customers = _context.Customers.ToList();
            // Bind View and generate the view
            return View(customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
