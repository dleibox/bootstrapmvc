using BootstrapMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var tbl = new List<Foo> {
                new Foo { Title="First", Description="First desc"},
                new Foo { Title="Second", Description="Second desc"},
                new Foo { Title="Third", Description="Third desc"}
            };
            return View(tbl);
        }
    }
}