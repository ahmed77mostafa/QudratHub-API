using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QudrantHub.Data.DTOs;
using QudrantHub.Repository.Implementation;
using QudrantHub.Repository.Interface;

namespace QudrantHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepo _companyRepo;

        public CompanyController(ICompanyRepo companyRepo)
        {
            _companyRepo = companyRepo;
        }
        [HttpPost("SignUp")]
        public IActionResult PostCompany(CompanyDTO companyDTO)
        {
            var message = _companyRepo.SignUp(companyDTO) ?
                "Company added successfully" :
                "Failed to add company";
            var status = _companyRepo.SignUp(companyDTO) ?
                "Success" :
                "Failed";
            return Ok(new { message, status });
        }
        [HttpPost("Login")]
        public IActionResult CompanyLogin(string Email, string Password)
        {
            bool result = _companyRepo.Login(Email, Password);
            string message = result ?
                "Company logged in successfully" :
                "Failed to log in company";
            string status = result ?
                "Success" :
                "Failed";
            return Ok(new { message, status });
        }
        [HttpPost("ForgetPassword")]
        public IActionResult CompanyForgetPassword(string Email, string Password)
        {
            var result = _companyRepo.ForgetPassowrd(Email, Password);
            string message = result ? "Password changed successfully" : "Failed to change password";
            string status = result ? "Success" : "Failed";
            return Ok(new { message, status });
        }
        [HttpDelete("DeleteAll")]
        public IActionResult DeleteAllCompanies()
        {
            bool result = _companyRepo.DeleteAll();
            string message = result ? "All companies deleted successfully" : "Can't find companies to delete";
            string status = result ? "Success" : "Failed";
            return Ok(new { message, status });
        }
        [HttpDelete("DeleteById{Id}")]
        public IActionResult DeleteCompanyById(int Id)
        {
            bool result = _companyRepo.DeleteById(Id);
            string message = result ? $"Company {Id} deleted successfully" : $"Can't find company with ID: {Id}";
            string status = result ? "Success" : "Failed";
            return Ok(new { message, status });
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllCompanies()
        {
            var result = _companyRepo.GetAll();
            string message = result == null ? "Can't find any company" : "Companies found successfully";
            string status = result == null ? "Failed" : "Success";
            return Ok(new { message, status, result });
        }
        [HttpGet("GetById{Id}")]
        public IActionResult GetCompanyById(int Id)
        {
            var result = _companyRepo.GetById(Id);
            string message = result == null ? $"Can't find company with ID: {Id}" : "Company found successfully";
            string status = result == null ? "Failed" : "Success";
            return Ok(new { message, status, result });
        }
        [HttpPut("Update/{Id}")]
        public IActionResult UpdateCompany(int Id, CompanyDTO companyDTO)
        {
            bool result = _companyRepo.Update(Id, companyDTO);
            string message = result ? $"Company {Id} updated successfully" : $"Can't find company with ID: {Id}";
            string status = result ? "Success" : "Failed";
            return Ok(new { message, status });
        }
    }
}
