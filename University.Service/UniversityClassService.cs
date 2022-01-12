using Mapster;
using System;
using University.Contract.Dto;
using University.Contract.Interface;
using University.Db;
using University.Db.Model;

namespace University.Service
{
    public class UniversityClassService : IUniversityClassService
    {
        public void AddUniversityClass(UniversityClassDto universityClass)
        {
            using (var context = new UniversityDbContext())
            {
                var uni = universityClass.Adapt<UniversityClass>();

                context.UniversityClasses.Add(uni);
                context.SaveChanges();
            }
        }

        public void DeleteUniversityClass(UniversityClassDto universityClass)
        {
            using (var context = new UniversityDbContext())
            {
                var uni = universityClass.Adapt<UniversityClass>();

                context.UniversityClasses.Remove(uni);
                context.SaveChanges();
            }
        }

        public void ReadUniversityClass(UniversityClassDto universityClass)
        {
            using (var context = new UniversityDbContext())
            {
                var uni = universityClass.Adapt<UniversityClass>();

                Console.WriteLine(uni);
            }
        }

        public void UpdateUniversityClass(UniversityClassDto universityClass)
        {
            using (var context = new UniversityDbContext())
            {
                var uni = universityClass.Adapt<UniversityClass>();

                context.UniversityClasses.Update(uni);
                context.SaveChanges();
            }
        }
    }
}
