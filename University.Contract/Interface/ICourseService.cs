using University.Contract.Dto;

namespace University.Contract.Interface
{
    public interface ICourseService
    {
        void AddCourse(CourseDto course);
        void UpdateCourse(CourseDto course);
        void DeleteCourse(CourseDto course);
        void ReadCourse(CourseDto course);
    }
}
