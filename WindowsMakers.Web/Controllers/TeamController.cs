using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WindowsMakers.Web.Controllers
{
    public class TeamController : Controller
    {
        [Route("Team/{id}")]
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return View();
            else
                return View(id);
        }
    }
}