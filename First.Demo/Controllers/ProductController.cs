using Microsoft.AspNetCore.Mvc;

namespace First.Demo.Controllers
{
    public class ProductController : Controller
    {
        //public ContentResult index()
        //{
        //    ContentResult contentResult = new ContentResult();
        //    contentResult.Content = "Hello From Product Controller";
        //    //contentResult.ContentType = "text/html";
        //    contentResult.ContentType = "object/pdf";
        //    return contentResult;
        //    //return "Hello From Product Controller";
        //}
        //public RedirectResult Index()
        //{
        //    RedirectResult redirectResult = new RedirectResult("https://www.google.com");
        //    return redirectResult;
        //}
        public RedirectToActionResult Index()
        {
            RedirectToActionResult redirectToActionResult = new RedirectToActionResult("Index", "Home", new { id = 10 });
            return redirectToActionResult;
        }

        public IActionResult Get()
        {
            //return View();
            return Content("Hello From Get Action", "text/html");
        }
    }
}
