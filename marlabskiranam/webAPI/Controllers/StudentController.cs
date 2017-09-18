using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webAPI.Models;

namespace webAPI.Controllers
{
    public class StudentController : ApiController
    {
        public List<Student> Get()
        {
            return StudentRepository.GetAllStudents();
        }

        public Student Get(int id)
        {
            return StudentRepository.GetStudent(id);
        }

        public void Post(Student Student)
        {
            StudentRepository.AddStudent(Student);
        }

        public void Put(Student Student)
        {
            StudentRepository.UpdateStudent(Student);
        }

        public void Delete(int id)
        {
            StudentRepository.RemoveStudent(id);
        }
    }
}
