using Microsoft.AspNetCore.Mvc;

namespace Asp_intro.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

             int[] nums = { 1, 2, 3, 4, 5, 6 };

             return View(nums);

            // return Content("Index");

            //return Json(new { name = "Ali", surname = "Talibov" });
        }


        


        //public string Index(int id) 
        //{
        //   if(id == 0)
        //    {
        //        return "Aqshin";
        //    }

        //    return "Aqshin - " + " " + id;
        //}



        //public string Detail(string slug,string name)
        //{
        //    return slug + " " + name;
        //}



        //private string GetName()
        //{
        //    return "Aqshin";
        //}
    }
}
