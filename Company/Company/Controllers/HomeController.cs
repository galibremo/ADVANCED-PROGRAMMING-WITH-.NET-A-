using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Scalable and Secured Platform for Retail & Wholesale SMS Business";
            ViewBag.Message1 = "Cutting edge solution for \r\n Your Business";
            return View();
        }
        public ActionResult Services()
        {
            var ser1 = new Services()
            {
                Price="30000",
                Title="REVE SBC"
            };
            var ser2 = new Services()
            {
                Price = "60000",
                Title = "REVE OTT"
            };
            var ser3 = new Services()
            {
                Price = "10000",
                Title = "REVE SMS Platform"
            };
            var ser4 = new Services()
            {
                Price = "90000",
                Title = "Cloud Telephony"
            };

            Services[] sev = new Services[] { ser1, ser2, ser3, ser4 };

            return View(sev);
        }
        public ActionResult Teams_and_Member()
        {
            ViewBag.Name1 = "Ajmat Iqbal";
            ViewData["msg1"] = "Director - REVE Group";
            ViewBag.Name2 = "Momi Monjil";
            ViewData["msg2"] = "Head - Software Development";
            ViewBag.Name3 = "M. Rezaul Hassan";
            ViewData["msg3"] = "Founder & Group CEO";
            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Address = "REVE Centre, Plot-94, Purbachal Express Highway, Dumni, Khilkhet, Dhaka";
            ViewBag.Phone = "+8809606738300";
            ViewBag.Email = "info@revesoft.com";
            return View();
        }
    }
}