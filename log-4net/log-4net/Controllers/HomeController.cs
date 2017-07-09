using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace log_4net.Controllers
{
    [ErrorHandlingFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int a = Convert.ToInt32("aa");

            return View();
        }
    }
}
