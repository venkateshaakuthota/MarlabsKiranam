using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webAPI.Models
{
    public class StudentRepository
    {
        private static List<Student> students;

        public static List<Student> GetAllStudents()
        {
            return students;
        }
        
        public static Student GetStudent(int studentID)
        {
            DBContext context = new DBContext();
            var v=(context.Students.Where(c=>c.StudentID==studentID)).FirstOrDefault();
            return v;
        }

        public static void RemoveStudent(int studentID)
        {
            DBContext context = new DBContext();
            var v= (context.Students.Where(c => c.StudentID == studentID)).FirstOrDefault();
            students.Remove(v);
        }

        public static void AddStudent(Student student)
        {
            DBContext context = new DBContext();
            var v = (context.Students.Where(c => c.StudentID == student.StudentID)).FirstOrDefault();
            students.Add(v);
        }

        public static void UpdateStudent(Student student)
        {
            DBContext context = new DBContext();
            var v = (context.Students.Where(c => c.StudentID == student.StudentID)).FirstOrDefault();
            students.Add(v);
        }
    }
}