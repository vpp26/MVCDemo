using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class SeesionDataController : Controller
    {
        // GET: SeesionData
        [HttpGet]
        public ActionResult Index()
        {
            TempData["tempdataexample"] = "tempdataexample_Data";
            
            ViewData["viewdataExample"] = "viewdataexample";

            List<string> st = new List<string>() {
                "one",
                "two",
                "three"
            };

            TempData["datalistviewdata"] = st;

            return View();
        }
        [HttpPost]
        public ActionResult Index(string name)
        {
            TempData["name"] = name;

            return RedirectToAction("Page1");
        }
        public ActionResult Page1()
        {
            return View();
        }
       
    }

}