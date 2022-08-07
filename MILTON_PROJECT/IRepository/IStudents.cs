using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MILTON_PROJECT.Models;

namespace MILTON_PROJECT.IRepository
{
    public interface IStudents
    {
        void AddNewStudent(Students students);
        void AddstudentMarksDetails();
        void AddStudentAttendance();
        void GetStudentDetails();
        void GetStudentMarks();
        void GetStudentAttendanceDetails();

    }

}