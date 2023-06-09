﻿namespace LMS.Shared.ResponseModel
{
    public class StudentDetailsResponse
    {
        public Guid StudentId { get; set; }
        public Guid LoginId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? ProfilePicPath { get; set; }
        public long Mobile { get; set; }
        public string? Gender { get; set; }
        public string? College { get; set; }
        public string? Address { get; set; }
    }
}
