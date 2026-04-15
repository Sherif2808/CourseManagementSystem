using CourseManagementSystem.Data;
using CourseManagementSystem.DTOs;
using CourseManagementSystem.Interfaces;
using CourseManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementSystem.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly AppDbContext _context;

        public EnrollmentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<string> EnrollAsync(int studentId, CreateEnrollmentDto dto)
        {
            var course = await _context.Courses.FindAsync(dto.CourseId);
            if (course == null)
                return "Course not found";

            var alreadyEnrolled = await _context.Enrollments
                .AnyAsync(e => e.StudentId == studentId && e.CourseId == dto.CourseId);

            if (alreadyEnrolled)
                return "Already enrolled";

            var enrollment = new Enrollment
            {
                StudentId = studentId,
                CourseId = dto.CourseId,
                EnrollmentDate = DateTime.UtcNow
            };

            _context.Enrollments.Add(enrollment);
            await _context.SaveChangesAsync();

            return "Enrolled successfully";
        }
    }
}