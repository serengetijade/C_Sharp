using MVC_NewsletterWebApp.Models;
using MVC_SignupForm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_SignupForm.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            //Establish the DB context and connection- Instantiate a newsletter entity object inside a using statement:
            using (db_NewsletterEntities db = new db_NewsletterEntities())
            {
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList(); //Use an object to access all the 'SignUps' property values (defined in Newsletter.Context.cs) of the 'db' entity object. 
                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();
                
                var signupVms = new List<SignupVm>();   //Instantiate an empty list of ViewModel objects to hold the list of property values (signups).
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();  //Create a new ViewModel object (defined in SignupVm.cs)
                    signupVm.Id = signup.Id;  //Pass in the Id from the record in the DB and pass it to the viewModel
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);     //Add this instance of the ViewModel to the signupVM list. 
                }
                return View(signupVms);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            //Establish the DB context and connection- Instantiate a newsletter entity object inside a using statement:
            using (db_NewsletterEntities db = new db_NewsletterEntities())
            {
                var signup = db.SignUps.Find(Id); //Pass in the primary key and find the record with matching parameter value (the parameter is defined in dbName.Context.cs)
                signup.Removed = DateTime.Now;  //Change the value of a property in the record
                db.SaveChanges(); //Use built in method .SaveChanges()
            }
            return RedirectToAction("Index");
        }
    }
}