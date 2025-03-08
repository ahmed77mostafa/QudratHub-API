using QudrantHub.Data.DTOs;

namespace QudrantHub.Repository.Interface
{
    public interface ICompanyRepo
    {
        public bool SignUp(CompanyDTO companyDTO);
        public bool Login(string CompanyEmail, string CompanyPassword);
        public bool ForgetPassowrd(string CompanyEmail, string CompanyPassword);
        public bool DeleteAll();
        public bool DeleteById(int Id);
        public IList<ShowCompanyWithIdDTO> GetAll();
        public ShowCompanyWithIdDTO GetById(int Id);
        public bool Update(int Id, CompanyDTO companyDTO);
    }
}
