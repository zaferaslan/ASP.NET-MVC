using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTemplateProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Takim()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Portfoy()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
    }
}