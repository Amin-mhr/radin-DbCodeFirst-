using University.Contract.Dto;

namespace University.Contract.Interface
{
    public interface IAdminService
    {
        void AddAdmin(AdminDto admin);
        void DeleteAdmin(AdminDto admin);
        void UpdateAdmin(AdminDto admin);  
        void ReadAdmin(AdminDto admin);
    }
}
