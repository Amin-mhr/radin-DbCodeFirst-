using University.Contract.Dto;

namespace University.Contract.Interface
{
    public interface IEnrollService
    {
        void AddEnroll(EnrollDto enroll);
        void UpdateEnroll(EnrollDto enroll);
        void ReadEnroll(EnrollDto enroll);
        void DeleteEnroll(EnrollDto enroll);   
    }
}
