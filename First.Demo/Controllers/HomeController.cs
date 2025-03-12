using First.Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace First.Demo.Controllers
{
    public class HomeController : Controller
    {
        //Model Binding 
        // Action Methodm => public Non-Static method

        //From route => Home/Index/10
        //From Querystring => Home/Index?id=10&name=ahmed
        //From Body => 
        //From form 
        //From Header 
        public IActionResult Index()
        {
            //return $"id = {id} :: name = {name} product=> id:{product.Id} :: name:{product.Name}";
            //return $"Hello From Index In Home Controller With Id = {id}";
            return View();
        }
        public IActionResult ConnectUs()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
