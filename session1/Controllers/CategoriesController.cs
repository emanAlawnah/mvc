using Microsoft.AspNetCore.Mvc;
using session1.Data;

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
    }
}
