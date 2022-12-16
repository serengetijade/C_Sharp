using Car_Insurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Car_Insurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (db_InsuranceEntities db = new db_InsuranceEntities())
            return View(db.Insurees.ToList());
        }
    }
}