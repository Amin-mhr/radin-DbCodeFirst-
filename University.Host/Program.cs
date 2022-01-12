using University.Contract.Dto;
using University.Service;

namespace University.Host
{
    public class Program
    {
        static void Main(string[] args)
        {
            //AdminDto ad = new AdminDto() { Username = "ali", Password = "12345", AdminName = "Amin" };
            //AdminService admin = new AdminService();
            //admin.ReadAdmin(ad);
            //CourseDto cour = new CourseDto() { NumberOfUnits = 22, Name = "ali" };
            //CourseService course = new CourseService();
            //course.DeleteCourse(cour);
            //UniversityClassDto uni = new UniversityClassDto() { AverageScore = 16 , ClassId = 1 };
            //UniversityClassService university = new UniversityClassService();
            //university.DeleteUniversityClass(uni);
            //ProfessorDto pro = new ProfessorDto() { ProfessorID = 2 };
            //ProfessorService professor = new ProfessorService();
            //professor.AddProfessor(pro);
            //EnrollDto enr = new EnrollDto() { ClassName = "riazi", PersonID = 45 };
            //EnrollService enroll = new EnrollService();
            //enroll.AddEnroll(enr);
            StudentDto stu = new StudentDto() { AverageScore = 17, NumberOfUnits = 12 };
            StudentService student = new StudentService();
            student.AddStudent(stu);
        }
    }
}
