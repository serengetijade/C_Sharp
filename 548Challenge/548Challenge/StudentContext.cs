using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class StudentContext: DbContext
    {
        public StudentContext(): base() { }
        public DbSet<Student> Students { get;set; }  //The DbSet is a collection of entity classes 
        public DbSet<GradeLevel> GradeLevels { get;set; }
    }
}
