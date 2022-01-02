using Ex6.Models;
using Ex6.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ex6.Controllers
{
    public class ProductsController : Controller
    {
        private ProductService _productServive;

        public ProductsController()
        {
            _productServive = new ProductService();
        }

        // GET: ProductsController
        public ActionResult Index()
        {
            var model = _productServive.GetAll();
            return View(model);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            var model = _productServive.GetById(id);
            return View(model);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                _productServive.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _productServive.GetById(id);
            return View(model);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                _productServive.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _productServive.GetById(id);
            return View(model);
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product model)
        {
            try
            {
                _productServive.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
