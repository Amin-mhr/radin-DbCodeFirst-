using Mapster;
using System;
using System.Linq;
using University.Contract.Dto;
using University.Contract.Interface;
using University.Db;
using University.Db.Model;

namespace University.Service
{
    public class AdminService : IAdminService
    {
        public void AddAdmin(AdminDto admin)
        {
            using (var context = new UniversityDbContext())
            {
                var ad = admin.Adapt<Admin>();

                context.Admins.Add(ad);
                context.SaveChanges();
            }
        }

        public void DeleteAdmin(AdminDto admin)
        {
            using (var context = new UniversityDbContext())
            {
                var ad = admin.Adapt<Admin>();

                context.Admins.Remove(ad);
                context.SaveChanges();
            }
        }

        public void ReadAdmin(AdminDto admin)
        {
            using (var context = new UniversityDbContext())
            {
                var ad = admin.Adapt<Admin>();

                Console.WriteLine(ad);
            }
        }

        public void UpdateAdmin(AdminDto admin)
        {
            using (var context = new UniversityDbContext())
            {
                var ad = admin.Adapt<Admin>();

                context.Admins.Update(ad);
                context.SaveChanges();
            }
        }
        public void CheckDb()
        {
            var context1 = new UniversityDbContext();
            var admins = context1.Admins.ToList();
            Console.WriteLine("Enter AdminName:");
            string adminName = Console.ReadLine();
            Console.WriteLine("Enter AdminUserName:");
            string adminUserName = Console.ReadLine();
            Console.WriteLine("Enter AdminPassword:");
            string adminPassword = Console.ReadLine();
            foreach (var a in admins)
            {
                if (string.Equals(a.AdminName, adminName) && string.Equals(a.Username, adminUserName) && string.Equals(a.Password, adminPassword))
                {
                    Console.WriteLine("Enter DbName:");
                    string DbName = "";
                    DbName = Console.ReadLine();
                    switch (DbName)
                    {
                        case "Admin":
                            using (var context = new UniversityDbContext())
                            {
                                var admin = context.Admins.ToList();
                                foreach (var b in admin)
                                {
                                    Console.WriteLine("AdminUsername: " + b.Username);
                                }
                            }
                            break;
                        case "Student":
                            using (var context = new UniversityDbContext())
                            {
                                var student = context.Students.ToList();
                                foreach (var b in student)
                                {
                                    Console.WriteLine("StudentID : " + b.StudentID);
                                }
                            }
                            break;
                        case "UniversityClass":
                            using (var context = new UniversityDbContext())
                            {
                                var clazz = context.UniversityClasses.ToList();
                                foreach (var b in clazz)
                                {
                                    Console.WriteLine("ClassId: " + b.ClassId);
                                }
                            }
                            break;
                        case "Professor":
                            using (var context = new UniversityDbContext())
                            {
                                var professor = context.Professors.ToList();
                                foreach (var b in professor)
                                {
                                    Console.WriteLine("ProfessorId : " + b.ProfessorID);
                                }
                            }
                            break;
                        case "Course":
                            using (var context = new UniversityDbContext())
                            {
                                var course = context.Courses.ToList();
                                foreach (var b in course)
                                {
                                    Console.WriteLine("CourseName : " + b.Name);
                                }
                            }
                            break;
                        case "Enroll":
                            using (var context = new UniversityDbContext())
                            {
                                var enroll = context.Enrolls.ToList();
                                foreach (var b in enroll)
                                {
                                    Console.WriteLine("PersonId : " + b.PersonID);
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("invalid input!");
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("admin not found !");
                }
            }
        }
    }
}
