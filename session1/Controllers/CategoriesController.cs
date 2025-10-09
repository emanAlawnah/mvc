using Microsoft.AspNetCore.Mvc;
using session1.Data;
using session1.Models;

namespace session1.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDpContext context = new ApplicationDpContext();
        public ViewResult Index()
        {
            var categories = context.Categories.ToList();
            return View("Index", categories);
        }

        public ViewResult Details(int id)
        {
            var categories = context.Categories.Find(id);
            return View("Details", categories);
        }

        public ViewResult Create()
        {
            return View("create", new Category());
        }
        public IActionResult Store(Category request)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(request);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("create", request);


        }

        public RedirectToActionResult Delete(int id)
        {

            var category = context.Categories.Find(id);
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("Index");



        }

        public IActionResult Update(int id)
        {
            var category = context.Categories.Find(id);
                if (category == null)
                return RedirectToAction("Index");
                return View("Update", category);
        }

        public IActionResult PostUpdate(Category request)
        {
            if (!ModelState.IsValid)
                return View("update", request);

            var cat = context.Categories.Find(request.Id);
            if(cat == null)
            return RedirectToAction("Index");

            cat.Name = request.Name;
            cat.Description = request.Description;
            context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
