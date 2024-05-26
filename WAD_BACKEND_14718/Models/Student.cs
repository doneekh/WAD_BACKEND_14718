using System.ComponentModel.DataAnnotations;

namespace CW_WAD_00014718.Models
{
    public class Student
    {
        [Key]
        public int Id{ get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [StringLength(10, ErrorMessage = "Gender cannot be longer than 10 characters")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Class year is required")]
        [StringLength(10, ErrorMessage = "Class year cannot be longer than 10 characters")]
        public string ClassYear { get; set; }
    }
}
