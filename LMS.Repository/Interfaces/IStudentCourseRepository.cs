﻿using LMS.Repository.Entities;

namespace LMS.Repository.Interfaces
{
    public interface IStudentCourseRepository
    {
        Task<List<StudentCourse>> GetAllCourses();
        Task<int> AddStudentCourse(StudentCourse stdCourse);
        Task<bool> IsCourseEnrolled(Guid stdId, Guid courseID);
        Task<int> TotalEnrolled(Guid courseID);
    }
}
