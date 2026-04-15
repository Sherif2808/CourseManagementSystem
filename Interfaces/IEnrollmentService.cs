using CourseManagementSystem.DTOs;

namespace CourseManagementSystem.Interfaces
{
    public interface IEnrollmentService
    {
        Task<string> EnrollAsync(int studentId, CreateEnrollmentDto dto);
    }
}