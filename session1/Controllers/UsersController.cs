using Microsoft.AspNetCore.Mvc;

namespace session1.Controllers
{
    public class UsersController : Controller
    {
        
      
        public ViewResult GetAll()
        {
            List<string> users = new List<string>()
        {
         "ee","aa","ll","pp","gg"
        };
            var age = 30; 
            return View("Index",users);
        }

    public ViewResult Create()
        {
            return View("Create");
        }
    public ViewResult Details()
        {
            return View("Details");
        }
    }
}
