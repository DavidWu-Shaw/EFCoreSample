using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Data
{
    public class Grade : BaseEntity
    {
        public string GradeName { get; set; }
        public string Section { get; set; }
    }
}
