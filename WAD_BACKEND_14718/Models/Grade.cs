using System.ComponentModel.DataAnnotations;

namespace CW_WAD_00014718.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Student ID is required")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Course name is required")]
        [StringLength(100, ErrorMessage = "Course name cannot be longer than 100 characters")]
        public string CourseName { get; set; }

        [StringLength(1000, ErrorMessage = "Course description cannot be longer than 1000 characters")]
        public string CourseDescription { get; set; }

        [Required(ErrorMessage = "Credits are required")]
        [Range(1, 10, ErrorMessage = "Credits must be between 1 and 10")]
        public int Credits { get; set; }

        [Required(ErrorMessage = "Instructor name is required")]
        [StringLength(100, ErrorMessage = "Instructor name cannot be longer than 100 characters")]
        public string InstructorName { get; set; }

        [Required(ErrorMessage = "Assignment name is required")]
        [StringLength(100, ErrorMessage = "Assignment name cannot be longer than 100 characters")]
        public string AssignmentName { get; set; }

        [StringLength(1000, ErrorMessage = "Assignment description cannot be longer than 1000 characters")]
        public string AssignmentDescription { get; set; }

        [Required(ErrorMessage = "Due date is required")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Max points are required")]
        [Range(0, 1000, ErrorMessage = "Max points must be between 0 and 1000")]
        public int MaxPoints { get; set; }

        [Required(ErrorMessage = "Points earned are required")]
        [Range(0, 1000, ErrorMessage = "Points earned must be between 0 and 1000")]
        public int PointsEarned { get; set; }

        [Required(ErrorMessage = "Enrollment date is required")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        [Required(ErrorMessage = "Final grade is required")]
        [StringLength(5, ErrorMessage = "Final grade cannot be longer than 5 characters")]
        public string FinalGrade { get; set; }

        public Student? Student { get; set; }
    }
}
