using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDataDemo.Models;

namespace ViewDataDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message"] = "Message from View Data !!";
            ViewData["CurrentTime"] = DateTime.Now.ToLongTimeString();

            string[] Fruits = { "Apple", "Banana", "Grepes", "Orange" };
            ViewData["FruitsArray"] = Fruits;
            

            ViewData["SportsList"] = new List<string>()
            {
                "Cricket",
                "Hockey",
                "Football",
                "Volley Ball"
            };
            Employee amit = new Employee();
            amit.EmpId = 11;
            amit.EmpName = "Amit";
            amit.EmpDesignation = "Manager";
            ViewData["Employee"] = amit;
            return View();
        }
    }
}