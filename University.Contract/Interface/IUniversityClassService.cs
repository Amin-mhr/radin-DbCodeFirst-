using University.Contract.Dto;

namespace University.Contract.Interface
{
    public interface IUniversityClassService
    {
        void AddUniversityClass(UniversityClassDto universityClass);
        void DeleteUniversityClass(UniversityClassDto universityClass);
        void UpdateUniversityClass(UniversityClassDto universityClass);
        void ReadUniversityClass (UniversityClassDto universityClass);
    }
}
