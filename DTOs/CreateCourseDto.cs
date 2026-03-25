using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.DTOs
{
    public class CreateCourseDto
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int InstructorId { get; set; }
    }
}