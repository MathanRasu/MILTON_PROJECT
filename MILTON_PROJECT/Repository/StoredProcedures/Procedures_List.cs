using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MILTON_PROJECT.Repository.StoredProcedures
{
    public class Procedures_List
    {
        public string AddStudent { get; set; } = "Sp_AddStudent";
        public string UpdateStudent { get; set; } = "Sp_AddStudent";
        public string GetStudentAddress { get; set; } = "";
        public string GetStudent { get; set; } = "";
        public string AddTeacher { get; set; } = "";
        public string GetTeacher { get; set; } = "";
        public string AddStudentAttendance { get; set; } = "";
        public string GetstudentAttendanceDetails { get; set; } = "";
        public string AddTeachersAttendanceDetails { get; set; } = "";
        public string GetTeachersAttendanceDetails { get; set; } = "";
        public string AddStudentMarks { get; set; } = "";
        public string GetStudentMarks { get; set; } = "";
    }
}