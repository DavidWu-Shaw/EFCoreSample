using System;

namespace Sample.Data
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
