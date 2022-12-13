using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class ExceptionEntity
    //Entity refers to a DB object. If a class includes ‘entity’ in its name, it is assumed that it maps to a database (and each of its properties maps to a column of that DB). 
    {
        public int ID { get; set; }
        public string  ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
