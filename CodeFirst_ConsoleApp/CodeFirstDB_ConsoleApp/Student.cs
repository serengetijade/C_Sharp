using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Student
    {
        //Define a Property Syntax: accessModifier Type propertyName { get; set; }   
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GradeLevel GradeLevel { get; set; }
    }
}
