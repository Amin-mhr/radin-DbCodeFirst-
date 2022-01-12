using University.Contract.Dto;

namespace University.Contract.Interface
{
    public interface IProfessorService
    {
        void AddProfessor(ProfessorDto profesoor);
        void UpdateProfessor(ProfessorDto profesoor);  
        void DeleteProfessor(ProfessorDto profesoor);
        void ReadProfessor(ProfessorDto profesoor);
    }
}
