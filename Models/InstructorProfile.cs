namespace CourseManagementSystem.Models
{
    public class InstructorProfile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Bio { get; set; }
        public string Specialization { get; set; }
        public User User { get; set; }
    }
}