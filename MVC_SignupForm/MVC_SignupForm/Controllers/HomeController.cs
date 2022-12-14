using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVC_SignupForm.ViewModels;
using MVC_NewsletterWebApp.Models;

namespace MVC_SignupForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]   //Mark as a post method
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)      //The parameters must EXACTLY MATCH the names of the form input tags (defined in Index.cshtml).
        {
           if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View(@"~/Views/Shared/Error.cshtml");
            }
            else
            {
                //Instantiate a newsletter entity object inside a using statement WITH ENTITY FRAMEWORK. This doesn't require a connection strign because it is "built in".:
                using (db_NewsletterEntities db = new db_NewsletterEntities())  
                {
                    var signup = new SignUp(); //Instantiate a new class object
                    //Map the properites for this object to the parameters that came in
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;
                    db.SignUps.Add(signup); //Access the Signups property of the 'db' instance of the entity, and apply the .Add method to pass in the signup object (and its property values)
                    db.SaveChanges();  //Apply the .SaveChanges method to the 'db' instance of the entity.
                }
                return View("Success");
            }
        }

    }
}