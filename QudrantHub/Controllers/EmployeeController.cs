using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QudrantHub.Data.DTOs;
using QudrantHub.Repository.Interface;

namespace QudrantHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeController(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        [HttpPost]
        public IActionResult PostEmployee(EmployeeDTO employeeDTO)
        {
            string message = _employeeRepo.SignUp(employeeDTO) ?
                "Employee added successfully" :
                "Failed to add employee";
            string status = _employeeRepo.SignUp(employeeDTO) ?
                "Success" :
                "Failed";
            return Ok(new { message, status });
        }
        [HttpPost("Login")]
        public IActionResult Login(string Email, string Password)
        {
            var result = _employeeRepo.Login(Email, Password);
            string message = result ? "Employee logged in successfully" : "Failed to login employee";
            string status = result ? "Success" : "Failed";
            return Ok(new { message, status });
        }
        [HttpPost("ForgetPassword")]
        public IActionResult ForgetPassword(string Email, string Password)
        {
            var result = _employeeRepo.ForgetPassword(Email, Password);
            string message = result ? "Password changed successfully" : "Failed to change password";
            string status = result ? "Success" : "Failed";
            return Ok(new { message, status });
        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteById(int Id)
        {
            bool result = _employeeRepo.DeleteById(Id);
            string message = result ? "Employee deleted successfully" : $"Can't find employee with ID: {Id}";
            string status = result ? "Success" : "Failed";
            return Ok(new { message, status });
        }
        [HttpDelete]
        public IActionResult DeleteAll()
        {
            bool result = _employeeRepo.DeleteAll();
            string message = result ? "All employees deleted successfully" : "Can't find employees to delete";
            string status = result ? "Success" : "Failed";
            return Ok(new { message, status });
        }
        [HttpGet("{Id}")]
        public IActionResult GetEmployeeById(int Id)
        {
            var result = _employeeRepo.GetById(Id);
            string message = result == null ? $"Can't find employee with ID: {Id}" : "Employee found successfully";
            string status = result == null ? "Failed" : "Success";
            return Ok(new { message, status, result });
        }
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var result = _employeeRepo.GetAll();
            string message = result.Count == 0 ? "Can't find any employee" : "Employees found successfully";
            string status = result.Count == 0 ? "Failed" : "Success";
            return Ok(new { message, status, result });
        }
        [HttpPut("{Id}")]
        public IActionResult UpdateEmployee(int Id, EmployeeDTO employeeDTO)
        {
            bool result = _employeeRepo.Update(Id, employeeDTO);
            string message = result ? "Employee updated successfully" : $"Can't find employee with ID: {Id}";
            string status = result ? "Success" : "Failed";
            return Ok(new { message, status });
        }
    }
}
