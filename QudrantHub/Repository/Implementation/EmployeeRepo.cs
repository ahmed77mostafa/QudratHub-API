using QudrantHub.Data;
using QudrantHub.Data.DTOs;
using QudrantHub.Models;
using QudrantHub.Repository.Interface;

namespace QudrantHub.Repository.Implementation
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly AppDbContext _context;

        public EmployeeRepo(AppDbContext context)
        {
            _context = context;
        }


        public bool SignUp(EmployeeDTO employeeDTO)
        {
            Employee employee = new Employee
            {
                Name = employeeDTO.Name,
                Email = employeeDTO.Email,
                AnotherEmail = employeeDTO.AnotherEmail,
                Password = employeeDTO.Password,
                PhoneNumber = employeeDTO.PhoneNumber,
                Age = employeeDTO.Age,
                Gender = employeeDTO.Gender,
                NationalCardFile = employeeDTO.NationalCardFile,
                Statement = employeeDTO.Statement,
                SocialSolidarity = employeeDTO.SocialSolidarity
            };

            _context.SaveChanges();
            _context.Employees.Add(employee);
            return true;
        }
        public bool Login(string Email, string Password)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Email == Email);
            if (employee == null) return false;
            return employee.Password == Password;
        }

        public bool ForgetPassword(string Email, string Password)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Email == Email);
            if (employee == null) return false;
            employee.Password = Password;

            _context.SaveChanges();
            return true;
        }

        public bool DeleteById(int Id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == Id);
            if (employee == null) return false;
            else
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                return true;
            }
        }
        public bool DeleteAll()
        {
            if (_context.Employees.Any())
            {
                _context.Employees.RemoveRange(_context.Employees);
                _context.SaveChanges();
                return true;
            }
            return false;

        }

        public IList<ShowEmployeeWithIdDTO> GetAll()
        {
            if (_context.Employees.Any())
            {
                return _context.Employees.Select(employee => new ShowEmployeeWithIdDTO
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Email = employee.Email,
                    AnotherEmail = employee.AnotherEmail,
                    Password = employee.Password,
                    PhoneNumber = employee.PhoneNumber,
                    Age = employee.Age,
                    Gender = employee.Gender,
                    NationalCardFile = employee.NationalCardFile,
                    SocialSolidarity = employee.SocialSolidarity,
                    Statement = employee.Statement
                }).ToList();
            }
            return null;
        }

        public ShowEmployeeWithIdDTO GetById(int Id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == Id);
            if (employee == null) return null;
            return new ShowEmployeeWithIdDTO
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                AnotherEmail = employee.AnotherEmail,
                Password = employee.Password,
                PhoneNumber = employee.PhoneNumber,
                Age = employee.Age,
                Gender = employee.Gender,
                NationalCardFile = employee.NationalCardFile,
                SocialSolidarity = employee.SocialSolidarity,
                Statement = employee.Statement
            };
        }

        public bool Update(int Id, EmployeeDTO employeeDTO)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == Id);
            if (employee == null) return false;
            employee.Name = employeeDTO.Name;
            employee.Email = employeeDTO.Email;
            employee.AnotherEmail = employeeDTO.AnotherEmail;
            employee.Password = employeeDTO.Password;
            employee.PhoneNumber = employeeDTO.PhoneNumber;
            employee.Age = employeeDTO.Age;
            employee.Gender = employeeDTO.Gender;
            employee.NationalCardFile = employeeDTO.NationalCardFile;
            employee.Statement = employeeDTO.Statement;
            employee.SocialSolidarity = employeeDTO.SocialSolidarity;
            employee.Statement = employeeDTO.Statement;

            _context.SaveChanges();
            return true;
        }
    }
}
