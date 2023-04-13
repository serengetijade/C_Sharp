using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public  class GradeLevel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int GradeID { get; set; }
        public string GradeName { get; set; }
        //Create a type of a list of Student Objects
        public ICollection<Student> Students { get; set; }   //ICollection: Returns a filtered collection of elements that contains the descendant elements of every element and document in the source collection. 
    }
}
