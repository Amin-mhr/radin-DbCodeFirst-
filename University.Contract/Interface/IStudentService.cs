using University.Contract.Dto;

namespace University.Contract.Interface
{
    public interface IStudentService
    {
        void AddStudent(StudentDto student);
        void UpdateStudent(StudentDto student); 
        void DeleteStudent(StudentDto student);
        void ReadStudent(StudentDto student);
    }
}
