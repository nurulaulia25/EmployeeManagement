using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models.Entities
{
    public class Employee
    {
      
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } 
        public string Gender { get; set; } 
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset StartJoin { get; set; } = DateTimeOffset.UtcNow.Date; 
        public string Email { get; set; }
        public string Password { get; set; }
        // untuk password salah
        //public int PasswordFailed { get; set; } = 0;
        //public bool isActive { get; set; } = true;

    }
}
