using CourseManagementSystem.DTOs;

namespace CourseManagementSystem.Interfaces
{
    public interface ICourseService
    {
        Task<List<CourseDto>> GetAllAsync();
        Task<CourseDto> CreateAsync(CreateCourseDto dto);
    }
}