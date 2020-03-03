using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestsSite.Models;

namespace TestsSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Question> tests;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                tests = db.Questions.Where(q => q.TestId == 1).ToList();
            }
            return View(tests);
        }

    }
}