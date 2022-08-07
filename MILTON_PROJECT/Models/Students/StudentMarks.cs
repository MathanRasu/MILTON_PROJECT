using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MILTON_PROJECT.Models
{
    public class StudentMarks
    {
        public int Id { get; set; }

        public int? StudentId { get; set; }

        public long? RegNo { get; set; }

        public int? ClassSubjectId { get; set; }

        public int? Marks { get; set; }

        public string Status { get; set; }

        public string TestName { get; set; }
    }
}