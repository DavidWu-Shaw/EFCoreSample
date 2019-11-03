using Sample.Data;
using Sample.Repository;
using System;
using System.Collections.Generic;

namespace Sample.Service
{
    public class StudentService
    {
        private EFRepository<Student> _repository; 

        public StudentService(string connectString)
        {
            _repository = new EFRepository<Student>(connectString);
        }

        public IEnumerable<Student> GetAll()
        {
            return _repository.GetAll();
        }

        public void Insert(Student student)
        {
            _repository.Insert(student);
        }
    }
}
