using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Data
{
    public class Course : BaseEntity
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
    }
}
