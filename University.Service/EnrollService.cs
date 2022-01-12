using Mapster;
using System;
using University.Contract.Dto;
using University.Contract.Interface;
using University.Db;
using University.Db.Model;

namespace University.Service
{
    public class EnrollService : IEnrollService
    {
        public void AddEnroll (EnrollDto enroll)
        {
            using (var context = new UniversityDbContext())
            {
                var enr = enroll.Adapt<Enroll>();

                context.Enrolls.Add(enr);
                context.SaveChanges();
            }
        }

        public void DeleteEnroll(EnrollDto enroll)
        {
            using (var context = new UniversityDbContext())
            {
                var enr = enroll.Adapt<Student>();

                context.Students.Remove(enr);
                context.SaveChanges();
            }
        }

        public void ReadEnroll(EnrollDto enroll)
        {
            using (var context = new UniversityDbContext())
            {
                var enr = enroll.Adapt<Enroll>();

                Console.WriteLine(enr);
            }
        }

        public void UpdateEnroll(EnrollDto enroll)
        {
            using (var context = new UniversityDbContext())
            {
                var enr = enroll.Adapt<Enroll>();

                context.Enrolls.Update(enr);
                context.SaveChanges();
            }
        }
    }
}
