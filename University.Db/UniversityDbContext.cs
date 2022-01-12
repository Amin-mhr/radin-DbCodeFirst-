using Microsoft.EntityFrameworkCore;
using University.Db.Model;


namespace University.Db
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<UniversityClass> UniversityClasses { get; set; }
        public DbSet<Enroll> Enrolls { get; set; }
        public DbSet<Admin> Admins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UniversityClass>()
                .HasOne(b => b.Course)
                .WithOne(i => i.UniversityClass)
                .HasForeignKey<Course>(b => b.ClassID);


            modelBuilder.Entity<Professor>()
                .Property(a => a.ProfessorID)
                .ValueGeneratedNever();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=UniversityDb;Trusted_Connection=True;");
        }
    }
}