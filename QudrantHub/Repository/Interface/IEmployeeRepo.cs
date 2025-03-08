using QudrantHub.Data.DTOs;
using QudrantHub.Models;

namespace QudrantHub.Repository.Interface
{
    public interface IEmployeeRepo
    {
        public bool SignUp(EmployeeDTO employeeDTO);
        public bool Login(string Email, string Password);
        public bool ForgetPassword(string Email, string Password);
        public bool DeleteById(int Id);
        public bool DeleteAll();
        public IList<ShowEmployeeWithIdDTO> GetAll();
        public ShowEmployeeWithIdDTO GetById(int Id);
        public bool Update(int Id, EmployeeDTO employeeDTO);

    }
}
