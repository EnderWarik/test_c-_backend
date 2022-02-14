using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tododo.Controllers
{
    [Route("api/[controller]")]
    public class MainController: Controller
    {

        private static List<Product> product = new List<Product> { new Product { Name = " exelent", Price = 34 } };
        // GET: MainController
        [HttpGet]
        public IEnumerable<Product> Get()
        {
         return product; 
            //return " aaaa";
        }
        // api/main/welcome/5
        public int Welcome(int id)
        {
            return id;
        }

        //// GET: MainController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: MainController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: MainController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: MainController/Edit/5
        //public int Edit(int id)
        //{
        //    return id;
        //}

        //// POST: MainController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: MainController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: MainController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
