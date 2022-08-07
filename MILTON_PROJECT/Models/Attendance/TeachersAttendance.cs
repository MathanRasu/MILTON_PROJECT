using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MILTON_PROJECT.Models.Attendance
{
    public class TeachersAttendance
    {
        public int Id { get; set; }

        public int? TeachersId { get; set; }

        public DateTime DayOfAttendance { get; set; }

        public int AttendanceStatus { get; set; }
    }
}