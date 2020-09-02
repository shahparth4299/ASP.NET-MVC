using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLayer
{
    //Composition Relationship with Problems
    public class Visit
    {
        public DateTime visitTime { get; set; }
        public List<Problems> problems;
        
    }
}
