using Microsoft.AspNetCore.Mvc;

namespace Homework03._04._2023.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {

            List<string> users = new List<string>() { "Agshin","Elcan","Shaig","Mubariz","Hacker","Mirze","Ali","Elekber"};

            return View(users);
        }
    }
}
