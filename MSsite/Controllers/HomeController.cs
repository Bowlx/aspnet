using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSsite.Models;

namespace MSsite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Achieves()
        {
            var achieves = AchieveFactory.CreateAchieves();
            return View(achieves);
        }

    }
}
