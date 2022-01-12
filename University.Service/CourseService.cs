using Mapster;
using System;
using University.Contract.Dto;
using University.Contract.Interface;
using University.Db;
using University.Db.Model;



namespace University.Service
{
    public class CourseService : ICourseService
    {
        public void AddCourse(CourseDto course)
        {
            using (var context = new UniversityDbContext())
            {
                var cour = course.Adapt<Course>();

                context.Courses.Add(cour);
                context.SaveChanges();
            }
        }

        public void DeleteCourse(CourseDto course)
        {
            using (var context = new UniversityDbContext())
            {
                var cour = course.Adapt<Course>();

                context.Courses.Remove(cour);
                context.SaveChanges();
            }
        }

        public void ReadCourse(CourseDto course)
        {
            using (var context = new UniversityDbContext())
            {
                var cour = course.Adapt<Course>();

                Console.WriteLine(cour);
            }
        }

        public void UpdateCourse(CourseDto course)
        {
            using (var context = new UniversityDbContext())
            {
                var cour = course.Adapt<Course>();

                context.Courses.Update(cour);
                context.SaveChanges();
            }
        }
    }
}
