using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MILTON_PROJECT.IRepository
{
    public interface ITeachers
    {
        void GetTeachers();
        void GetTeacherDetails();
        void GetTeacherAttendance();

        void GetTeacherStudentDetails();
        void GetTeacherClassDetails();
    



    }
}