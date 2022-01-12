using Mapster;
using System;
using University.Contract.Dto;
using University.Contract.Interface;
using University.Db;
using University.Db.Model;

namespace University.Service
{
    public class ProfessorService : IProfessorService
    {
        public void AddProfessor(ProfessorDto professor)
        {
            using (var context = new UniversityDbContext())
            {
                var pro = professor.Adapt<Professor>();

                context.Professors.Add(pro);
                context.SaveChanges();
            }
        }

        public void DeleteProfessor(ProfessorDto professor)
        {
            using (var context = new UniversityDbContext())
            {
                var pro = professor.Adapt<Professor>();

                context.Professors.Remove(pro);
                context.SaveChanges();
            }
        }

        public void ReadProfessor(ProfessorDto professor)
        {
            using (var context = new UniversityDbContext())
            {
                var pro = professor.Adapt<Professor>();

                Console.WriteLine(pro);
            }
        }

        public void UpdateProfessor(ProfessorDto professor)
        {
            using (var context = new UniversityDbContext())
            {
                var pro = professor.Adapt<Professor>();

                context.Professors.Update(pro);
                context.SaveChanges();
            }
        }
    }
}
