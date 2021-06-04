using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Holiday_Travel_Entities;
using Holiday_Travel_Data;


namespace Holiday_Travel_WebSite_Project.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DatabaseContext db = new DatabaseContext();
        About ab = new About();

        public ActionResult Index()
        {
            
            
           
            return View();
            
        }
    }
}