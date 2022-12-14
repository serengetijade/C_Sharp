using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    //Define a class
    public class Instructor
    {
        //Define a Property Syntax: accessModifier Type propertyName { get; set; }  
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}