using System;
using University.Contract.Dto;
using University.Contract.Interface;
using University.Db;
using Mapster;
using University.Db.Model;

namespace University.Service
{
    public class StudentService : IStudentService
    {
        public void AddStudent(StudentDto student)
        {
            using (var context = new UniversityDbContext())
            {
                var stu = student.Adapt<Student>();

                context.Students.Add(stu);
                context.SaveChanges();
            }
        }

        public void DeleteStudent(StudentDto student)
        {
            using (var context = new UniversityDbContext())
            {
                var stu = student.Adapt<Student>();

                context.Students.Remove(stu);
                context.SaveChanges();
            }
        }

        public void ReadStudent(StudentDto student)
        {
            using (var context = new UniversityDbContext())
            {
                var stu = student.Adapt<Student>();

                Console.WriteLine(stu);
            }
        }

        public void UpdateStudent(StudentDto student)
        {
            using (var context = new UniversityDbContext())
            {
                var stu = student.Adapt<Student>();

                context.Students.Update(stu);
                context.SaveChanges();
            }
        }
    }
}
