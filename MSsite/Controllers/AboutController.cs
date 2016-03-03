using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSsite.Models;

namespace MSsite.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/

        public ActionResult Design()
        {
            return View();
        }
        public ActionResult Meows()
        {
            var cats = CatFactory.CreateCats();
            return View(cats);
        }
    }
}
