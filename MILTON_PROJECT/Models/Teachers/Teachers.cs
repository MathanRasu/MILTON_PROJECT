using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MILTON_PROJECT.Models.Teachers
{
    public class Teachers
    {
        public int Id { get; set; }

        public string TeacherName { get; set; }

        public int? SubjectId { get; set; }

        public DateTime DateOfJoining { get; set; }
    }
}