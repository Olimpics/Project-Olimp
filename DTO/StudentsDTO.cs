﻿namespace OlimpBack.DTO
{
    // DTO/StudentDto.cs
    public class StudentDto
    {
        public int IdStudents { get; set; }
        public string NameStudent { get; set; }
        public string StatusName { get; set; }
        public string FacultyName { get; set; }
        public string ProgramName { get; set; }
        public string DegreeName { get; set; }
        public string StudyFormName { get; set; }
        public DateOnly EducationStart { get; set; }
        public DateOnly EducationEnd { get; set; }
        public bool IsShort { get; set; }
    }

    // DTO/CreateStudentDto.cs
    public class CreateStudentDto
    {
        public int UserId { get; set; }
        public string NameStudent { get; set; }
        public int StatusId { get; set; }
        public DateOnly EducationStart { get; set; }
        public DateOnly EducationEnd { get; set; }
        public int FacultyId { get; set; }
        public int EducationalDegreeId { get; set; }
        public int StudyFormId { get; set; }
        public bool IsShort { get; set; }
        public int EducationalProgramId { get; set; }
    }

    // DTO/UpdateStudentDto.cs
    public class UpdateStudentDto : CreateStudentDto
    {
    }

}
